using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouAreAnIdiot_UnFlash
{
    public partial class HAHA : Form
    {
        Challenge ChallengeInstance;

        public HAHA(Challenge challengeInstance)
        {
            InitializeComponent();
            ChallengeInstance = challengeInstance;
            MovingWindow.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Rectangle workingArea = SystemInformation.WorkingArea;
            int num = checked(Screen.PrimaryScreen.Bounds.Width - this.Width);
            int height = Screen.PrimaryScreen.Bounds.Height;
            int integer1 = Conversions.ToInteger(this.MoveX.Text);
            int integer2 = Conversions.ToInteger(this.MoveY.Text);
            double multiplier = 1;
            if (height >= 1440) multiplier = 2;
            if (Conversions.ToDouble(this.X.Text) >= (double)num)
            {
                this.MoveX.Text = Conversions.ToString(checked(-(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd()))) * multiplier));
                if (Conversions.ToDouble(this.MoveY.Text) < 0.0)
                    this.MoveY.Text = Conversions.ToString(checked(-(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd()))) * multiplier));
                else if (Conversions.ToDouble(this.MoveY.Text) > 0.0)
                    this.MoveY.Text = Conversions.ToString(checked(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd())) * multiplier));
            }
            if (Conversions.ToDouble(this.Y.Text) >= (double)checked(height - this.Height))
            {
                this.MoveY.Text = Conversions.ToString(checked(-(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd()))) * multiplier));
                if (Conversions.ToDouble(this.MoveX.Text) < 0.0)
                    this.MoveX.Text = Conversions.ToString(checked(-(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd()))) * multiplier));
                else if (Conversions.ToDouble(this.MoveX.Text) > 0.0)
                    this.MoveX.Text = Conversions.ToString(checked(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd())) * multiplier));
            }
            if (Conversions.ToDouble(this.X.Text) <= 0.0)
            {
                this.MoveX.Text = Conversions.ToString(checked(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd())) * multiplier));
                if (Conversions.ToDouble(this.MoveY.Text) < 0.0)
                    this.MoveY.Text = Conversions.ToString(checked(-(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd()))) * multiplier));
                else if (Conversions.ToDouble(this.MoveY.Text) > 0.0)
                    this.MoveY.Text = Conversions.ToString(checked(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd())) * multiplier));
            }
            if (Conversions.ToDouble(this.Y.Text) <= 0.0)
            {
                this.MoveY.Text = Conversions.ToString(checked(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd())) * multiplier));
                if (Conversions.ToDouble(this.MoveY.Text) < 0.0)
                    this.MoveY.Text = Conversions.ToString(checked(-(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd()))) * multiplier));
                else if (Conversions.ToDouble(this.MoveY.Text) > 0.0)
                    this.MoveY.Text = Conversions.ToString(checked(1 + (int)Math.Round((double)unchecked(34f * VBMath.Rnd())) * multiplier));
            }
            this.X.Text = Conversions.ToString(Conversions.ToDouble(this.X.Text) + (double)integer1);
            this.Y.Text = Conversions.ToString(Conversions.ToDouble(this.Y.Text) + (double)integer2);
            this.Location = new Point(Conversions.ToInteger(this.X.Text), Conversions.ToInteger(this.Y.Text));
        }

        private bool closeNow = false;

        private async void HAHA_Closing(object sender, FormClosingEventArgs e)
        {
            if (Challenge.IsGamified)
            {
                if (!closeNow)
                {
                    e.Cancel = true;
                    ChallengeInstance.Score += 1;
                    MemoryStream memoryStream = new MemoryStream(Properties.Resources.fire);
                    pictureBox1.Image = Image.FromStream(memoryStream);
                    await Task.Delay(500);
                    closeNow = true;
                    this.Close();
                }
            }
            if (Question.CloseGracefully) return;
            HAHA haha1 = new HAHA(ChallengeInstance);
            HAHA haha2 = new HAHA(ChallengeInstance);
            haha1.Show();
            haha2.Show();
        }

        private void HAHA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q) Process.GetCurrentProcess().Kill();
        }
    }
}
