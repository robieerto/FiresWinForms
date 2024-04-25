using System.IO.Ports;

namespace FiresWinForms
{
    public class SerialMeasureControl : IDisposable
    {
        private readonly SerialPort _serialPort;
        private Form1 _form;
        private TextBox _output;
        public List<DataModel> Data { get; set; } = [];
        public bool IsMeasuring { get; set; }
        public int Counter { get; set; }

        public SerialMeasureControl(string comPort, Form1 form, TextBox output)
        {
            _form = form;
            _output = output;

            // Create a new SerialPort object with default settings.
            _serialPort = new SerialPort(comPort, 115200, Parity.None, 8, StopBits.One)
            {
                // Set the read/write timeouts
                ReadTimeout = 500,
                WriteTimeout = 500
            };

            _serialPort.Open();
            _serialPort.DataReceived += serialPort_DataReceived;
        }

        private void serialPort_DataReceived(object s, SerialDataReceivedEventArgs e)
        {
            if (!_form.IsDisposed)
            {
                _form?.Invoke(new MethodInvoker(delegate ()
                {
                    _output.Text = _serialPort.ReadLine();
                }));
            }
            if (IsMeasuring)
            {
                Data.Add(new DataModel
                {
                    Counter = ++Counter,
                    Time = _form?.GetRemainingTime(),
                    Value = double.Parse(_output.Text)
                });
            }
        }

        public void StartMeasuring()
        {
            IsMeasuring = true;
        }

        public void StopMeasuring()
        {
            IsMeasuring = false;
            Counter = 0;
        }

        public void Dispose()
        {
            _serialPort?.Close();
        }
    }
}