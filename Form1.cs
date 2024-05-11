using ScottPlot;
using System.IO.Ports;

namespace sPlotter
{
    public partial class Form1 : Form
    {

        public Thread readThread;
        public String ReadSerialVal;

        static bool _continue = false;
        public static SerialPort _serialPort = new SerialPort();

        public String touched_temp = "0";
        public int pos_x = 0, pos_y = 0, m_x, m_y;
        public int a, b;
        public bool btn_clear = false;

        public int total_x, total_y;
        List<double> x = new List<double>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<double> y = new List<double>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public Form1()
        {
            InitializeComponent();
        }

        static List<double> MovingAverage(List<double> data, int windowSize)
        {
            List<double> filteredData = new List<double>();

            for (int i = windowSize-1; i != (data.Count-1); i++)
            {
                double sum = 0;

                for (int j = 4; j != 0; j--)
                {
                    sum = sum + data[i - j];

                }

                // Calculate the average and add it to the filtered data
                filteredData.Add((double)(sum / windowSize));
            }

            return filteredData;
        }

        static double[] Lowpass(List<double> x, double dt, double RC)
        {
            int n = x.Count;
            double[] y = new double[n];
            double alpha = dt / (RC + dt);
            
            y[0] = alpha * x[0];
            
            for (int i = 1; i < n; i++)
            {
                y[i] = alpha * x[i] + (1 - alpha) * y[i - 1];
            }
            return y;
        }

        static double[] Highpass(List<double> x, double dt, double RC)
        {
            int n = x.Count;
            double[] y = new double[n];
            double alpha = RC / (RC + dt);

            y[0] = x[0];
            for (int i = 1; i < n; i++)
            {
                y[i] = alpha * y[i - 1] + alpha * (x[i] - x[i - 1]);
            }

            return y;
        }




        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            double[] arr_x = x.ToArray();
            double[] arr_y = y.ToArray();

            formsPlot1.Plot.Add.Scatter(x.ToArray(), arr_y);
            formsPlot1.Refresh();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            /* if (!btn_clear) {
                x.Clear();
                y.Clear();
                formsPlot1.Reset();
                btn_clear = !btn_clear;
            }*/


            if (!_continue)
            {
                x.Clear();
                y.Clear();
                formsPlot1.Reset();
                StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;



                // Allow the user to set the appropriate properties.
                _serialPort.PortName = comboBox1.Text;
                _serialPort.BaudRate = int.Parse(comboBox2.Text);

                // Set the read/write timeouts
                _serialPort.ReadTimeout = 500;
                _serialPort.WriteTimeout = 500;

                try
                {
                    _serialPort.Open();
                    button1.BackColor = System.Drawing.Color.Red;
                    _continue = true;
                    button1.Text = "Close";
                    readThread = new Thread(Read);
                    readThread.Start();

                }
                catch (Exception eee)
                {
                    MessageBox.Show(eee.Message);
                }

            }
            else
            {
                button1.BackColor = System.Drawing.Color.OliveDrab;
                button1.Text = "Begin";
                //readThread.Abort();
                _serialPort.Close();
                _continue = false;
            }

        }

        static double[] GenerateNumbers(double n)
        {
            double[] arr = new double[(int)n];
            for (double i = 1; i <= n; i++)
            {
                arr[(int)i - 1] = i;
            }
            return arr;
        }

        private void UpdateLabel(string newText)
        {
            // Reset Plot 
            formsPlot1.Reset();

            // Push the Incoming data to Terminal
            richTextBox1.AppendText(newText + "\n");

            // Cast the value to number and store it in array/
            double val = double.Parse(newText);
            y.Add(val);
            x.Add(y.Count);

            double[] arr_x = x.ToArray();
            double[] arr_y = y.ToArray();

            // Plot the array
            formsPlot1.Plot.Add.SignalXY(arr_x, arr_y);


            // If Moving average is selected, plot moving average
            if(checkedListBox1.GetItemChecked(0) == true )
            {
                if (y.Count > ((int)numericUpDown1.Value)) { 

                    // Push the main signal to MovingAverage Function that returns filtered signal as List
                    List<double> Moving_avg_array = MovingAverage(y, ((int)numericUpDown1.Value));
                    formsPlot1.Plot.Add.Signal(Moving_avg_array.ToArray());
                }
            }

            // If Low pass filter applied, implement low pass filter
            if (checkedListBox2.GetItemChecked(0) == true)
            {
                double[] lpf_data = Lowpass(y, double.Parse(RC_txtBox.Text), double.Parse(dT_txtBox.Text));
                formsPlot1.Plot.Add.Signal(lpf_data);
                
            }

            // If Low pass filter applied, implement low pass filter
            if (checkedListBox3.GetItemChecked(0) == true)
            {
                double[] hpf_data = Highpass(y, double.Parse(hpf_RC_txtbx.Text), double.Parse(hpf_dT_txtbx.Text));
                formsPlot1.Plot.Add.Signal(hpf_data);

            }





            formsPlot1.Refresh();

            richTextBox1.ScrollToCaret();
        }


        public delegate void ShowSerialData(String r);
        private void Read()
        {
            while (_continue)
            {
                try
                {

                    ReadSerialVal = _serialPort.ReadLine();
                    if (richTextBox1.InvokeRequired)
                    {
                        ShowSerialData ssd = UpdateLabel;
                        Invoke(ssd, ReadSerialVal);
                    }
                    else
                    {
                        richTextBox1.AppendText(ReadSerialVal);
                        richTextBox1.ScrollToCaret();
                    }

                }
                catch (TimeoutException)
                {

                }
                catch (Exception ex)
                {
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog to request a path and file name to save to.
            SaveFileDialog saveFile1 = new SaveFileDialog();

            // Initialize the SaveFileDialog to specify the csv extension for the file.
            saveFile1.DefaultExt = "*.csv";
            saveFile1.Filter = "CSV Files|*.csv";

            // Determine if the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Enabled = true;


        }
    }

}