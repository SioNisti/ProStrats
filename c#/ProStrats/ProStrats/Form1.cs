using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProStrats
{
    public partial class Form1 : Form
    {

        private int s = 0;
        private int f = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = 0;
            f = 0;
            success.Text = "Success: " + s;
            failed.Text = "Failed: " + f;
            consistency.Text = "Consistency: 0%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                s++;
                success.Text = "Success: " + s;
            }
            else if (keyData == Keys.Down)
            {
                f++;
                failed.Text = "Failed: " + f;
            }
            double c = Math.Round((double)s / (double)(s + f) * 100.0);
            consistency.Text = "Consistency: " + c + "%";
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
