using System.IO.Ports;
using System.Text.RegularExpressions;

namespace FiresWinForms
{
    public partial class Form1 : Form
    {
        private SerialControl? _serialControl;
        private List<DataModel> Data { get; set; } = [];
        private String dataPath = "";
        private DateTime timerEnd;
        private int measurementNum, counterEnd;
        private bool isWaiting;
        private bool isMeasuring;
        private bool changingSettings;
        private decimal rawValue, savedValue;
        private decimal Fmin, Fd, Fs, Td, Tt;

        private static readonly string filename = "data.xlsx";

        [GeneratedRegex(@"-?\d+")]
        private static partial Regex NumberRegex();

        public string[] ports = SerialPort.GetPortNames();

        public Form1()
        {
            InitializeComponent();
            AsssignSettings();
            logger.Text = "Vyberte COM port a pripojte sa";
            comboBoxPort.Items.AddRange(ports);
            if (ports.Length > 0)
            {
                comboBoxPort.SelectedItem = ports[0];
            }
        }

        public void AddDataValue(string rawValueStr)
        {
            try
            {
                string valueStr = NumberRegex().Match(rawValueStr).Value;
                rawValue = decimal.Parse(valueStr) / 10.0m;
                decimal value = rawValue - savedValue;
                actualData.Text = value.ToString();
                if (isWaiting && value > Fmin)
                {
                    StartMeasuring();
                }
                if (isMeasuring)
                {
                    //if (value < Fmin)
                    //{
                    //    counterEnd++;
                    //}
                    //if (counterEnd > 10)
                    //{
                    //    StopMeasuring();
                    //    ProcessData();
                    //    SaveData();
                    //    return;
                    //}

                    Data.Add(new DataModel
                    {
                        Time = GetElapsedTime(),
                        Value = value
                    });
                }
            }
            catch (Exception)
            {
                logger.Text = "Chyba zo zariadenia";
            }
        }

        private decimal GetElapsedTime()
        {
            return (timer1.Interval - (int)(timerEnd - DateTime.Now).TotalMilliseconds) / 1000.0m;
        }

        private string horizontalValuesStr()
        {
            if (showLimitsCheckbox.Checked)
            {
                return $"{Fmin}~{Fs}~{Fd}".Replace(',', '.');
            }
            else
            {
                return "";
            }
        }

        private string verticalValuesStr()
        {
            if (showLimitsCheckbox.Checked)
            {
                return $"{Td}~{Tt}".Replace(',', '.');
            }
            else
            {
                return "";
            }
        }

        private void AsssignSettings()
        {
            try
            {
                Fmin = decimal.Parse(silaFmin.Text);
                Fd = decimal.Parse(silaFd.Text);
                Fs = decimal.Parse(silaFs.Text);
                Td = decimal.Parse(casTd.Text);
                Tt = decimal.Parse(casTt.Text);
                timer1.Interval = (int)(decimal.Parse(casTt.Text) * 1000) + 1000;
                connectBtn.Enabled = true;
                if (_serialControl != null)
                {
                    startBtn.Enabled = true;
                    zeroBtn.Enabled = true;
                }
                logger.Text = "Nastavenia uložené";
            }
            catch (Exception)
            {
                logger.Text = "Nesprávny formát nastavení";
                connectBtn.Enabled = false;
                startBtn.Enabled = false;
                repeatBtn.Enabled = false;
            }
        }

