using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace time
{
    public partial class Timer : UserControl
    {
        int FullTime = 0;
        int Hour;
        int Min;

        int WinHeight;
        int fontSize;

        string TimeForCMD = "/s /t ";

        Button[] btnArry;


        // Start Main Code
        //-------------------------------------------

        public Timer()
        {
            InitializeComponent();

        }

        private void Timer_Load(object sender, EventArgs e)
        {
            btnArry = new Button[] { m1, m2, m5, m10, m30, p1, p2, p5, p10, p30, rst, btCancel, ShutdownBtn };
            Timer_Resize(sender, e);
        }

        private void resetTime_Click(object sender, EventArgs e)
        {
            FullTime = 0;
            UpdateTime();
        }

        private void ShutdownBtn_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\System32\shutdown.exe", FormatTime());

            if (Properties.Settings.Default.isExitOnShutdown)
            {
                Application.Exit();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\System32\shutdown.exe", "-a");

            if (Properties.Settings.Default.isExitOnCancel)
            {
                Application.Exit();
            }
        }

        string FormatTime()
        {
            if (FullTime < 1)
            {
                FullTime = 1;
            }

            return TimeForCMD + (FullTime * 60);
        }

        void UpdateTime()
        {
            if (FullTime >= 60)
            {
                Hour = FullTime / 60;
                Min = FullTime % 60;
                ShutdownBtn.Text = "Shutdown in " + Hour + " Hour " + Min + " Min";
            }
            else
                ShutdownBtn.Text = "Shutdown in " + FullTime + " Min";
        }

        private void Timer_Resize(object sender, EventArgs e)
        {
            WinHeight = this.Size.Width;
            fontSize = 0;

            if (WinHeight < 500) { fontSize = 0; }
            else if (WinHeight < 600) { fontSize = 1; }
            else if (WinHeight < 700) { fontSize = 2; }
            else if (WinHeight > 700 && this.Size.Height > 500) { fontSize = 3; }
            else { fontSize = 2; }

            if (btnArry != null)
            {
                for (int i = 0; i < btnArry.Length; i++)
                {
                    btnArry[i].Font = Main.fonts[fontSize];

                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            FullTime += ((MyButton)sender).num;

            if (FullTime < 0)
            {
                FullTime = 0;
            }

            UpdateTime();
        }

    }
}
