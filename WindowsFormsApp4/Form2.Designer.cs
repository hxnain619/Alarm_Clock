namespace WindowsFormsApp4
{
    partial class Form2
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
            this.linearGradient1 = new WindowsFormsApp4.LinearGradient();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sec_inc = new System.Windows.Forms.Label();
            this.min_dec = new System.Windows.Forms.Label();
            this.sec_dec = new System.Windows.Forms.Label();
            this.min_inc = new System.Windows.Forms.Label();
            this.hour_dec = new System.Windows.Forms.Label();
            this.hour_inc = new System.Windows.Forms.Label();
            this.Hour = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Second = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Minute = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linearGradient1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linearGradient1
            // 
            this.linearGradient1.Angle = 0F;
            this.linearGradient1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linearGradient1.Controls.Add(this.label11);
            this.linearGradient1.Controls.Add(this.panel1);
            this.linearGradient1.Controls.Add(this.label9);
            this.linearGradient1.Controls.Add(this.label1);
            this.linearGradient1.Location = new System.Drawing.Point(0, 0);
            this.linearGradient1.Name = "linearGradient1";
            this.linearGradient1.Size = new System.Drawing.Size(800, 450);
            this.linearGradient1.TabIndex = 0;
            this.linearGradient1.TopColor = System.Drawing.Color.MidnightBlue;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(686, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 42);
            this.label11.TabIndex = 12;
            this.label11.Text = "Add";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.sec_inc);
            this.panel1.Controls.Add(this.min_dec);
            this.panel1.Controls.Add(this.sec_dec);
            this.panel1.Controls.Add(this.min_inc);
            this.panel1.Controls.Add(this.hour_dec);
            this.panel1.Controls.Add(this.hour_inc);
            this.panel1.Controls.Add(this.Hour);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Second);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Minute);
            this.panel1.Location = new System.Drawing.Point(74, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 230);
            this.panel1.TabIndex = 11;
            // 
            // sec_inc
            // 
            this.sec_inc.AutoSize = true;
            this.sec_inc.BackColor = System.Drawing.Color.Transparent;
            this.sec_inc.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sec_inc.ForeColor = System.Drawing.Color.White;
            this.sec_inc.Location = new System.Drawing.Point(566, 17);
            this.sec_inc.Name = "sec_inc";
            this.sec_inc.Size = new System.Drawing.Size(37, 39);
            this.sec_inc.TabIndex = 11;
            this.sec_inc.Text = "+";
            this.sec_inc.Click += new System.EventHandler(this.sec_inc_Click);
            // 
            // min_dec
            // 
            this.min_dec.AutoSize = true;
            this.min_dec.BackColor = System.Drawing.Color.Transparent;
            this.min_dec.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_dec.ForeColor = System.Drawing.Color.White;
            this.min_dec.Location = new System.Drawing.Point(332, 171);
            this.min_dec.Name = "min_dec";
            this.min_dec.Size = new System.Drawing.Size(28, 39);
            this.min_dec.TabIndex = 10;
            this.min_dec.Text = "-";
            this.min_dec.Click += new System.EventHandler(this.min_dec_Click);
            // 
            // sec_dec
            // 
            this.sec_dec.AutoSize = true;
            this.sec_dec.BackColor = System.Drawing.Color.Transparent;
            this.sec_dec.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sec_dec.ForeColor = System.Drawing.Color.White;
            this.sec_dec.Location = new System.Drawing.Point(577, 171);
            this.sec_dec.Name = "sec_dec";
            this.sec_dec.Size = new System.Drawing.Size(28, 39);
            this.sec_dec.TabIndex = 9;
            this.sec_dec.Text = "-";
            this.sec_dec.Click += new System.EventHandler(this.sec_dec_Click);
            // 
            // min_inc
            // 
            this.min_inc.AutoSize = true;
            this.min_inc.BackColor = System.Drawing.Color.Transparent;
            this.min_inc.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_inc.ForeColor = System.Drawing.Color.White;
            this.min_inc.Location = new System.Drawing.Point(321, 17);
            this.min_inc.Name = "min_inc";
            this.min_inc.Size = new System.Drawing.Size(37, 39);
            this.min_inc.TabIndex = 8;
            this.min_inc.Text = "+";
            this.min_inc.Click += new System.EventHandler(this.min_inc_Click);
            // 
            // hour_dec
            // 
            this.hour_dec.AutoSize = true;
            this.hour_dec.BackColor = System.Drawing.Color.Transparent;
            this.hour_dec.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour_dec.ForeColor = System.Drawing.Color.White;
            this.hour_dec.Location = new System.Drawing.Point(87, 171);
            this.hour_dec.Name = "hour_dec";
            this.hour_dec.Size = new System.Drawing.Size(28, 39);
            this.hour_dec.TabIndex = 7;
            this.hour_dec.Text = "-";
            this.hour_dec.Click += new System.EventHandler(this.hour_dec_Click);
            // 
            // hour_inc
            // 
            this.hour_inc.AutoSize = true;
            this.hour_inc.BackColor = System.Drawing.Color.Transparent;
            this.hour_inc.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour_inc.ForeColor = System.Drawing.Color.White;
            this.hour_inc.Location = new System.Drawing.Point(87, 17);
            this.hour_inc.Name = "hour_inc";
            this.hour_inc.Size = new System.Drawing.Size(37, 39);
            this.hour_inc.TabIndex = 6;
            this.hour_inc.Text = "+";
            this.hour_inc.Click += new System.EventHandler(this.hour_inc_Click);
            // 
            // Hour
            // 
            this.Hour.AutoSize = true;
            this.Hour.BackColor = System.Drawing.Color.Transparent;
            this.Hour.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hour.ForeColor = System.Drawing.Color.White;
            this.Hour.Location = new System.Drawing.Point(27, 56);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(155, 115);
            this.Hour.TabIndex = 1;
            this.Hour.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(202, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = ":";
            // 
            // Second
            // 
            this.Second.AutoSize = true;
            this.Second.BackColor = System.Drawing.Color.Transparent;
            this.Second.Font = new System.Drawing.Font("Century Gothic", 72F);
            this.Second.ForeColor = System.Drawing.Color.White;
            this.Second.Location = new System.Drawing.Point(506, 56);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(155, 115);
            this.Second.TabIndex = 3;
            this.Second.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(449, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 39);
            this.label6.TabIndex = 5;
            this.label6.Text = ":";
            // 
            // Minute
            // 
            this.Minute.AutoSize = true;
            this.Minute.BackColor = System.Drawing.Color.Transparent;
            this.Minute.Font = new System.Drawing.Font("Century Gothic", 72F);
            this.Minute.ForeColor = System.Drawing.Color.White;
            this.Minute.Location = new System.Drawing.Point(268, 56);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(155, 115);
            this.Minute.TabIndex = 4;
            this.Minute.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(770, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "x";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(323, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set Alarm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linearGradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.linearGradient1.ResumeLayout(false);
            this.linearGradient1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LinearGradient linearGradient1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label sec_inc;
        private System.Windows.Forms.Label min_dec;
        private System.Windows.Forms.Label sec_dec;
        private System.Windows.Forms.Label min_inc;
        private System.Windows.Forms.Label hour_dec;
        private System.Windows.Forms.Label hour_inc;
        private System.Windows.Forms.Label Hour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Second;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Minute;
    }
}