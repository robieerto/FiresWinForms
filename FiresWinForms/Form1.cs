using System.IO.Ports;
using System.Text.RegularExpressions;

namespace FiresWinForms
{
    public partial class Form1 : Form
    {
        private SerialControl? _serialControl;
        private List<DataModel> Data { get; set; } = [];
        private DateTime timerEnd;
        private int measurementNum;
        private bool isWaiting;
        private bool isMeasuring;
        private bool changingSettings;
        private decimal rawValue, savedValue;
        private decimal Fmin, Fd, Fs, Td, Tt;

        [GeneratedRegex(@"-?\d+")]
        private static partial Regex NumberRegex();

        public string[] ports = SerialPort.GetPortNames();

        public Form1()
        {
            InitializeComponent();
            comboBoxPort.Items.AddRange(ports);
            logger.Text = "Vyberte COM port a pripojte sa";
            AsssignSettings();
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
                    Data.Add(new DataModel
                    {
                        Time = GetRemainingTime(),
                        Value = value
                    });
                }
            }
            catch (Exception ex)
            {
                logger.Text = ex.Message;
            }
        }

        private double GetRemainingTime()
        {
            return (timer1.Interval - (int)(timerEnd - DateTime.Now).TotalMilliseconds) / 1000.0;
        }

        private void AsssignSettings()
        {
            Fmin = decimal.Parse(silaFmin.Text);
            Fd = decimal.Parse(silaFd.Text);
            Fs = decimal.Parse(silaFs.Text);
            Td = decimal.Parse(casTd.Text);
            Tt = decimal.Parse(casTt.Text);
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
            logger.Text = "Pripojené na " + selectedItem;
            startBtn.Enabled = true;
            zeroBtn.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // FOR TESTING
            _serialControl = new SerialControl("COM5", this, actualData, logger);
            startBtn.Enabled = true;
            zeroBtn.Enabled = true;
            // END FOR TESTING

            Task.Run(async () =>
            {
                while (_serialControl.IsConnected == false)
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
            Data = [];
            logger.Text = "Čaká na F > Fmin";
            startBtn.Text = "PRERUŠIŤ MERANIE";
            isWaiting = true;
            disableButtons();
            showGraph_Loading();
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
            startBtn.Text = "SPUSTIŤ MERANIE";
            enableButtons();
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
            if (Data?.Count > 0)
            {
                var counter = 0;
                foreach (var item in Data)
                {
                    string[] row = { (++counter).ToString(), string.Format("{0:N3}", item.Time), item.Value.ToString() ?? "" };
                    listView1.Items.Add(new ListViewItem(row));
                }
                maxValue.Text = Data.Max(x => x.Value).ToString();
                try
                {
                    Task.Run(() =>
                    {
                        if (XlsSaver.fileCreated == false)
                        {
                            try
                            {
                                var dir = new DirectoryInfo("Data\\Grafy");
                                dir.Delete(true);
                            }
                            catch (Exception)
                            {
                            }
                        }
                        XlsSaver.SaveData(Data, measurementNum);
                        RunCmd.Run("graphCmd\\graphCmd.exe", "Data\\data.xlsx ", measurementNum, true);
                        Invoke(new MethodInvoker(delegate ()
                        {
                            showGraph_Loaded();
                        }));
                    });
                }
                catch (Exception ex)
                {
                    logger.Text = ex.Message;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void showGraph_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                RunCmd.Run("graphCmd\\graphCmd.exe", "Data\\data.xlsx ", measurementNum);
            });
        }

        private void disableButtons()
        {
            connectBtn.Enabled = false;
            repeatBtn.Enabled = false;
            zeroBtn.Enabled = false;
        }

        private void enableButtons()
        {
            connectBtn.Enabled = true;
            repeatBtn.Enabled = true;
            zeroBtn.Enabled = true;
            showGraph_Loaded();
        }

        private void showGraph_Loading()
        {
            showGraphBtn.Enabled = false;
            showGraphBtn.Text = "";
            showGraphBtn.Image = Image.FromFile("images\\loading.gif");
        }

        private void showGraph_Loaded()
        {
            showGraphBtn.Enabled = true;
            showGraphBtn.Text = "ZOBRAZIŤ GRAF";
            showGraphBtn.Image = null;
        }

        private void changeSettings_Click(object sender, EventArgs e)
        {
            changingSettings = !changingSettings;
            if (changingSettings)
            {
                changeSettings.Text = "Potvrdiť";
                AsssignSettings();
            }
            else
            {
                changeSettings.Text = "Zmeniť";
            }
            silaFd.Enabled = changingSettings;
            silaFs.Enabled = changingSettings;
            casTd.Enabled = changingSettings;
            casTt.Enabled = changingSettings;
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            savedValue = rawValue;
        }
    }
}
