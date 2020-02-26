using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        string H, M, S;

        public void RingTheAlarm()
        {
            DateTime CurrentTime = DateTime.Now;

            if (H == Convert.ToString(CurrentTime.Hour) && M == Convert.ToString(CurrentTime.Minute) && S == Convert.ToString(CurrentTime.Second))
            {
                Form3 AlarmBox = new Form3();
                AlarmBox.Show();

            }
                       
        }
        public void AddTableRow(string Time, string h, string m, string s)
        {

        Label lb = new Label();
        lb.AutoSize = true;
        lb.BackColor = System.Drawing.Color.Transparent;
        lb.ForeColor = System.Drawing.Color.White;
        lb.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        lb.Location = new System.Drawing.Point(190, 8);
        lb.Size = new System.Drawing.Size(244, 44);
        lb.TabIndex = 0;
        lb.Name = Time;
        lb.Text = Time;
        AlarmList.Controls.Add(lb);

        // Assigning values to varibles
            H = h;
            M = m;
            S = s;

            
        }
    private void label9_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 SetAlarm = new Form2();
            SetAlarm.Show();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.GetTime();
            this.RingTheAlarm();

        }
        private void GetTime()
        {
            DateTime CurrentTime = DateTime.Now;
            Double CurrentHour, CurrentMinute, CurrentSecond;

            CurrentHour = CurrentTime.Hour;
            CurrentMinute = CurrentTime.Minute;
            CurrentSecond = CurrentTime.Second;

            // Settings for Hours 
            if (CurrentHour == 0)
            {
                Hour.Text = "12";
            }
            else
            {
                if(CurrentHour > 9)
                {
                   Hour.Text = Convert.ToString(CurrentHour);
                }else
                {
                    Hour.Text = Convert.ToString("0"+CurrentHour);
                }
            }

            // Settings for Minutes

            if (CurrentMinute > 9)
            {
                Minute.Text = Convert.ToString(CurrentMinute);
            }
            else
            {
                Minute.Text = Convert.ToString("0" + CurrentMinute);
            }

            // Settings for Seconds 

            if (CurrentSecond > 9)
            {
                Second.Text = Convert.ToString(CurrentSecond);

            }
            else
            {
                Second.Text = Convert.ToString("0"+CurrentSecond);

            }

            if (CurrentHour > 12)
            {
                Morning.Text = "PM";
            }
            else
            {
                Morning.Text = "AM";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.GetTime();
            this.RingTheAlarm();

        }

    }
}
