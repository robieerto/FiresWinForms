using System.IO.Ports;

namespace FiresWinForms
{
    public class SerialMeasureControl : IDisposable
    {
        private readonly SerialPort _serialPort;
        private Form1 _form;
        private TextBox _output;
        private TextBox _logger;
        public List<DataModel> Data { get; set; } = [];
        public bool IsMeasuring { get; set; }

        public SerialMeasureControl(string comPort, Form1 form, TextBox output, TextBox logger)
        {
            _form = form;
            _output = output;
            _logger = logger;

            // Create a new SerialPort object with default settings.
            _serialPort = new SerialPort(comPort, 115200, Parity.None, 8, StopBits.One);
            //{
            //    // Set the read/write timeouts
            //    ReadTimeout = 500,
            //    WriteTimeout = 500
            //};

            _serialPort.Open();
            _serialPort.DataReceived += serialPort_DataReceived;
        }

        private void serialPort_DataReceived(object s, SerialDataReceivedEventArgs e)
        {
            if (!_form.IsDisposed)
            {
                _form?.Invoke(new MethodInvoker(delegate ()
                {
                    try
                    {
                        _output.Text = double.Parse(_serialPort.ReadLine()).ToString();
                    }
                    catch (Exception e)
                    {
                        _logger.Text = e.Message;
                    }
                }));
            }
            if (IsMeasuring)
            {
                Data.Add(new DataModel
                {
                    Time = _form?.GetRemainingTime(),
                    Value = double.Parse(_output.Text)
                });
            }
        }

        public void StartMeasuring()
        {
            Data = [];
            IsMeasuring = true;
        }

        public void StopMeasuring()
        {
            IsMeasuring = false;
        }

        public void Dispose()
        {
            _serialPort?.Close();
        }
    }
}