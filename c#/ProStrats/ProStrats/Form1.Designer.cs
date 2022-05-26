namespace ProStrats
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.attempts = new System.Windows.Forms.Label();
            this.success = new System.Windows.Forms.Label();
            this.failed = new System.Windows.Forms.Label();
            this.consistency = new System.Windows.Forms.Label();
            this.inaRow = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // attempts
            // 
            this.attempts.AutoSize = true;
            this.attempts.BackColor = System.Drawing.SystemColors.ControlText;
            this.attempts.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attempts.ForeColor = System.Drawing.SystemColors.Control;
            this.attempts.Location = new System.Drawing.Point(12, 9);
            this.attempts.Name = "attempts";
            this.attempts.Size = new System.Drawing.Size(126, 24);
            this.attempts.TabIndex = 2;
            this.attempts.Text = "Attempts: 0";
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.BackColor = System.Drawing.SystemColors.ControlText;
            this.success.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.success.ForeColor = System.Drawing.SystemColors.Control;
            this.success.Location = new System.Drawing.Point(12, 39);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(114, 24);
            this.success.TabIndex = 3;
            this.success.Text = "Success: 0";
            // 
            // failed
            // 
            this.failed.AutoSize = true;
            this.failed.BackColor = System.Drawing.SystemColors.ControlText;
            this.failed.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failed.ForeColor = System.Drawing.SystemColors.Control;
            this.failed.Location = new System.Drawing.Point(12, 71);
            this.failed.Name = "failed";
            this.failed.Size = new System.Drawing.Size(93, 24);
            this.failed.TabIndex = 4;
            this.failed.Text = "Failed: 0";
            // 
            // consistency
            // 
            this.consistency.AutoSize = true;
            this.consistency.BackColor = System.Drawing.SystemColors.ControlText;
            this.consistency.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consistency.ForeColor = System.Drawing.SystemColors.Control;
            this.consistency.Location = new System.Drawing.Point(4, 97);
            this.consistency.Name = "consistency";
            this.consistency.Size = new System.Drawing.Size(332, 49);
            this.consistency.TabIndex = 5;
            this.consistency.Text = "Consistency: 0%";
            // 
            // inaRow
            // 
            this.inaRow.AutoSize = true;
            this.inaRow.BackColor = System.Drawing.SystemColors.ControlText;
            this.inaRow.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inaRow.ForeColor = System.Drawing.SystemColors.Control;
            this.inaRow.Location = new System.Drawing.Point(211, 9);
            this.inaRow.Name = "inaRow";
            this.inaRow.Size = new System.Drawing.Size(115, 24);
            this.inaRow.TabIndex = 6;
            this.inaRow.Text = "In a row: 0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(385, 152);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.inaRow);
            this.Controls.Add(this.consistency);
            this.Controls.Add(this.failed);
            this.Controls.Add(this.success);
            this.Controls.Add(this.attempts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "ProStrats";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label attempts;
        private System.Windows.Forms.Label success;
        private System.Windows.Forms.Label failed;
        private System.Windows.Forms.Label consistency;
        private System.Windows.Forms.Label inaRow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

