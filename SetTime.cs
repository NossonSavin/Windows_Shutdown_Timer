using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace time
{
    public partial class SetTime : UserControl
    {
        DateTime moment = DateTime.Now;

        Button[] btnArry;
        MyButton tempButton;

        int WinHeight;
        int fontSize;

        int[] timeArry = { 0, 12, 0, 0 };
        int activenum = 1;
        bool isPM = true;

        int hour;
        int min;
        int HourMin;
        int newHour;
        int newMin;

        string TimeForCMD = "/s /t ";

        // Start Main Code
        //-------------------------------------------

        public SetTime()
        {
            InitializeComponent();
        }

        private void SetTime_Load(object sender, EventArgs e)
        {
            btnArry = new Button[]{ arryH1, arryM1, arryM2, num0, num1, num2, num3, num4, num5, num6,
                num7, num8, num9, num10, num11, num12, numCl, ShutdownBtn, btCancel
            };

            btPM.Checked = true;
        }

        private void SetTime_Resize(object sender, EventArgs e)
        {
            WinHeight = this.Size.Height;
            fontSize = 0;

            if (WinHeight < 500) { fontSize = 0; }
            else if (WinHeight < 600) { fontSize = 1; }
            else if (WinHeight < 700) { fontSize = 2; }
            else if (WinHeight > 700 && this.Size.Width > 500) { fontSize = 3; }
            else { fontSize = 2; }

            if (btnArry != null)
            {
                for (int i = 0; i < btnArry.Length; i++)
                {
                    btnArry[i].Font = Main.fonts[fontSize];
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            timeArry[1] = 12;
            timeArry[2] = 0;
            timeArry[3] = 0;
            activenum = 1;
            arryH1.Text = 12.ToString();
            arryM1.Text = 0.ToString();
            arryM2.Text = 0.ToString();
            convertTime();
        }

        private void btAM_CheckedChanged(object sender, EventArgs e)
        {
            isPM = false;
            convertTime();
        }

        private void btPM_CheckedChanged(object sender, EventArgs e)
        {
            isPM = true;
            convertTime();
        }

        private void activeTimeSlot(object sender, EventArgs e)
        {
            tempButton = (MyButton)sender;
            activenum = tempButton.num;
        }

        private void setTimeClick(object sender, EventArgs e)
        {
            tempButton = (MyButton)sender;

            if (activenum == 1 && tempButton.num <= 12 && tempButton.num >= 1)
            {
                arryH1.Text = tempButton.num.ToString();
                timeArry[1] = tempButton.num;
                activenum++;
            }

            else if (activenum == 2 && tempButton.num <= 5)
            {
                arryM1.Text = tempButton.num.ToString();
                timeArry[2] = tempButton.num;
                activenum++;
            }

            else if (activenum == 3 && tempButton.num <= 9)
            {
                arryM2.Text = tempButton.num.ToString();
                timeArry[3] = tempButton.num;
                activenum++;
            }

            convertTime();
        }

        string convertTime()
        {
            moment = DateTime.Now;

            if (isPM)
            {
                hour = (timeArry[1] == 12 ? 12 : timeArry[1] + 12) - moment.Hour;
            }

            else
            {
                hour = (timeArry[1] == 12 ? 0 : timeArry[1]) - moment.Hour;
            }

            min = (timeArry[2] * 10) + timeArry[3] - moment.Minute;
            HourMin = hour * 60 + min;

            if (HourMin < 0)
            {
                HourMin += 24 * 60;
            }

            newHour = HourMin / 60;
            newMin = HourMin % 60;
            ShutdownBtn.Text = $"{newHour:00} Hour {newMin:00} Min";
            return TimeForCMD + (HourMin * 60);
        }

        private void ShutdownBtn_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\System32\shutdown.exe", convertTime());

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
    }
}