        private void connect_Click(object sender, EventArgs e)
        {
            var selectedItem = comboBoxPort.SelectedItem?.ToString();
            if (selectedItem == null)
            {
                MessageBox.Show("Prosím, vyberte COM port.");
                return;
            }
            _serialControl = new SerialControl(selectedItem, this, actualData, logger);
            if (_serialControl == null)
            {
                return;
            }
            logger.Text = "Zariadenie pripojené";
            startBtn.Enabled = true;
            zeroBtn.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                while (!(_serialControl?.IsConnected ?? false))
                {
                    try
                    {
                        Invoke(new MethodInvoker(delegate ()
                        {
                            try
                            {
                                ports = SerialPort.GetPortNames();
                                if (ports.Length > comboBoxPort.Items.Count)
                                {
                                    comboBoxPort.Items.Clear();
                                    comboBoxPort.Items.AddRange(ports);
                                }
                            }
                            catch (Exception)
                            {
                            }
                        }));
                    }
                    catch (Exception)
                    {
                    }
                    await Task.Delay(1000);
                }
            });
        }

        private void StartWaiting()
        {
            savedValue = rawValue;
            listView1.Items.Clear();
            counterEnd = 0;
            Data = [];
            logger.Text = "Čaká na silu F > Fmin";
            startBtn.Text = "ZRUŠIŤ";
            isWaiting = true;
            disableButtons();
            graphPicture.Image?.Dispose();
            graphPicture.Image = null;
            graphPicture.Enabled = false;
            numberMeasure.Text = measurementNum.ToString();
        }

        private void StartMeasuring()
        {
            isWaiting = false;
            isMeasuring = true;
            timerEnd = DateTime.Now.AddMilliseconds(timer1.Interval);
            timer1.Start();
            logger.Text = "Prebieha meranie";
        }

        private void StopMeasuring()
        {
            isMeasuring = false;
            timer1.Stop();
            logger.Text = "Meranie ukončené";
            startBtn.Text = "SPUSTIŤ";
            enableButtons();
            loadingBox.Visible = true;
        }

        private void ProcessData()
        {
            if (Data.Count == 0)
            {
                return;
            }

            // Show data in list view
            var i = 0;
            foreach (var item in Data)
            {
                string[] row = { (++i).ToString(), string.Format("{0:N3}", item.Time), item.Value.ToString() ?? "" };
                listView1.Items.Add(new ListViewItem(row));
            }

            // Find max value
            var max = Data.Max(x => x.Value);
            maxValue.Text = max.ToString();
            conditionFdmax.BackColor = max > Fd ? Color.Red : Color.Green;

            // Find last value
            var last = Data.Last().Value;
            conditionFmin.BackColor = last > Fmin ? Color.Red : Color.Green;

            // Find last value after Td
            var lastAfterTd = Data.Where(x => x.Time >= Td).FirstOrDefault()?.Value;
            conditionFs.BackColor = lastAfterTd > Fs ? Color.Red : Color.Green;
        }

        private void SaveData()
        {
            if (XlsSaver.fileCreated == false)
            {
                dataPath = $"Data\\{DateTime.Now.ToString("dd-MM-yyyy")}__";
                var i = 1;
                while (Directory.Exists(dataPath + i))
                {
                    i++;
                }
                dataPath += i;
                Directory.CreateDirectory(dataPath);
                XlsSaver.dataPath = $"{dataPath}\\{filename}";
            }

            try
            {
                Task.Run(() =>
                {
                    var data = new List<DataModel>(Data);
                    int measurementNum = this.measurementNum;
                    try
                    {
                        XlsSaver.SaveData(data, measurementNum);
                        Invoke(new MethodInvoker(delegate ()
                        {
                            graphPicture.Image?.Dispose();
                        }));
                        RunCmd.Run("graphCmd\\graphCmd.exe", $"{dataPath}\\{filename}", measurementNum, horizontalValuesStr(), verticalValuesStr(), true);
                    }
                    catch (Exception ex)
                    {
                        Invoke(new MethodInvoker(delegate ()
                        {
                            logger.Text = ex.Message;

                        }));
                    }
                    try
                    {
                        Invoke(new MethodInvoker(delegate ()
                        {
                            loadingBox.Visible = false;
                            graphPicture.Image = Image.FromFile($"{dataPath}\\Grafy\\" + measurementNum + ".png");
                            graphPicture.Enabled = true;
                        }));
                    }
                    catch (Exception)
                    {
                    }
                });
            }
            catch (Exception ex)
            {
                logger.Text = ex.Message;
            }
        }

        private void startMeasuring_Click(object sender, EventArgs e)
        {
            if (isWaiting || isMeasuring)
            {
                isWaiting = false;
                StopMeasuring();
            }
            else
            {
                measurementNum++;
                StartWaiting();
            }
        }

        private void repeatMeasuring_Click(object sender, EventArgs e)
        {
            StartWaiting();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StopMeasuring();
            ProcessData();
            SaveData();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void disableButtons()
        {
            conditionFdmax.BackColor = Color.White;
            conditionFmin.BackColor = Color.White;
            conditionFs.BackColor = Color.White;

            repeatBtn.Enabled = false;
            connectBtn.Enabled = false;
            zeroBtn.Enabled = false;

            ActiveControl = null;
        }

        private void enableButtons()
        {
            connectBtn.Enabled = true;
            repeatBtn.Enabled = true;
            zeroBtn.Enabled = true;
        }

        private void changeSettings_Click(object sender, EventArgs e)
        {
            changingSettings = !changingSettings;
            if (changingSettings)
            {
                changeSettings.Text = "Uložiť";
            }
            else
            {
                changeSettings.Text = "Upraviť";
                AsssignSettings();
            }
            silaFmin.Enabled = changingSettings;
            silaFd.Enabled = changingSettings;
            silaFs.Enabled = changingSettings;
            casTd.Enabled = changingSettings;
            casTt.Enabled = changingSettings;
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            savedValue = rawValue;
        }

        private void graphPicture_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                RunCmd.Run("graphCmd\\graphCmd.exe", $"{dataPath}\\{filename}", measurementNum, horizontalValuesStr(), verticalValuesStr());
            });
        }

        private void showLimitsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (XlsSaver.fileCreated)
            {
                loadingBox.Visible = true;
                graphPicture.Image?.Dispose();
                graphPicture.Image = null;
                graphPicture.Enabled = false;

                Task.Run(() =>
                {
                    try
                    {
                        RunCmd.Run("graphCmd\\graphCmd.exe", $"{dataPath}\\{filename}", measurementNum, horizontalValuesStr(), verticalValuesStr(), true);
                        Invoke(new MethodInvoker(delegate ()
                        {
                            loadingBox.Visible = false;
                            graphPicture.Image = Image.FromFile($"{dataPath}\\Grafy\\" + measurementNum + ".png");
                            graphPicture.Enabled = true;
                        }));
                    }
                    catch (Exception ex)
                    {
                        Invoke(new MethodInvoker(delegate ()
                        {
                            logger.Text = ex.Message;
                        }));
                    }
                });
            }
        }
    }
}
