using System;
using System.Windows.Forms;

namespace time
{
    public partial class Settings : UserControl
    {
        RadioButton[] ModeArry;

        int WinHeight;
        int WinWidth;
        int fontSize;

        public Settings()
        {
            InitializeComponent();

            ModeArry = new RadioButton[] { ModeLast, ModeSetTime, ModeTimer };

            ExitOnShutdownBtn.Checked = Properties.Settings.Default.isExitOnShutdown;
            ExitOnCancelBtn.Checked = Properties.Settings.Default.isExitOnCancel;
            ModeArry[Properties.Settings.Default.modestart].Checked = true;
        }

        private void ExitOnShutdownBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.isExitOnShutdown = !Properties.Settings.Default.isExitOnShutdown;
            Properties.Settings.Default.Save();
        }

        private void ExitOnCancelBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.isExitOnCancel = !Properties.Settings.Default.isExitOnCancel;
            Properties.Settings.Default.Save();
        }

        private void DarkTheme_Click(object sender, EventArgs e)
        {

        }

        private void StartModeType_Click(object sender, EventArgs e)
        {
            RadioButton rdB = (RadioButton)sender;
            Properties.Settings.Default.modestart = rdB.TabIndex;
        }

        private void Settings_Resize(object sender, EventArgs e)
        {
            WinHeight = this.Size.Height;
            WinWidth = this.Size.Width;
            fontSize = 0;
            if (WinHeight < 500 && WinWidth < 500) { fontSize = 0; }
            if (WinHeight > 500 && WinWidth > 450) { fontSize = 1; }
            if (WinHeight > 600 && WinWidth > 600) { fontSize = 2; }
            if (WinHeight > 750 && WinWidth > 900) { fontSize = 3; }


            if (ModeArry != null)
            {
                foreach (var i in ModeArry)
                {
                    i.Font = Main.fonts[fontSize];
                }
                ExitOnCancelBtn.Font = Main.fonts[fontSize];
                ExitOnShutdownBtn.Font = Main.fonts[fontSize];
            }
        }
    }
}
