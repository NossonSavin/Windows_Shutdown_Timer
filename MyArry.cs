using System;
using System.Drawing;
using System.Windows.Forms;

namespace time
{
    public class MyArry
    {
        public MyButton myButton = new MyButton();
        public IMyArry screen;

        public MyArry(int num, IMyArry i, EventHandler Event, string name)
        {
            myButton.Text = name;
            myButton.num = num;
            screen = i;
            myButton.Dock = DockStyle.Fill;
            myButton.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0);
            myButton.FlatAppearance.BorderSize = 0;
            myButton.FlatStyle = FlatStyle.Flat;
            myButton.Font = new Font("Times New Roman", 15F, System.Drawing.FontStyle.Italic);
            myButton.Click += Event;
        }
    }
}
