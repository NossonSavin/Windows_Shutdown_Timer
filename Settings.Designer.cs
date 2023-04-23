namespace time
{
    partial class Settings : IMyArry
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ModeTimer = new System.Windows.Forms.RadioButton();
            this.ModeSetTime = new System.Windows.Forms.RadioButton();
            this.ModeLast = new System.Windows.Forms.RadioButton();
            this.DarkTheme = new System.Windows.Forms.CheckBox();
            this.ExitOnCancelBtn = new System.Windows.Forms.CheckBox();
            this.ExitOnShutdownBtn = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ModeTimer, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.ModeSetTime, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.ModeLast, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.DarkTheme, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ExitOnCancelBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ExitOnShutdownBtn, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(441, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ModeTimer
            // 
            this.ModeTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModeTimer.Appearance = System.Windows.Forms.Appearance.Button;
            this.ModeTimer.AutoSize = true;
            this.ModeTimer.FlatAppearance.BorderSize = 0;
            this.ModeTimer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.ModeTimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.ModeTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModeTimer.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeTimer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ModeTimer.Location = new System.Drawing.Point(110, 364);
            this.ModeTimer.Name = "ModeTimer";
            this.ModeTimer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ModeTimer.Size = new System.Drawing.Size(221, 36);
            this.ModeTimer.TabIndex = 2;
            this.ModeTimer.TabStop = true;
            this.ModeTimer.Text = "On Start Open Timer";
            this.ModeTimer.UseVisualStyleBackColor = false;
            this.ModeTimer.Click += new System.EventHandler(this.StartModeType_Click);
            // 
            // ModeSetTime
            // 
            this.ModeSetTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModeSetTime.Appearance = System.Windows.Forms.Appearance.Button;
            this.ModeSetTime.AutoSize = true;
            this.ModeSetTime.FlatAppearance.BorderSize = 0;
            this.ModeSetTime.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.ModeSetTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.ModeSetTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModeSetTime.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeSetTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ModeSetTime.Location = new System.Drawing.Point(100, 319);
            this.ModeSetTime.Name = "ModeSetTime";
            this.ModeSetTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ModeSetTime.Size = new System.Drawing.Size(241, 36);
            this.ModeSetTime.TabIndex = 1;
            this.ModeSetTime.TabStop = true;
            this.ModeSetTime.Text = "On Start Open SetTime";
            this.ModeSetTime.UseVisualStyleBackColor = false;
            this.ModeSetTime.Click += new System.EventHandler(this.StartModeType_Click);
            // 
            // ModeLast
            // 
            this.ModeLast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModeLast.Appearance = System.Windows.Forms.Appearance.Button;
            this.ModeLast.AutoSize = true;
            this.ModeLast.FlatAppearance.BorderSize = 0;
            this.ModeLast.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.ModeLast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.ModeLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModeLast.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeLast.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ModeLast.Location = new System.Drawing.Point(89, 274);
            this.ModeLast.Name = "ModeLast";
            this.ModeLast.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ModeLast.Size = new System.Drawing.Size(262, 36);
            this.ModeLast.TabIndex = 0;
            this.ModeLast.TabStop = true;
            this.ModeLast.Text = "On Start Open Last Used";
            this.ModeLast.UseVisualStyleBackColor = false;
            this.ModeLast.Click += new System.EventHandler(this.StartModeType_Click);
            // 
            // DarkTheme
            // 
            this.DarkTheme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DarkTheme.Appearance = System.Windows.Forms.Appearance.Button;
            this.DarkTheme.AutoSize = true;
            this.DarkTheme.FlatAppearance.BorderSize = 0;
            this.DarkTheme.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.DarkTheme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.DarkTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DarkTheme.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DarkTheme.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DarkTheme.Location = new System.Drawing.Point(151, 184);
            this.DarkTheme.Name = "DarkTheme";
            this.DarkTheme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DarkTheme.Size = new System.Drawing.Size(138, 36);
            this.DarkTheme.TabIndex = 2;
            this.DarkTheme.Text = "Dark Theme";
            this.DarkTheme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DarkTheme.UseVisualStyleBackColor = false;
            this.DarkTheme.Visible = false;
            this.DarkTheme.Click += new System.EventHandler(this.DarkTheme_Click);
            // 
            // ExitOnCancelBtn
            // 
            this.ExitOnCancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitOnCancelBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.ExitOnCancelBtn.AutoSize = true;
            this.ExitOnCancelBtn.FlatAppearance.BorderSize = 0;
            this.ExitOnCancelBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.ExitOnCancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.ExitOnCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitOnCancelBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitOnCancelBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ExitOnCancelBtn.Location = new System.Drawing.Point(46, 94);
            this.ExitOnCancelBtn.Name = "ExitOnCancelBtn";
            this.ExitOnCancelBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ExitOnCancelBtn.Size = new System.Drawing.Size(349, 36);
            this.ExitOnCancelBtn.TabIndex = 1;
            this.ExitOnCancelBtn.Text = "Exit With Cancel Shutdown Button";
            this.ExitOnCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitOnCancelBtn.UseVisualStyleBackColor = false;
            this.ExitOnCancelBtn.Click += new System.EventHandler(this.ExitOnCancelBtn_Click);
            // 
            // ExitOnShutdownBtn
            // 
            this.ExitOnShutdownBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitOnShutdownBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.ExitOnShutdownBtn.AutoSize = true;
            this.ExitOnShutdownBtn.FlatAppearance.BorderSize = 0;
            this.ExitOnShutdownBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.ExitOnShutdownBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.ExitOnShutdownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitOnShutdownBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitOnShutdownBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ExitOnShutdownBtn.Location = new System.Drawing.Point(82, 49);
            this.ExitOnShutdownBtn.Name = "ExitOnShutdownBtn";
            this.ExitOnShutdownBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ExitOnShutdownBtn.Size = new System.Drawing.Size(277, 36);
            this.ExitOnShutdownBtn.TabIndex = 0;
            this.ExitOnShutdownBtn.Text = "Exit With Shutdown Button";
            this.ExitOnShutdownBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitOnShutdownBtn.Click += new System.EventHandler(this.ExitOnShutdownBtn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(441, 450);
            this.Resize += new System.EventHandler(this.Settings_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox ExitOnShutdownBtn;
        private System.Windows.Forms.CheckBox DarkTheme;
        private System.Windows.Forms.CheckBox ExitOnCancelBtn;
        private System.Windows.Forms.RadioButton ModeLast;
        private System.Windows.Forms.RadioButton ModeSetTime;
        private System.Windows.Forms.RadioButton ModeTimer;
    }
}