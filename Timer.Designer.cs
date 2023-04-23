namespace time
{
    partial class Timer : IMyArry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShutdownBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.p30 = new time.MyButton();
            this.p10 = new time.MyButton();
            this.p5 = new time.MyButton();
            this.p2 = new time.MyButton();
            this.p1 = new time.MyButton();
            this.rst = new time.MyButton();
            this.m30 = new time.MyButton();
            this.m10 = new time.MyButton();
            this.m5 = new time.MyButton();
            this.m2 = new time.MyButton();
            this.btCancel = new System.Windows.Forms.Button();
            this.m1 = new time.MyButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btRun
            // 
            this.ShutdownBtn.AutoSize = true;
            this.ShutdownBtn.BackColor = System.Drawing.Color.Firebrick;
            this.tableLayoutPanel1.SetColumnSpan(this.ShutdownBtn, 5);
            this.ShutdownBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShutdownBtn.FlatAppearance.BorderSize = 0;
            this.ShutdownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutdownBtn.ForeColor = System.Drawing.Color.White;
            this.ShutdownBtn.Location = new System.Drawing.Point(4, 248);
            this.ShutdownBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShutdownBtn.Name = "btRun";
            this.ShutdownBtn.Size = new System.Drawing.Size(492, 66);
            this.ShutdownBtn.TabIndex = 14;
            this.ShutdownBtn.Text = "Shutdown in 0 Min";
            this.ShutdownBtn.UseVisualStyleBackColor = false;
            this.ShutdownBtn.Click += new System.EventHandler(this.ShutdownBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.p30, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.p10, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.p5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.p2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.p1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rst, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.m30, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.m10, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.m5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.m2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btCancel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ShutdownBtn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.m1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.846154F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 400);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // p30
            // 
            this.p30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            this.p30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.p30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p30.FlatAppearance.BorderSize = 0;
            this.p30.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.p30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(89)))), ((int)(((byte)(253)))));
            this.p30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p30.ForeColor = System.Drawing.Color.Black;
            this.p30.Location = new System.Drawing.Point(404, 157);
            this.p30.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p30.Name = "p30";
            this.p30.num = 30;
            this.p30.Size = new System.Drawing.Size(92, 66);
            this.p30.TabIndex = 29;
            this.p30.Text = "+30";
            this.p30.UseVisualStyleBackColor = false;
            this.p30.Click += new System.EventHandler(this.Btn_Click);
            // 
            // p10
            // 
            this.p10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            this.p10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.p10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p10.FlatAppearance.BorderSize = 0;
            this.p10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.p10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(89)))), ((int)(((byte)(253)))));
            this.p10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p10.ForeColor = System.Drawing.Color.Black;
            this.p10.Location = new System.Drawing.Point(304, 157);
            this.p10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p10.Name = "p10";
            this.p10.num = 10;
            this.p10.Size = new System.Drawing.Size(92, 66);
            this.p10.TabIndex = 28;
            this.p10.Text = "+10";
            this.p10.UseVisualStyleBackColor = false;
            this.p10.Click += new System.EventHandler(this.Btn_Click);
            // 
            // p5
            // 
            this.p5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            this.p5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.p5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p5.FlatAppearance.BorderSize = 0;
            this.p5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.p5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(89)))), ((int)(((byte)(253)))));
            this.p5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p5.ForeColor = System.Drawing.Color.Black;
            this.p5.Location = new System.Drawing.Point(204, 157);
            this.p5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p5.Name = "p5";
            this.p5.num = 5;
            this.p5.Size = new System.Drawing.Size(92, 66);
            this.p5.TabIndex = 27;
            this.p5.Text = "+5";
            this.p5.UseVisualStyleBackColor = false;
            this.p5.Click += new System.EventHandler(this.Btn_Click);
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            this.p2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.p2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p2.FlatAppearance.BorderSize = 0;
            this.p2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.p2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(89)))), ((int)(((byte)(253)))));
            this.p2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p2.ForeColor = System.Drawing.Color.Black;
            this.p2.Location = new System.Drawing.Point(104, 157);
            this.p2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p2.Name = "p2";
            this.p2.num = 2;
            this.p2.Size = new System.Drawing.Size(92, 66);
            this.p2.TabIndex = 26;
            this.p2.Text = "+2";
            this.p2.UseVisualStyleBackColor = false;
            this.p2.Click += new System.EventHandler(this.Btn_Click);
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            this.p1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p1.FlatAppearance.BorderSize = 0;
            this.p1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.p1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(89)))), ((int)(((byte)(253)))));
            this.p1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p1.ForeColor = System.Drawing.Color.Black;
            this.p1.Location = new System.Drawing.Point(4, 157);
            this.p1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p1.Name = "p1";
            this.p1.num = 1;
            this.p1.Size = new System.Drawing.Size(92, 66);
            this.p1.TabIndex = 25;
            this.p1.Text = "+1";
            this.p1.UseVisualStyleBackColor = false;
            this.p1.Click += new System.EventHandler(this.Btn_Click);
            // 
            // rst
            // 
            this.rst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            this.rst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.SetColumnSpan(this.rst, 5);
            this.rst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rst.FlatAppearance.BorderSize = 0;
            this.rst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(89)))), ((int)(((byte)(253)))));
            this.rst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rst.ForeColor = System.Drawing.Color.Black;
            this.rst.Location = new System.Drawing.Point(4, 81);
            this.rst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rst.Name = "rst";
            this.rst.num = 0;
            this.rst.Size = new System.Drawing.Size(492, 66);
            this.rst.TabIndex = 24;
            this.rst.Text = "Reset Time";
            this.rst.UseVisualStyleBackColor = false;
            this.rst.Click += new System.EventHandler(this.resetTime_Click);
            // 
            // m30
            // 
            this.m30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            this.m30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m30.FlatAppearance.BorderSize = 0;
            this.m30.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.m30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(89)))), ((int)(((byte)(253)))));
            this.m30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m30.ForeColor = System.Drawing.Color.Black;
            this.m30.Location = new System.Drawing.Point(404, 5);
            this.m30.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m30.Name = "m30";
            this.m30.num = -30;
            this.m30.Size = new System.Drawing.Size(92, 66);
            this.m30.TabIndex = 23;
            this.m30.Text = "-30";
            this.m30.UseVisualStyleBackColor = false;
            this.m30.Click += new System.EventHandler(this.Btn_Click);
            // 
            // m10
            // 
            this.m10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            this.m10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m10.FlatAppearance.BorderSize = 0;
            this.m10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.m10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(89)))), ((int)(((byte)(253)))));
            this.m10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m10.ForeColor = System.Drawing.Color.Black;
            this.m10.Location = new System.Drawing.Point(304, 5);
            this.m10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m10.Name = "m10";
            this.m10.num = -10;
            this.m10.Size = new System.Drawing.Size(92, 66);
            this.m10.TabIndex = 22;
            this.m10.Text = "-10";
            this.m10.UseVisualStyleBackColor = false;
            this.m10.Click += new System.EventHandler(this.Btn_Click);
            // 
            // m5
            // 
            this.m5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            this.m5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m5.FlatAppearance.BorderSize = 0;
            this.m5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.m5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(89)))), ((int)(((byte)(253)))));
            this.m5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m5.ForeColor = System.Drawing.Color.Black;
            this.m5.Location = new System.Drawing.Point(204, 5);
            this.m5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m5.Name = "m5";
            this.m5.num = -5;
            this.m5.Size = new System.Drawing.Size(92, 66);
            this.m5.TabIndex = 21;
            this.m5.Text = "-5";
            this.m5.UseVisualStyleBackColor = false;
            this.m5.Click += new System.EventHandler(this.Btn_Click);
            // 
            // m2
            // 
            this.m2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            this.m2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m2.FlatAppearance.BorderSize = 0;
            this.m2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.m2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(89)))), ((int)(((byte)(253)))));
            this.m2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m2.ForeColor = System.Drawing.Color.Black;
            this.m2.Location = new System.Drawing.Point(104, 5);
            this.m2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m2.Name = "m2";
            this.m2.num = -2;
            this.m2.Size = new System.Drawing.Size(92, 66);
            this.m2.TabIndex = 20;
            this.m2.Text = "-2";
            this.m2.UseVisualStyleBackColor = false;
            this.m2.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btCancel
            // 
            this.btCancel.AutoSize = true;
            this.btCancel.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel1.SetColumnSpan(this.btCancel, 5);
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCancel.FlatAppearance.BorderSize = 0;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Sitka Small", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btCancel.ForeColor = System.Drawing.Color.White;
            this.btCancel.Location = new System.Drawing.Point(4, 324);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(492, 71);
            this.btCancel.TabIndex = 18;
            this.btCancel.Text = "Cancel Shutdown";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // m1
            // 
            this.m1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            this.m1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m1.FlatAppearance.BorderSize = 0;
            this.m1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.m1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(89)))), ((int)(((byte)(253)))));
            this.m1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m1.ForeColor = System.Drawing.Color.Black;
            this.m1.Location = new System.Drawing.Point(4, 5);
            this.m1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m1.Name = "m1";
            this.m1.num = -1;
            this.m1.Size = new System.Drawing.Size(92, 66);
            this.m1.TabIndex = 19;
            this.m1.Text = "-1";
            this.m1.UseVisualStyleBackColor = false;
            this.m1.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.Location = new System.Drawing.Point(600, 200);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Timer";
            this.Size = new System.Drawing.Size(500, 400);
            this.Load += new System.EventHandler(this.Timer_Load);
            this.Resize += new System.EventHandler(this.Timer_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ShutdownBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btCancel;
        private MyButton m1;
        private MyButton p30;
        private MyButton p10;
        private MyButton p5;
        private MyButton p2;
        private MyButton p1;
        private MyButton rst;
        private MyButton m30;
        private MyButton m10;
        private MyButton m5;
        private MyButton m2;
    }
}

