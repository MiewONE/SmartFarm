using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class setting : Form
    {
        TextBox tbx = null;
        public setting()
        {
            InitializeComponent();
        }

        private void pb_close_MouseDown(object sender, MouseEventArgs e)
        {
            pb_close.Visible = false;
        }

        private void pb_close_MouseUp(object sender, MouseEventArgs e)
        {
            base.Dispose();
        }

        private void pb_apply_MouseDown(object sender, MouseEventArgs e)
        {
            pb_apply.Visible = false;
            DB.query_execute("delete from setting;");
            DB.query_execute($"insert into setting values ({tbx_runHour.Text},{tbx_runMin.Text},{tbx_runSec.Text}" +
                $",{tbx_stopHour.Text},{tbx_stopMin.Text},{tbx_stopSec.Text}," +
                $"{tbx_temp_Low.Text},{tbx_temp_High.Text},{tbx_hum_Low.Text},{tbx_hum_High.Text}," +
                $"{tbx_save_period.Text},{tbx_pump_period.Text});", "insert");
        }

        private void pb_apply_MouseUp(object sender, MouseEventArgs e)
        {
            string tmp = "";
            if (Convert.ToInt32(this.tbx_hum_Low.Text) > Convert.ToInt32(this.tbx_hum_High.Text) ||
                Convert.ToInt32(this.tbx_hum_Low.Text) < 1 ||
                Convert.ToInt32(this.tbx_hum_High.Text) < 1)
            {
                tmp += "습도";
                //this.tbx_hum_Low.Text = "00";
                //this.tbx_hum_High.Text = "00";
            }
            if (Convert.ToInt32(this.tbx_temp_Low.Text) > Convert.ToInt32(this.tbx_temp_High.Text) ||
                Convert.ToInt32(this.tbx_temp_Low.Text) < 1 ||
                Convert.ToInt32(this.tbx_temp_High.Text) < 1)
            {
                tmp += " 온도";
                //this.tbx_temp_Low.Text = "00";
                //this.tbx_temp_High.Text = "00";
            }

            if (!tmp.Equals(""))
            {
                MessageBox.Show(tmp + "를 다시 확인해주시기 바랍니다.", "확인");
                tmp = "";
            }
            else
            {
                //MessageBox.Show("적용기능을 구현해야합니다.");
            }
            DB.query_execute("select * from setting;", "select");
            //%Main.timer_sensor.Interval = (int)variable.save_period * 6000;
            //Main.timer_sensor.Interval = 1000;
            pb_apply.Visible = true;
            MessageBox.Show("적용이 완료되었습니다", "완료!");
        }



        private void lbx_numbers_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void tbx_runHour_Click_1(object sender, EventArgs e)
        {
            setting_tbx(tbx_runHour, 0, 24);
        }

        private void tbx_temp_Low_Click(object sender, EventArgs e)
        {
            setting_tbx(tbx_temp_Low, 5, 38);
        }
        private void setting_tbx(TextBox tb, int _para_Low, int _para_High)
        {
            tbx = tb;
            lbx_numbers.Items.Clear();
            for (int i = _para_Low; i <= _para_High; i++)
            {
                lbx_numbers.Items.Add(i);
            }
            lbx_numbers.Dock = DockStyle.Fill;
            lbx_numbers.Visible = true;
        }
        private void tbx_temp_High_Click(object sender, EventArgs e)
        {
            setting_tbx(tbx_temp_High, 6, 38);
        }
        private void tbx_hum_High_Click(object sender, EventArgs e)
        {
            setting_tbx(tbx_hum_High, 50, 88);
        }
        private void tbx_hum_Low_Click(object sender, EventArgs e)
        {
            setting_tbx(tbx_hum_Low, 50, 88);
        }
        private void tbx_pump_period_Click(object sender, EventArgs e)
        {
            setting_tbx(tbx_pump_period, 1, 24);
        }
        private void tbx_runMin_Click(object sender, EventArgs e)
        {
            setting_tbx(tbx_runMin, 1, 59);
        }
        private void tbx_runSec_Click(object sender, EventArgs e)
        {
            setting_tbx(tbx_runSec, 1, 59);
        }
        private void tbx_stopHour_Click(object sender, EventArgs e)
        {
            setting_tbx(tbx_stopHour, 1, 24);
        }
        private void tbx_stopMin_Click(object sender, EventArgs e)
        {
            setting_tbx(tbx_stopMin, 1, 59);
        }
        private void tbx_stopSec_Click(object sender, EventArgs e)
        {
            setting_tbx(tbx_stopSec, 1, 59);
        }

        private void lbx_numbers_Click(object sender, EventArgs e)
        {

            try
            {
                if (tbx != null)
                {
                    tbx.Text = this.lbx_numbers.SelectedItem.ToString();
                    tbx = null;
                }
                lbx_numbers.Visible = false;
            }
            catch
            {
                MessageBox.Show("숫자를 눌러주시기 바랍니다", "확인");
            }

        }

        private void setting_Load(object sender, EventArgs e)
        {

        }

        private void setting_Shown(object sender, EventArgs e)
        {
            try
            {
                DB.query_execute("select * from setting;", "select");
                tbx_runHour.Text = variable.runTimeHH.ToString();
                tbx_runMin.Text = variable.runTimeMM.ToString();
                tbx_runSec.Text = variable.runTimeSS.ToString();
                tbx_stopHour.Text = variable.stoptimeHH.ToString();
                tbx_stopMin.Text = variable.stoptimeMM.ToString();
                tbx_stopSec.Text = variable.stoptimeSS.ToString();
                tbx_temp_Low.Text = variable.auto_TempLOW.ToString();
                tbx_temp_High.Text = variable.auto_TempHIGH.ToString();
                tbx_hum_Low.Text = variable.auto_HumLOW.ToString();
                tbx_hum_High.Text = variable.auto_HumHIGH.ToString();
                tbx_save_period.Text = variable.save_period.ToString();
                tbx_pump_period.Text = variable.Pump_period.ToString();
            }
            catch
            {

            }
        }
    }
}
