using System;
using System.Drawing;
using System.Windows.Forms;

namespace time
{
    public partial class Main : Form
    {
        public static Font[] fonts = new Font[] { new Font("Sylfaen", 15, FontStyle.Italic),
                                     new Font("Sylfaen", 20, FontStyle.Italic),
                                     new Font("Sylfaen", 25, FontStyle.Italic),
                                     new Font("Sylfaen", 40, FontStyle.Italic)
        };

        MyArry[] myArry = new MyArry[6];

        // Start Main Code
        //-------------------------------------------

        public Main()
        {
            InitializeComponent();

            myArry[0] = new MyArry(1, setTime1, MenuBtn_Click, "Set Time");
            myArry[1] = new MyArry(2, timer1, MenuBtn_Click, "Timer");
            myArry[5] = new MyArry(6, settings1, MenuBtn_Click, "Settings");

            if (Properties.Settings.Default.modestart == 0)
            {
                SetActiveBtn(Properties.Settings.Default.Mode);
            }
            else
            {
                SetActiveBtn(Properties.Settings.Default.modestart);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Add(myArry[0].myButton, 0, 0);
            tableLayoutPanel2.Controls.Add(myArry[1].myButton, 0, 1);
            tableLayoutPanel2.Controls.Add(myArry[5].myButton, 0, 5);

            // Set window location
            if (Properties.Settings.Default.Place != null)
            {
                this.Location = Properties.Settings.Default.Place;
            }

            // Set window size
            if (Properties.Settings.Default.Size != null)
            {
                this.Size = Properties.Settings.Default.Size;
            }
        }

        private void FormsClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Size = this.Size;
            Properties.Settings.Default.Place = this.Location;
            Properties.Settings.Default.Save();
        }

        public void MenuBtn_Click(object sender, EventArgs e)
        {
            SetActiveBtn(((MyButton)sender).num);
        }

        void SetActiveBtn(int state)
        {
            for (int i = 0; i < myArry.Length; i++)
            {
                if (myArry[i] != null)
                {
                    myArry[i].myButton.BackColor = Color.FromArgb(50, 50, 50);
                    myArry[i].myButton.ForeColor = Color.FromArgb(180, 180, 180);
                    myArry[i].myButton.Margin = new Padding(2, 20, 3, 20);
                    ((UserControl)myArry[i].screen).Hide();
                }
            }

            ((UserControl)myArry[state - 1].screen).Show();
            myArry[state - 1].myButton.BackColor = Color.FromArgb(20, 40, 40);
            myArry[state - 1].myButton.ForeColor = Color.White;
            myArry[state - 1].myButton.Margin = new Padding(0);

            if (state != 6)
            {
                Properties.Settings.Default.Mode = state;
            }
        }
    }
}
