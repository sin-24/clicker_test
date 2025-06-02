using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms_test1
{
    public partial class Form1 : Form
    {
        private static bool messageshown = false;

        private int clicks = 0;

        private int time = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += progressBar2_TimeTick;
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(progressBar1.Value == progressBar1.Maximum))
            {
                clicks++;
                label1.Text = $"{clicks}";
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 300;
                progressBar1.Value = clicks;
            }
            else
            {
                if (!messageshown)
                {
                    MessageBox.Show("You won!");
                    messageshown = true;
                    Application.Exit();
                }
            }
        }

        private void progressBar2_TimeTick(object sender, EventArgs e)
        {
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 60;
            if (progressBar2.Value < 60)
            {
                progressBar2.Value = time;
                time++;
            }
            else
            {
                if (!messageshown)
                {
                    MessageBox.Show("Time is out:)");
                    messageshown = true;
                    Application.Exit();
                }
            }
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
