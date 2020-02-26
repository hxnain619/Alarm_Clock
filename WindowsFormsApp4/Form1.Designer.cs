namespace WindowsFormsApp4
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linearGradient1 = new WindowsFormsApp4.LinearGradient();
            this.label2 = new System.Windows.Forms.Label();
            this.AlarmList = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Hour = new System.Windows.Forms.Label();
            this.Morning = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Second = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Minute = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linearGradient1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // linearGradient1
            // 
            this.linearGradient1.Angle = 0F;
            this.linearGradient1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linearGradient1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.linearGradient1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linearGradient1.Controls.Add(this.label2);
            this.linearGradient1.Controls.Add(this.AlarmList);
            this.linearGradient1.Controls.Add(this.label9);
            this.linearGradient1.Controls.Add(this.label8);
            this.linearGradient1.Controls.Add(this.panel1);
            this.linearGradient1.Controls.Add(this.label1);
            this.linearGradient1.ForeColor = System.Drawing.Color.Transparent;
            this.linearGradient1.Location = new System.Drawing.Point(0, 1);
            this.linearGradient1.Name = "linearGradient1";
            this.linearGradient1.Size = new System.Drawing.Size(801, 473);
            this.linearGradient1.TabIndex = 0;
            this.linearGradient1.TopColor = System.Drawing.Color.MidnightBlue;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(278, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 44);
            this.label2.TabIndex = 11;
            this.label2.Text = "Alarm List";
            // 
            // AlarmList
            // 
            this.AlarmList.AutoScroll = true;
            this.AlarmList.BackColor = System.Drawing.Color.Transparent;
            this.AlarmList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlarmList.Location = new System.Drawing.Point(115, 291);
            this.AlarmList.MaximumSize = new System.Drawing.Size(565, 240);
            this.AlarmList.Name = "AlarmList";
            this.AlarmList.Size = new System.Drawing.Size(565, 123);
            this.AlarmList.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(774, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "x";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(734, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 58);
            this.label8.TabIndex = 7;
            this.label8.Text = "+";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Hour);
            this.panel1.Controls.Add(this.Morning);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Second);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Minute);
            this.panel1.Location = new System.Drawing.Point(115, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 117);
            this.panel1.TabIndex = 7;
            // 
            // Hour
            // 
            this.Hour.AutoSize = true;
            this.Hour.BackColor = System.Drawing.Color.Transparent;
            this.Hour.Font = new System.Drawing.Font("Century Gothic", 36F);
            this.Hour.ForeColor = System.Drawing.Color.White;
            this.Hour.Location = new System.Drawing.Point(22, 27);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(79, 58);
            this.Hour.TabIndex = 1;
            this.Hour.Text = "00";
            // 
            // Morning
            // 
            this.Morning.AutoSize = true;
            this.Morning.BackColor = System.Drawing.Color.Transparent;
            this.Morning.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Morning.ForeColor = System.Drawing.Color.White;
            this.Morning.Location = new System.Drawing.Point(442, 27);
            this.Morning.Name = "Morning";
            this.Morning.Size = new System.Drawing.Size(105, 58);
            this.Morning.TabIndex = 6;
            this.Morning.Text = "AM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(121, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = ":";
            // 
            // Second
            // 
            this.Second.AutoSize = true;
            this.Second.BackColor = System.Drawing.Color.Transparent;
            this.Second.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Second.ForeColor = System.Drawing.Color.White;
            this.Second.Location = new System.Drawing.Point(332, 27);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(79, 58);
            this.Second.TabIndex = 3;
            this.Second.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(278, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 39);
            this.label6.TabIndex = 5;
            this.label6.Text = ":";
            // 
            // Minute
            // 
            this.Minute.AutoSize = true;
            this.Minute.BackColor = System.Drawing.Color.Transparent;
            this.Minute.Font = new System.Drawing.Font("Century Gothic", 36F);
            this.Minute.ForeColor = System.Drawing.Color.White;
            this.Minute.Location = new System.Drawing.Point(181, 27);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(79, 58);
            this.Minute.TabIndex = 4;
            this.Minute.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(289, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alarm Clock";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.linearGradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.linearGradient1.ResumeLayout(false);
            this.linearGradient1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LinearGradient linearGradient1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Hour;
        private System.Windows.Forms.Label Morning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Second;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Minute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel AlarmList;
        private System.Windows.Forms.Label label2;
    }
}

