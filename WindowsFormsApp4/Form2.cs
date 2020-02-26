using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

            Form1 Main = new Form1();
        int SetHour = 0, SetMin = 0, SetSec = 0;

       

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main.Show();
            
        }

        private void min_inc_Click(object sender, EventArgs e)
        {
            if (SetMin >= 60)
            {
                SetMin = 0;
            }
            ++SetMin;
            if (SetMin <= 9)
            {
                Minute.Text = Convert.ToString("0" + SetMin);
            }
            else
            {
                Minute.Text = Convert.ToString(SetMin);
            }
        }

        private void min_dec_Click(object sender, EventArgs e)
        {
            if (SetMin > 0)
            {
                --SetMin;
            }

            if (SetMin <= 9)
            {
                Minute.Text = Convert.ToString("0" + SetMin);
            }
            else
            {
                Minute.Text = Convert.ToString(SetMin);
            }
        }

        private void sec_inc_Click(object sender, EventArgs e)
        {
            if (SetSec >= 60)
            {
                SetSec = 0;
            }
            ++SetSec;
            if (SetSec <= 9)
            {
                Second.Text = Convert.ToString("0" + SetSec);
            }
            else
            {
                Second.Text = Convert.ToString(SetSec);
            }
        }

        private void sec_dec_Click(object sender, EventArgs e)
        {
            if (SetSec > 0)
            {
                --SetSec;
            }

            if (SetSec <= 9)
            {
                Second.Text = Convert.ToString("0" + SetSec);
            }
            else
            {
                Second.Text = Convert.ToString(SetSec);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            AlarmTimeSet time_obj = new AlarmTimeSet();
            string Time = Hour.Text + ":" + Minute.Text + ":" + Second.Text;
            string H = Convert.ToString(SetHour);
            string M = Convert.ToString(SetMin);
            string S = Convert.ToString(SetSec);

            Main.AddTableRow(Time, H, M, S);
            this.Hide();
            Main.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hour_inc_Click(object sender, EventArgs e)
        {
            if(SetHour >= 60 )
            {
                SetHour = 0;
            }
            ++SetHour;
            if(SetHour <= 9)
            {
                Hour.Text = Convert.ToString("0"+SetHour);
            }
            else
            {
            Hour.Text = Convert.ToString(SetHour);
            }
        }
        private void hour_dec_Click(object sender, EventArgs e)
        {
            if(SetHour > 0)
            {
            --SetHour;
            }

            if (SetHour <= 9)
            {
                Hour.Text = Convert.ToString("0" + SetHour);
            }
            else
            {
                Hour.Text = Convert.ToString(SetHour);
            }
        }
    }
}
