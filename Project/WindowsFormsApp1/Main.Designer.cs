namespace WindowsFormsApp1
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_mode = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_runningMode = new System.Windows.Forms.Label();
            this.lbl_time_temp = new System.Windows.Forms.Label();
            this.lbl_time_hum = new System.Windows.Forms.Label();
            this.lbl_temp = new System.Windows.Forms.Label();
            this.lbl_humin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbar_temp = new System.Windows.Forms.TrackBar();
            this.tbar_humin = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.off_pump = new System.Windows.Forms.PictureBox();
            this.off_fan = new System.Windows.Forms.PictureBox();
            this.off_light = new System.Windows.Forms.PictureBox();
            this.off_humi = new System.Windows.Forms.PictureBox();
            this.off_temp = new System.Windows.Forms.PictureBox();
            this.on_pump = new System.Windows.Forms.PictureBox();
            this.on_fan = new System.Windows.Forms.PictureBox();
            this.on_light = new System.Windows.Forms.PictureBox();
            this.on_humi = new System.Windows.Forms.PictureBox();
            this.on_temp = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timer_autosave = new System.Windows.Forms.Timer(this.components);
            this.timer_date = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbar_temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_humin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.off_pump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.off_fan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.off_light)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.off_humi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.off_temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_pump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_fan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_light)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_humi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_temp)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_mode
            // 
            this.btn_mode.Location = new System.Drawing.Point(664, 449);
            this.btn_mode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_mode.Name = "btn_mode";
            this.btn_mode.Size = new System.Drawing.Size(104, 94);
            this.btn_mode.TabIndex = 1;
            this.btn_mode.Text = "수동/자동";
            this.btn_mode.UseVisualStyleBackColor = true;
            this.btn_mode.Click += new System.EventHandler(this.btn_mode_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.Location = new System.Drawing.Point(783, 449);
            this.btn_setting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(104, 94);
            this.btn_setting.TabIndex = 2;
            this.btn_setting.Text = "설정";
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 471);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "운전";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 471);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 58);
            this.button2.TabIndex = 4;
            this.button2.Text = "운전";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(365, 471);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 58);
            this.button3.TabIndex = 5;
            this.button3.Text = "운전";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Black;
            this.lbl_date.Font = new System.Drawing.Font("굴림", 18F);
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(721, 41);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(0, 30);
            this.lbl_date.TabIndex = 6;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Black;
            this.lbl_time.Font = new System.Drawing.Font("굴림", 18F);
            this.lbl_time.ForeColor = System.Drawing.Color.White;
            this.lbl_time.Location = new System.Drawing.Point(751, 71);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(0, 30);
            this.lbl_time.TabIndex = 7;
            // 
            // lbl_runningMode
            // 
            this.lbl_runningMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_runningMode.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_runningMode.ForeColor = System.Drawing.Color.White;
            this.lbl_runningMode.Location = new System.Drawing.Point(154, 120);
            this.lbl_runningMode.Name = "lbl_runningMode";
            this.lbl_runningMode.Size = new System.Drawing.Size(107, 54);
            this.lbl_runningMode.TabIndex = 8;
            this.lbl_runningMode.Text = "수동";
            this.lbl_runningMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_time_temp
            // 
            this.lbl_time_temp.BackColor = System.Drawing.Color.White;
            this.lbl_time_temp.Font = new System.Drawing.Font("굴림", 20F);
            this.lbl_time_temp.ForeColor = System.Drawing.Color.Black;
            this.lbl_time_temp.Location = new System.Drawing.Point(664, 242);
            this.lbl_time_temp.Name = "lbl_time_temp";
            this.lbl_time_temp.Size = new System.Drawing.Size(144, 66);
            this.lbl_time_temp.TabIndex = 9;
            this.lbl_time_temp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_time_hum
            // 
            this.lbl_time_hum.BackColor = System.Drawing.Color.White;
            this.lbl_time_hum.Font = new System.Drawing.Font("굴림", 20F);
            this.lbl_time_hum.ForeColor = System.Drawing.Color.Black;
            this.lbl_time_hum.Location = new System.Drawing.Point(664, 360);
            this.lbl_time_hum.Name = "lbl_time_hum";
            this.lbl_time_hum.Size = new System.Drawing.Size(144, 66);
            this.lbl_time_hum.TabIndex = 10;
            this.lbl_time_hum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_temp
            // 
            this.lbl_temp.BackColor = System.Drawing.Color.White;
            this.lbl_temp.Font = new System.Drawing.Font("굴림", 20F);
            this.lbl_temp.ForeColor = System.Drawing.Color.Black;
            this.lbl_temp.Location = new System.Drawing.Point(821, 242);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(74, 66);
            this.lbl_temp.TabIndex = 11;
            this.lbl_temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_humin
            // 
            this.lbl_humin.BackColor = System.Drawing.Color.White;
            this.lbl_humin.Font = new System.Drawing.Font("굴림", 20F);
            this.lbl_humin.ForeColor = System.Drawing.Color.Black;
            this.lbl_humin.Location = new System.Drawing.Point(821, 360);
            this.lbl_humin.Name = "lbl_humin";
            this.lbl_humin.Size = new System.Drawing.Size(74, 66);
            this.lbl_humin.TabIndex = 12;
            this.lbl_humin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(795, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 41);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbar_temp
            // 
            this.tbar_temp.Location = new System.Drawing.Point(330, 120);
            this.tbar_temp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbar_temp.Name = "tbar_temp";
            this.tbar_temp.Size = new System.Drawing.Size(227, 56);
            this.tbar_temp.TabIndex = 19;
            this.tbar_temp.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbar_humin
            // 
            this.tbar_humin.Location = new System.Drawing.Point(611, 120);
            this.tbar_humin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbar_humin.Name = "tbar_humin";
            this.tbar_humin.Size = new System.Drawing.Size(227, 56);
            this.tbar_humin.TabIndex = 18;
            this.tbar_humin.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "온도";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "습도";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(910, 572);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // off_pump
            // 
            this.off_pump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.off_pump.Image = ((System.Drawing.Image)(resources.GetObject("off_pump.Image")));
            this.off_pump.Location = new System.Drawing.Point(360, 349);
            this.off_pump.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.off_pump.Name = "off_pump";
            this.off_pump.Size = new System.Drawing.Size(73, 78);
            this.off_pump.TabIndex = 51;
            this.off_pump.TabStop = false;
            // 
            // off_fan
            // 
            this.off_fan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.off_fan.Image = ((System.Drawing.Image)(resources.GetObject("off_fan.Image")));
            this.off_fan.Location = new System.Drawing.Point(560, 349);
            this.off_fan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.off_fan.Name = "off_fan";
            this.off_fan.Size = new System.Drawing.Size(73, 78);
            this.off_fan.TabIndex = 50;
            this.off_fan.TabStop = false;
            // 
            // off_light
            // 
            this.off_light.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.off_light.Image = ((System.Drawing.Image)(resources.GetObject("off_light.Image")));
            this.off_light.Location = new System.Drawing.Point(474, 349);
            this.off_light.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.off_light.Name = "off_light";
            this.off_light.Size = new System.Drawing.Size(73, 78);
            this.off_light.TabIndex = 49;
            this.off_light.TabStop = false;
            // 
            // off_humi
            // 
            this.off_humi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.off_humi.Image = ((System.Drawing.Image)(resources.GetObject("off_humi.Image")));
            this.off_humi.Location = new System.Drawing.Point(274, 349);
            this.off_humi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.off_humi.Name = "off_humi";
            this.off_humi.Size = new System.Drawing.Size(73, 78);
            this.off_humi.TabIndex = 48;
            this.off_humi.TabStop = false;
            // 
            // off_temp
            // 
            this.off_temp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.off_temp.Image = ((System.Drawing.Image)(resources.GetObject("off_temp.Image")));
            this.off_temp.Location = new System.Drawing.Point(189, 349);
            this.off_temp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.off_temp.Name = "off_temp";
            this.off_temp.Size = new System.Drawing.Size(73, 78);
            this.off_temp.TabIndex = 47;
            this.off_temp.TabStop = false;
            // 
            // on_pump
            // 
            this.on_pump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.on_pump.Image = ((System.Drawing.Image)(resources.GetObject("on_pump.Image")));
            this.on_pump.Location = new System.Drawing.Point(359, 242);
            this.on_pump.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.on_pump.Name = "on_pump";
            this.on_pump.Size = new System.Drawing.Size(73, 78);
            this.on_pump.TabIndex = 46;
            this.on_pump.TabStop = false;
            this.on_pump.Visible = false;
            // 
            // on_fan
            // 
            this.on_fan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.on_fan.Image = ((System.Drawing.Image)(resources.GetObject("on_fan.Image")));
            this.on_fan.Location = new System.Drawing.Point(559, 242);
            this.on_fan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.on_fan.Name = "on_fan";
            this.on_fan.Size = new System.Drawing.Size(73, 78);
            this.on_fan.TabIndex = 45;
            this.on_fan.TabStop = false;
            this.on_fan.Visible = false;
            // 
            // on_light
            // 
            this.on_light.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.on_light.Image = ((System.Drawing.Image)(resources.GetObject("on_light.Image")));
            this.on_light.Location = new System.Drawing.Point(473, 242);
            this.on_light.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.on_light.Name = "on_light";
            this.on_light.Size = new System.Drawing.Size(73, 78);
            this.on_light.TabIndex = 44;
            this.on_light.TabStop = false;
            this.on_light.Visible = false;
            // 
            // on_humi
            // 
            this.on_humi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.on_humi.Image = ((System.Drawing.Image)(resources.GetObject("on_humi.Image")));
            this.on_humi.Location = new System.Drawing.Point(273, 242);
            this.on_humi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.on_humi.Name = "on_humi";
            this.on_humi.Size = new System.Drawing.Size(73, 78);
            this.on_humi.TabIndex = 43;
            this.on_humi.TabStop = false;
            this.on_humi.Visible = false;
            // 
            // on_temp
            // 
            this.on_temp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.on_temp.Image = ((System.Drawing.Image)(resources.GetObject("on_temp.Image")));
            this.on_temp.Location = new System.Drawing.Point(187, 242);
            this.on_temp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.on_temp.Name = "on_temp";
            this.on_temp.Size = new System.Drawing.Size(73, 78);
            this.on_temp.TabIndex = 42;
            this.on_temp.TabStop = false;
            this.on_temp.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(561, 471);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 58);
            this.button4.TabIndex = 53;
            this.button4.Text = "운전";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(477, 471);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 58);
            this.button5.TabIndex = 52;
            this.button5.Text = "운전";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer_autosave
            // 
            this.timer_autosave.Interval = 1000;
            this.timer_autosave.Tick += new System.EventHandler(this.timer_autosave_Tick);
            // 
            // timer_date
            // 
            this.timer_date.Interval = 1000;
            this.timer_date.Tick += new System.EventHandler(this.timer_date_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 572);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.off_pump);
            this.Controls.Add(this.off_fan);
            this.Controls.Add(this.off_light);
            this.Controls.Add(this.off_humi);
            this.Controls.Add(this.off_temp);
            this.Controls.Add(this.on_pump);
            this.Controls.Add(this.on_fan);
            this.Controls.Add(this.on_light);
            this.Controls.Add(this.on_humi);
            this.Controls.Add(this.on_temp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbar_temp);
            this.Controls.Add(this.tbar_humin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_humin);
            this.Controls.Add(this.lbl_temp);
            this.Controls.Add(this.lbl_time_hum);
            this.Controls.Add(this.lbl_time_temp);
            this.Controls.Add(this.lbl_runningMode);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.btn_mode);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbar_temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_humin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.off_pump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.off_fan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.off_light)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.off_humi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.off_temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_pump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_fan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_light)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_humi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_temp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Button btn_mode;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_runningMode;
        private System.Windows.Forms.Label lbl_time_temp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_time_hum;
        private System.Windows.Forms.Label lbl_temp;
        private System.Windows.Forms.Label lbl_humin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbar_temp;
        private System.Windows.Forms.TrackBar tbar_humin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox off_pump;
        private System.Windows.Forms.PictureBox off_fan;
        private System.Windows.Forms.PictureBox off_light;
        private System.Windows.Forms.PictureBox off_humi;
        private System.Windows.Forms.PictureBox off_temp;
        private System.Windows.Forms.PictureBox on_pump;
        private System.Windows.Forms.PictureBox on_fan;
        private System.Windows.Forms.PictureBox on_light;
        private System.Windows.Forms.PictureBox on_humi;
        private System.Windows.Forms.PictureBox on_temp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer_autosave;
        private System.Windows.Forms.Timer timer_date;
        private System.Windows.Forms.Timer timer2;
    }
}

