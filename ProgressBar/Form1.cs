using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        int Num = 0;
        string OrgStr = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.OrgStr = this.lblStatus.Text;
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Num++;
            if (this.Num <= 100)
            {
                this.pbStatus.Value = this.Num;
                this.lblStatus.Text = this.OrgStr + this.Num + "%";
            }else
            {
                this.timer1.Enabled = false;
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.Num = 0;
            this.pbStatus.Value = 0;
            this.lblStatus.Text = this.OrgStr;
        }
    }
}
