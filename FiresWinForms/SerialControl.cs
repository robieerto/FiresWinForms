using System.IO.Ports;

namespace FiresWinForms
{
    public partial class SerialControl : IDisposable
    {
        private readonly SerialPort? _serialPort;
        private Form1 _form;
        private TextBox _output;
        private TextBox _logger;

        public bool IsConnected { get; set; }

        public SerialControl(string comPort, Form1 form, TextBox output, TextBox logger)
        {
            _form = form;
            _output = output;
            _logger = logger;

            try
            {
                // Close the port if it is already open
                if (_serialPort?.IsOpen == true)
                {
                    _serialPort?.Close();
                }

                // Create a new SerialPort object with default settings with timeouts
                _serialPort = new SerialPort(comPort, 115200, Parity.None, 8, StopBits.One);

                _serialPort.Open();
                _serialPort.DataReceived += SerialPort_DataReceived;
                _serialPort.PinChanged += SerialPort_PinChanged;
                _serialPort.ErrorReceived += SerialPort_ErrorReceived;

                IsConnected = true;

                Task.Run(async () =>
                {
                    while (true)
                    {
                        if (IsConnected && IsSerialPortOpen() == false)
                        {
                            IsConnected = false;
                            Invoke(() =>
                            {
                                _logger.Text = "Zariadenie odpojené";
                            });
                        }
                        await Task.Delay(1000);
                    }
                });
            }
            catch (Exception e)
            {
                _logger.Text = e.Message;
            }
        }

        public bool IsSerialPortOpen()
        {
            return _serialPort?.IsOpen == true;
        }

        private void Invoke(Action action)
        {
            try
            {
                if (!_form.Disposing && !_form.IsDisposed)
                {
                    _form?.Invoke(new MethodInvoker(delegate ()
                    {
                        try
                        {
                            action();
                        }
                        catch (Exception e)
                        {
                            _logger.Text = e.Message;
                        }
                    }));
                }
            }
            catch (Exception)
            {
            }
        }

        private void SerialPort_DataReceived(object s, SerialDataReceivedEventArgs e)
        {
            string? line = _serialPort?.ReadLine();
            if (line != null)
            {
                Invoke(() =>
                {
                    _form.AddDataValue(line);
                });
            }
        }

        private void SerialPort_PinChanged(object s, SerialPinChangedEventArgs e)
        {
            Invoke(() =>
            {
                _logger.Text = e.ToString();
            });
        }

        private void SerialPort_ErrorReceived(object s, SerialErrorReceivedEventArgs e)
        {
            Invoke(() =>
            {
                _logger.Text = e.ToString();
            });
        }

        public void Dispose()
        {
            _serialPort?.Close();
        }
    }
}