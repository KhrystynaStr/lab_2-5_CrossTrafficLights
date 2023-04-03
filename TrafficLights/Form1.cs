namespace TrafficLights
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private TrafficLights trafficLights;
        private TrafficLights crossTrafficLights;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trafficLights = new TrafficLights(lampsPanel.CreateGraphics(), 1);
            crossTrafficLights = new TrafficLights(additionalPanel.CreateGraphics(), 3);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAuto_Click(object sender, EventArgs e)
        {
            periodGroupBox.Visible = true;
            redTextBox.Focus();
        }

        private void buttonManual_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            trafficLights.ChangeLamp();
            crossTrafficLights.ChangeLamp();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            periodGroupBox.Visible = false;
            timer.Enabled = true;
        }

        private uint GetPeeriod(TextBox box)
        {
            uint period = 0;
            try
            {
                period = uint.Parse(box.Text) * 1000;
            }
            catch
            {
                MessageBox.Show("Введіть ціле число (секунди)", "Помилка введення",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                box.Focus();
            }
            return period;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            trafficLights.ChangeLamp();
            crossTrafficLights.ChangeLamp();
            timer.Interval = trafficLights.GetInterval();
        }

        private void lampsPanel_Paint(object sender, PaintEventArgs e)
        {
            trafficLights.Draw();
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            trafficLights.SetInterval(box.TabIndex, GetPeeriod(box));
        }

        private void additionalPanel_Paint(object sender, PaintEventArgs e)
        {
            crossTrafficLights.Draw();
        }

        private void nightCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (nightCheckBox.Checked)
            {
                trafficLights.IsNight = true;
                crossTrafficLights.IsNight = true;
                buttonAuto.Enabled = false;
                buttonManual.Enabled = false;
            }
            else
            {
                trafficLights.IsNight = false;
                crossTrafficLights.IsNight = false;
                buttonAuto.Enabled = true;
                buttonManual.Enabled = true;
            }
           
        }
    }
}