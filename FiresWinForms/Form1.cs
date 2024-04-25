using System.IO.Ports;

namespace FiresWinForms
{
    public partial class Form1 : Form
    {
        private SerialMeasureControl? _serialMeasureControl;
        private string[] ports = SerialPort.GetPortNames();
        private DateTime timerEnd;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(ports);
            textBox2.Text = "Vyberte COM port a pripojte sa";
        }

        public double GetRemainingTime()
        {
            return (timer1.Interval - (int)(timerEnd - DateTime.Now).TotalMilliseconds) / 1000.0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedItem = comboBox1.SelectedItem?.ToString();
            if (selectedItem == null)
            {
                MessageBox.Show("Prosím, vyberte COM port.");
                return;
            }
            _serialMeasureControl = new SerialMeasureControl(selectedItem, this, textBox1);
            textBox2.Text = "Pripojené na " + selectedItem;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //_serialMeasureControl = new SerialMeasureControl("COM5", this, textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _serialMeasureControl?.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Prebieha meranie";
            _serialMeasureControl?.StartMeasuring();
            timerEnd = DateTime.Now.AddMilliseconds(timer1.Interval);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _serialMeasureControl?.StopMeasuring();
            textBox2.Text = "Meranie ukončené";
            timer1.Stop();
            var data = _serialMeasureControl?.Data;
            if (data != null)
            {
                foreach (var item in data)
                {
                    string[] row = { item.Counter.ToString(), string.Format("{0:N3}", item.Time), item.Value.ToString() ?? "" };
                    listView1.Items.Add(new ListViewItem(row));
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void serialMeasureControlBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
