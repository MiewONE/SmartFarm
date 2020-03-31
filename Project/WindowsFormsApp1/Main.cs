using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Timers;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        Stopwatch sp = new Stopwatch();
        Stopwatch sp2 = new Stopwatch();
        public Main()
        {
            InitializeComponent();


            tbar_temp.Minimum = 0;
            tbar_temp.Maximum = 100;
            tbar_humin.Minimum = 0;
            tbar_humin.Maximum = 100;


            var tm_sensor_st = new System.Timers.Timer();
            tm_sensor_st.Elapsed += new ElapsedEventHandler(tm_sensor_st_Elapsed);
            tm_sensor_st.Interval = 1000;

            var tm_running = new System.Timers.Timer();
            tm_running.Elapsed += new ElapsedEventHandler(tm_running_Elapsed);

            tm_running.Start();
            timer_date.Start();
            timer_autosave.Start();
            tm_sensor_st.Start();

            

        }
        void Invoke_sort(Control _para_ctl, string _para_str)
        {
            if(_para_ctl.Controls.Owner.ToString().Contains("Label"))
            {
                if(_para_ctl.InvokeRequired)
                {
                    _para_ctl.Invoke(new MethodInvoker(delegate ()
                   {
                       _para_ctl.Text = _para_str;
                   }));
                }
            }
        }
        void tm_running_Elapsed(object sender, ElapsedEventArgs e)//온도 및 습도 가동시간을 보여주는 항목
        {
            if(variable.temp)
            {
                sp.Start();
                if(lbl_time_temp.InvokeRequired)
                {
                    lbl_time_temp.Invoke(new MethodInvoker(delegate ()
                    {
                        lbl_time_temp.Text = sp.Elapsed.ToString();
                    }));
                }
                else
                {
                    lbl_time_temp.Text = sp.Elapsed.ToString();
                }
            }
            else
            {
                sp.Stop();
                sp.Reset();
                if (lbl_time_temp.InvokeRequired)
                {
                    lbl_time_temp.Invoke(new MethodInvoker(delegate ()
                    {
                        lbl_time_temp.Text = sp.Elapsed.ToString();
                    }));
                }
                else
                {
                    lbl_time_temp.Text = sp.Elapsed.ToString();
                }
            }
            if (variable.humin)
            {
                sp2.Start();
                if (lbl_time_hum.InvokeRequired)
                {
                    lbl_time_hum.Invoke(new MethodInvoker(delegate ()
                    {
                        lbl_time_hum.Text = sp2.Elapsed.ToString();
                    }));
                }
                else
                {
                    lbl_time_hum.Text = sp.Elapsed.ToString();
                }
            }
            else
            {
                sp2.Stop();
                sp2.Reset();
                if (lbl_time_hum.InvokeRequired)
                {
                    lbl_time_hum.Invoke(new MethodInvoker(delegate ()
                    {
                        lbl_time_hum.Text = sp2.Elapsed.ToString();
                    }));
                }
                else
                {
                    lbl_time_hum.Text = sp.Elapsed.ToString();
                }
            }
        }
        void tm_sensor_st_Elapsed(object sender, ElapsedEventArgs e)
        {
            string tmp_value = null, hum_value = null;
            if (tbar_temp.InvokeRequired || tbar_humin.InvokeRequired)
            {
                tbar_temp.Invoke(new MethodInvoker(delegate ()
               {
                   tmp_value = tbar_temp.Value.ToString();
               }));
                tbar_humin.Invoke(new MethodInvoker(delegate ()
                {
                    hum_value = tbar_humin.Value.ToString();
                }));
            }
            else
            {
                tmp_value = tbar_temp.Value.ToString();
                hum_value = tbar_humin.Value.ToString();
            }
            //action();
            Invoke_sort(lbl_temp, tmp_value);
            Invoke_sort(lbl_humin, hum_value);

        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            DB db = new DB("localhost", "root", "1234", "3306");
            db.DBcon();
            db.DBorTable_Create();
            DB.query_execute("select * from setting;", "select");
            //%timer_sensor.Interval = (int)variable.save_period * 6000;
            //timer_sensor.Interval = 1000;
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            setting st = new setting();
            st.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            base.Dispose();
            base.Close();
        }
        private void action()
        {
            //object[] on = new object[5];
            //object[] off = new object[5];
            var on = new PictureBox[5];
            var off = new PictureBox[5];
            on[0] = on_temp;
            on[1] = on_humi;
            on[2] = on_pump;
            on[3] = on_light;
            on[4] = on_fan;
            off[0] = off_temp;
            off[1] = off_humi;
            off[2] = off_pump;
            off[3] = off_light;
            off[4] = off_fan;
            #region 장치동작 감지
            if (variable.temp)
            {
                //Method_invoke(on[0], true);
                //Method_invoke(off[0], false);
                on[0].Visible = true;
                off[0].Visible = false;
            }
            else
            {
                //Method_invoke(on[0], false);
                //sp.Stop();
                //Method_invoke(off[0], true);
                on[0].Visible = false;

                off[0].Visible = true;
            }
            if (variable.humin)
            {
                //Method_invoke(on[1], true);
                //Method_invoke(off[1], false);
                on[1].Visible = true;
                off[1].Visible = false;
            }
            else
            {
                //Method_invoke(on[1], false);
                //Method_invoke(off[1], true);
                on[1].Visible = false;
                //sp2.Stop();
                off[1].Visible = true;

            }
            if (variable.pump)
            {
                //Method_invoke(on[2], true);
                //Method_invoke(off[2], false);
                on[2].Visible = true;
                off[2].Visible = false;
            }
            else
            {
                on[2].Visible = false;
                off[2].Visible = true;
                //Method_invoke(on[2], false);
                //Method_invoke(off[2], true);
            }
            if (variable.light)
            {
                //Method_invoke(on[3], true);
                //Method_invoke(off[3], false);
                on[3].Visible = true;
                off[3].Visible = false;
            }
            else
            {
                on[3].Visible = false;
                off[3].Visible = true;
                //Method_invoke(on[3], false);
                //Method_invoke(off[3], true);
            }
            if (variable.fan)
            {
                //Method_invoke(on[4], true);
                //Method_invoke(off[4], false);
                on[4].Visible = true;
                off[4].Visible = false;
            }
            else
            {
                //Method_invoke(on[4], false);
                //Method_invoke(off[4], true);
                //on[4].Visible = false;
                //off[4].Visible = true;
            }
            #endregion
        }

        private void timer_sensor_Tick(object sender, EventArgs e)
        {
            //대기
            //action();
            //lbl_temp.Text = tbar_temp.Value.ToString();
            //lbl_humin.Text = tbar_humin.Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToString("yyyy.MM.dd");
            lbl_time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer_datasave_Tick(object sender, EventArgs e)
        {
            //대기
            DB.query_execute($"insert into save_state values( " +
                $"{tbar_temp.Value.ToString()}," +/*디비에 온도저장*/
                $"{tbar_humin.Value.ToString()}," +/*디비에 습도저장*/
                $"{variable.pump}," +//펌프 0 오프 1 온
                $"{variable.fan}," +//팬
                $"\'{DateTime.Now.ToString("HH:mm:ss")}\'," +
                $"\'{DateTime.Now.ToString("yyyy-MM-dd")}\'" +
                $");");
        }

        #region 버튼 On/Off
        private void button1_Click(object sender, EventArgs e)
        {
            //냉,난방 운전
            if (off_temp.Visible)//동작 시작
            {
                variable.temp = true;
                off_temp.Visible = false;
                on_temp.Visible = true;
            }
            else
            {
                variable.temp = false;
                off_temp.Visible = true;
                on_temp.Visible = false;
            }
            action();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //가습 운전
            if (off_humi.Visible)//동작 시작
            {
                variable.humin = true;
                off_humi.Visible = false;
                on_humi.Visible = true;
            }
            else
            {
                variable.humin = false;
                off_humi.Visible = true;
                on_humi.Visible = false;
            }
            action();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //펌프 운전
            if (off_pump.Visible)
            {
                variable.pump = true;
                off_pump.Visible = false;
                on_pump.Visible = true;
            }
            else
            {
                variable.pump = false;
                off_pump.Visible = true;
                on_pump.Visible = false;
            }
            action();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //형광등 운전
            if (off_light.Visible)
            {
                variable.light = true;
                off_light.Visible = false;
                on_light.Visible = true;
            }
            else
            {
                variable.light = false;
                off_light.Visible = true;
                on_light.Visible = false;
            }
            action();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //팬 운전
            if (off_fan.Visible)
            {
                variable.fan = true;
                off_fan.Visible = false;
                on_fan.Visible = true;
            }
            else
            {
                variable.fan = false;
                off_fan.Visible = true;
                on_fan.Visible = false;
            }
            action();
        }

        #endregion

        //모드 변경 버튼 
        private void btn_mode_Click(object sender, EventArgs e)
        {
            if (variable.Mode == 0)
            {
                //mode 1 은 자동
                variable.Mode = 1;
                button1.Visible = false;
                button2.Visible = false;
                //button3.Visible = false;
                //button4.Visible = false;
                //button5.Visible = false;

                //운전 모드 중지
                variable.temp = false;
                variable.humin = false;
                variable.pump = false;
                variable.light = false;
                variable.fan = false;
                //timer_auto.Start();// 1초당 설정 온도와 현재 온도를 비교하여 설정온도에 맞추게 끔 작동
            }
            else
            {
                //mode 0은 수동
                //timer_auto.Stop();
                variable.Mode = 0;
                button1.Visible = true;
                button2.Visible = true;
                //button3.Visible = true;
                //button4.Visible = true;
                //button5.Visible = true;

                //운전 모드 중지
                variable.temp = false;
                variable.humin = false;
                variable.pump = false;
                variable.light = false;
                variable.fan = false;

            }
            action();
        }

        private void timer_autosave_Tick(object sender, EventArgs e)
        {
            if (variable.Mode == 1 /*&& timer_auto.Interval == 1000 */)
            {
                if (variable.auto_TempHIGH >= tbar_temp.Value && variable.auto_TempLOW <= tbar_temp.Value)
                {
                    variable.fan = false;

                }
                if (variable.avg_tmp > tbar_temp.Value)
                {
                    //온도 높이는 기능(난방기 작동)
                    //임시로 작성
                    if (variable.avg_tmp - 2 <= tbar_temp.Value)
                    {
                        variable.temp = false;
                        //sp.Stop();
                        //sp.Reset();
                    }
                    else
                    {
                        variable.temp = true;
                        //sp.Start();
                        //lbl_time_temp.Text = sp.Elapsed.ToString();
                        //tm_running_temp.Start();
                        //timer_running_temp.Start();
                        tbar_temp.Value++;
                    }
                }
                if (variable.auto_TempHIGH <= tbar_temp.Value)
                {
                    //온도 낮추는 기능(팬 작동)
                    //임시로 작성
                    variable.temp = false;
                    variable.fan = true;
                    tbar_temp.Value--;
                }
            }

            if (variable.Mode == 1 /*&& timer_auto.Interval == 1000*/)
            {
                if (variable.auto_HumHIGH > tbar_humin.Value)
                {
                    //온도 높이는 기능(난방기 작동)
                    //임시로 작성
                    if (variable.avg_hum - 2 <= tbar_humin.Value)
                    {
                        variable.humin = false;
                        sp2.Stop();
                    }
                    else
                    {
                        variable.humin = true;
                        //timer_running_Hum.Start();
                        tbar_humin.Value++;
                    }
                }
                if (variable.auto_HumHIGH <= tbar_humin.Value)
                {
                    //온도 낮추는 기능(팬 작동)
                    //임시로 작성
                    variable.humin = false;
                    variable.fan = true;
                    tbar_humin.Value--;
                }
            }
            action();
        }

        private void timer_date_Tick(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToString("yyyy.MM.dd");
            lbl_time.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}