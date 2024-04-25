using System.IO.Ports;

namespace FiresWinForms
{
    public partial class Form1 : Form
    {
        private SerialMeasureControl? _serialMeasureControl;
        private string[] ports = SerialPort.GetPortNames();
        private DateTime timerEnd;
        private int measurementNum = 0;

        public Form1()
        {
            InitializeComponent();
            comboBoxPort.Items.AddRange(ports);
            logger.Text = "Vyberte COM port a pripojte sa";
        }

        public double GetRemainingTime()
        {
            return (timer1.Interval - (int)(timerEnd - DateTime.Now).TotalMilliseconds) / 1000.0;
        }

        private void connect_Click(object sender, EventArgs e)
        {
            var selectedItem = comboBoxPort.SelectedItem?.ToString();
            if (selectedItem == null)
            {
                MessageBox.Show("Prosím, vyberte COM port.");
                return;
            }
            _serialMeasureControl = new SerialMeasureControl(selectedItem, this, actualData, logger);
            logger.Text = "Pripojené na " + selectedItem;
            startMeasuring.Enabled = true;
            connect.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //_serialMeasureControl = new SerialMeasureControl("COM5", this, actualData, logger);
        }

        private void start()
        {
            logger.Text = "Prebieha meranie";
            showGraph.Enabled = false;
            numberMeasure.Text = measurementNum.ToString();
            _serialMeasureControl?.StartMeasuring();
            timerEnd = DateTime.Now.AddMilliseconds(timer1.Interval);
            timer1.Start();
        }

        private void startMeasuring_Click(object sender, EventArgs e)
        {
            measurementNum++;
            start();
        }

        private void repeatMeasuring_Click(object sender, EventArgs e)
        {
            start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _serialMeasureControl?.StopMeasuring();
            logger.Text = "Meranie ukončené";
            timer1.Stop();
            repeatMeasuring.Enabled = true;
            var data = _serialMeasureControl?.Data;
            if (_serialMeasureControl?.Data?.Count > 0)
            {
                listView1.Items.Clear();
                var counter = 0;
                foreach (var item in data)
                {
                    string[] row = { (++counter).ToString(), string.Format("{0:N3}", item.Time), item.Value.ToString() ?? "" };
                    listView1.Items.Add(new ListViewItem(row));
                }
                maxValue.Text = data.Max(x => x.Value).ToString();
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
                        XlsSaver.SaveData(data, measurementNum);
                        RunCmd.Run("graphCmd\\graphCmd.exe", "Data\\data.xlsx ", measurementNum, true);
                        Invoke(new MethodInvoker(delegate ()
                        {
                            showGraph.Enabled = true;
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
    }
}
