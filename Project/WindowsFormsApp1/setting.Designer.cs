namespace WindowsFormsApp1
{
    partial class setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setting));
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.pb_apply = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbx_runHour = new System.Windows.Forms.TextBox();
            this.tbx_stopHour = new System.Windows.Forms.TextBox();
            this.tbx_stopMin = new System.Windows.Forms.TextBox();
            this.tbx_runMin = new System.Windows.Forms.TextBox();
            this.tbx_stopSec = new System.Windows.Forms.TextBox();
            this.tbx_runSec = new System.Windows.Forms.TextBox();
            this.tbx_hum_Low = new System.Windows.Forms.TextBox();
            this.tbx_temp_Low = new System.Windows.Forms.TextBox();
            this.tbx_hum_High = new System.Windows.Forms.TextBox();
            this.tbx_temp_High = new System.Windows.Forms.TextBox();
            this.tbx_pump_period = new System.Windows.Forms.TextBox();
            this.lbx_numbers = new System.Windows.Forms.ListBox();
            this.tbx_save_period = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_apply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_close
            // 
            this.pb_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(99)))), ((int)(((byte)(59)))));
            this.pb_close.Image = ((System.Drawing.Image)(resources.GetObject("pb_close.Image")));
            this.pb_close.Location = new System.Drawing.Point(697, 24);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(83, 57);
            this.pb_close.TabIndex = 3;
            this.pb_close.TabStop = false;
            this.pb_close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_close_MouseDown);
            this.pb_close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_close_MouseUp);
            // 
            // pb_apply
            // 
            this.pb_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(99)))), ((int)(((byte)(59)))));
            this.pb_apply.Image = ((System.Drawing.Image)(resources.GetObject("pb_apply.Image")));
            this.pb_apply.Location = new System.Drawing.Point(612, 24);
            this.pb_apply.Name = "pb_apply";
            this.pb_apply.Size = new System.Drawing.Size(83, 57);
            this.pb_apply.TabIndex = 2;
            this.pb_apply.TabStop = false;
            this.pb_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_apply_MouseDown);
            this.pb_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_apply_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(796, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tbx_runHour
            // 
            this.tbx_runHour.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold);
            this.tbx_runHour.Location = new System.Drawing.Point(135, 149);
            this.tbx_runHour.Multiline = true;
            this.tbx_runHour.Name = "tbx_runHour";
            this.tbx_runHour.Size = new System.Drawing.Size(83, 35);
            this.tbx_runHour.TabIndex = 4;
            this.tbx_runHour.Text = "00";
            this.tbx_runHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_runHour.Click += new System.EventHandler(this.tbx_runHour_Click_1);
            // 
            // tbx_stopHour
            // 
            this.tbx_stopHour.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold);
            this.tbx_stopHour.Location = new System.Drawing.Point(135, 200);
            this.tbx_stopHour.Multiline = true;
            this.tbx_stopHour.Name = "tbx_stopHour";
            this.tbx_stopHour.Size = new System.Drawing.Size(83, 35);
            this.tbx_stopHour.TabIndex = 5;
            this.tbx_stopHour.Text = "00";
            this.tbx_stopHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_stopHour.Click += new System.EventHandler(this.tbx_stopHour_Click);
            // 
            // tbx_stopMin
            // 
            this.tbx_stopMin.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold);
            this.tbx_stopMin.Location = new System.Drawing.Point(267, 200);
            this.tbx_stopMin.Multiline = true;
            this.tbx_stopMin.Name = "tbx_stopMin";
            this.tbx_stopMin.Size = new System.Drawing.Size(83, 35);
            this.tbx_stopMin.TabIndex = 7;
            this.tbx_stopMin.Text = "00";
            this.tbx_stopMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_stopMin.Click += new System.EventHandler(this.tbx_stopMin_Click);
            // 
            // tbx_runMin
            // 
            this.tbx_runMin.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold);
            this.tbx_runMin.Location = new System.Drawing.Point(267, 149);
            this.tbx_runMin.Multiline = true;
            this.tbx_runMin.Name = "tbx_runMin";
            this.tbx_runMin.Size = new System.Drawing.Size(83, 35);
            this.tbx_runMin.TabIndex = 6;
            this.tbx_runMin.Text = "00";
            this.tbx_runMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_runMin.Click += new System.EventHandler(this.tbx_runMin_Click);
            // 
            // tbx_stopSec
            // 
            this.tbx_stopSec.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold);
            this.tbx_stopSec.Location = new System.Drawing.Point(400, 200);
            this.tbx_stopSec.Multiline = true;
            this.tbx_stopSec.Name = "tbx_stopSec";
            this.tbx_stopSec.Size = new System.Drawing.Size(83, 35);
            this.tbx_stopSec.TabIndex = 9;
            this.tbx_stopSec.Text = "00";
            this.tbx_stopSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_stopSec.Click += new System.EventHandler(this.tbx_stopSec_Click);
            // 
            // tbx_runSec
            // 
            this.tbx_runSec.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold);
            this.tbx_runSec.Location = new System.Drawing.Point(400, 149);
            this.tbx_runSec.Multiline = true;
            this.tbx_runSec.Name = "tbx_runSec";
            this.tbx_runSec.Size = new System.Drawing.Size(83, 35);
            this.tbx_runSec.TabIndex = 8;
            this.tbx_runSec.Text = "00";
            this.tbx_runSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_runSec.Click += new System.EventHandler(this.tbx_runSec_Click);
            // 
            // tbx_hum_Low
            // 
            this.tbx_hum_Low.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold);
            this.tbx_hum_Low.Location = new System.Drawing.Point(117, 373);
            this.tbx_hum_Low.Multiline = true;
            this.tbx_hum_Low.Name = "tbx_hum_Low";
            this.tbx_hum_Low.Size = new System.Drawing.Size(53, 38);
            this.tbx_hum_Low.TabIndex = 11;
            this.tbx_hum_Low.Text = "00";
            this.tbx_hum_Low.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_hum_Low.Click += new System.EventHandler(this.tbx_hum_Low_Click);
            // 
            // tbx_temp_Low
            // 
            this.tbx_temp_Low.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold);
            this.tbx_temp_Low.Location = new System.Drawing.Point(117, 323);
            this.tbx_temp_Low.Multiline = true;
            this.tbx_temp_Low.Name = "tbx_temp_Low";
            this.tbx_temp_Low.Size = new System.Drawing.Size(53, 38);
            this.tbx_temp_Low.TabIndex = 10;
            this.tbx_temp_Low.Text = "00";
            this.tbx_temp_Low.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_temp_Low.Click += new System.EventHandler(this.tbx_temp_Low_Click);
            // 
            // tbx_hum_High
            // 
            this.tbx_hum_High.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold);
            this.tbx_hum_High.Location = new System.Drawing.Point(221, 373);
            this.tbx_hum_High.Multiline = true;
            this.tbx_hum_High.Name = "tbx_hum_High";
            this.tbx_hum_High.Size = new System.Drawing.Size(53, 38);
            this.tbx_hum_High.TabIndex = 13;
            this.tbx_hum_High.Text = "00";
            this.tbx_hum_High.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_hum_High.Click += new System.EventHandler(this.tbx_hum_High_Click);
            // 
            // tbx_temp_High
            // 
            this.tbx_temp_High.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold);
            this.tbx_temp_High.Location = new System.Drawing.Point(221, 323);
            this.tbx_temp_High.Multiline = true;
            this.tbx_temp_High.Name = "tbx_temp_High";
            this.tbx_temp_High.Size = new System.Drawing.Size(53, 38);
            this.tbx_temp_High.TabIndex = 12;
            this.tbx_temp_High.Text = "00";
            this.tbx_temp_High.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_temp_High.Click += new System.EventHandler(this.tbx_temp_High_Click);
            // 
            // tbx_pump_period
            // 
            this.tbx_pump_period.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold);
            this.tbx_pump_period.Location = new System.Drawing.Point(556, 323);
            this.tbx_pump_period.Multiline = true;
            this.tbx_pump_period.Name = "tbx_pump_period";
            this.tbx_pump_period.Size = new System.Drawing.Size(53, 41);
            this.tbx_pump_period.TabIndex = 14;
            this.tbx_pump_period.Text = "00";
            this.tbx_pump_period.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_pump_period.Click += new System.EventHandler(this.tbx_pump_period_Click);
            // 
            // lbx_numbers
            // 
            this.lbx_numbers.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbx_numbers.Font = new System.Drawing.Font("굴림", 40F);
            this.lbx_numbers.FormattingEnabled = true;
            this.lbx_numbers.ItemHeight = 53;
            this.lbx_numbers.Location = new System.Drawing.Point(685, 454);
            this.lbx_numbers.MultiColumn = true;
            this.lbx_numbers.Name = "lbx_numbers";
            this.lbx_numbers.Size = new System.Drawing.Size(111, 57);
            this.lbx_numbers.TabIndex = 15;
            this.lbx_numbers.Visible = false;
            this.lbx_numbers.Click += new System.EventHandler(this.lbx_numbers_Click);
            this.lbx_numbers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbx_numbers_MouseDown);
            // 
            // tbx_save_period
            // 
            this.tbx_save_period.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold);
            this.tbx_save_period.Location = new System.Drawing.Point(556, 370);
            this.tbx_save_period.Multiline = true;
            this.tbx_save_period.Name = "tbx_save_period";
            this.tbx_save_period.Size = new System.Drawing.Size(53, 41);
            this.tbx_save_period.TabIndex = 16;
            this.tbx_save_period.Text = "00";
            this.tbx_save_period.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 458);
            this.Controls.Add(this.tbx_save_period);
            this.Controls.Add(this.lbx_numbers);
            this.Controls.Add(this.tbx_pump_period);
            this.Controls.Add(this.tbx_hum_High);
            this.Controls.Add(this.tbx_temp_High);
            this.Controls.Add(this.tbx_hum_Low);
            this.Controls.Add(this.tbx_temp_Low);
            this.Controls.Add(this.tbx_stopSec);
            this.Controls.Add(this.tbx_runSec);
            this.Controls.Add(this.tbx_stopMin);
            this.Controls.Add(this.tbx_runMin);
            this.Controls.Add(this.tbx_stopHour);
            this.Controls.Add(this.tbx_runHour);
            this.Controls.Add(this.pb_close);
            this.Controls.Add(this.pb_apply);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.setting_Load);
            this.Shown += new System.EventHandler(this.setting_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_apply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_apply;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.TextBox tbx_runHour;
        private System.Windows.Forms.TextBox tbx_stopHour;
        private System.Windows.Forms.TextBox tbx_stopMin;
        private System.Windows.Forms.TextBox tbx_runMin;
        private System.Windows.Forms.TextBox tbx_stopSec;
        private System.Windows.Forms.TextBox tbx_runSec;
        private System.Windows.Forms.TextBox tbx_hum_Low;
        private System.Windows.Forms.TextBox tbx_temp_Low;
        private System.Windows.Forms.TextBox tbx_hum_High;
        private System.Windows.Forms.TextBox tbx_temp_High;
        private System.Windows.Forms.TextBox tbx_pump_period;
        private System.Windows.Forms.ListBox lbx_numbers;
        private System.Windows.Forms.TextBox tbx_save_period;
    }
}