using NAudio.Wave;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace YouAreAnIdiot_UnFlash
{
    public partial class Challenge : Form
    {
        private int _score;
        internal int Score
        {
            get { return _score; }
            set
            {
                _score = value;
                scoreLabel.Text = _score.ToString();
            }
        }
        internal static bool IsGamified = false;

        private IWavePlayer OldWaveOut;

        public Challenge(IWavePlayer waveOut)
        {
            InitializeComponent();
            OldWaveOut = waveOut;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            OldWaveOut.Stop();

            Question.CloseGracefully = true;
            while (Application.OpenForms.Count > 2) Application.OpenForms["HAHA"].Close();
            Question.CloseGracefully = false;
            startButton.Enabled = false;

            countdownLabel.Visible = true;
            countdownTimer.Start();
        }

        private async void countdownTimer_Tick(object sender, EventArgs e)
        {
            countdownLabel.Text = (Convert.ToInt32(countdownLabel.Text) - 1).ToString();
            if (countdownLabel.Text == "0")
            {
                countdownTimer.Stop();
                countdownLabel.Text = "Go!";
                countdownLabel.Location = new Point(567, 320);
                IsGamified = true;
                challengeTimer.Start();

                HAHA haha1 = new HAHA(this);
                HAHA haha2 = new HAHA(this);
                HAHA haha3 = new HAHA(this);
                HAHA haha4 = new HAHA(this);
                HAHA haha5 = new HAHA(this);
                HAHA haha6 = new HAHA(this);
                HAHA haha7 = new HAHA(this);
                HAHA haha8 = new HAHA(this);
                HAHA haha9 = new HAHA(this);
                HAHA haha10 = new HAHA(this);
                haha1.Show();
                haha2.Show();
                haha3.Show();
                haha4.Show();
                haha5.Show();
                haha6.Show();
                haha7.Show();
                haha8.Show();
                haha9.Show();
                haha10.Show();

                await Task.Delay(2000);
                countdownLabel.Visible = false;
            }
        }

        private void challengeTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = (Convert.ToInt32(timeLabel.Text) - 1).ToString();
            if (timeLabel.Text == "0")
            {
                timeLabel.Text = "0";
                challengeTimer.Stop();
                IsGamified = false;
                Question.CloseGracefully = true;
                while (Application.OpenForms.Count > 2) Application.OpenForms["HAHA"].Close();
                Question.CloseGracefully = false;
            }
        }

        private void Challenge_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 2) Process.GetCurrentProcess().Kill();
        }
    }
}
