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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            wplayer.controls.stop();
        }

        private void linearGradient1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            wplayer.URL = @"C:\Users\Perfect\Downloads\alarm.mp3";
            wplayer.controls.play();

        }
    }
}
