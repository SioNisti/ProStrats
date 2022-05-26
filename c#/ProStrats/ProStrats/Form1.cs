using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProStrats
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private int s = 0;
        private int f = 0;
        private int sr = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s = 0;
            f = 0;
            sr = 0;
            attempts.Text = "Attempts: " + (s + f);
            inaRow.Text = "In a row: " + sr;
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
                sr++;
                s++;
                inaRow.Text = "In a row: " + sr;
                success.Text = "Success: " + s;
                attempts.Text = "Attempts: " + (s + f);
            }
            else if (keyData == Keys.Down)
            {
                sr = 0;
                f++;
                inaRow.Text = "In a row: " + sr;
                failed.Text = "Failed: " + f;
                attempts.Text = "Attempts: " + (s + f);
            }
            double c = Math.Round((double)s / (double)(s + f) * 100.0);
            consistency.Text = "Consistency: " + c + "%";
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
