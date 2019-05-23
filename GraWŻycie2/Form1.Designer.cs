namespace GraWŻycie2
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
            this.GRAJ = new System.Windows.Forms.Button();
            this.START = new System.Windows.Forms.Button();
            this.STOP = new System.Windows.Forms.Button();
            this.WczytajPlansze = new System.Windows.Forms.Button();
            this.ZapiszPlansze = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // GRAJ
            // 
            this.GRAJ.Location = new System.Drawing.Point(37, 12);
            this.GRAJ.Name = "GRAJ";
            this.GRAJ.Size = new System.Drawing.Size(75, 23);
            this.GRAJ.TabIndex = 0;
            this.GRAJ.Text = "Graj";
            this.GRAJ.UseVisualStyleBackColor = true;
            this.GRAJ.Visible = false;
            this.GRAJ.Click += new System.EventHandler(this.GRAJ_Click);
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(37, 41);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(75, 23);
            this.START.TabIndex = 1;
            this.START.Text = "Start";
            this.START.UseVisualStyleBackColor = true;
            this.START.Visible = false;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // STOP
            // 
            this.STOP.Location = new System.Drawing.Point(37, 70);
            this.STOP.Name = "STOP";
            this.STOP.Size = new System.Drawing.Size(75, 23);
            this.STOP.TabIndex = 2;
            this.STOP.Text = "Stop";
            this.STOP.UseVisualStyleBackColor = true;
            this.STOP.Visible = false;
            this.STOP.Click += new System.EventHandler(this.STOP_Click_1);
            // 
            // WczytajPlansze
            // 
            this.WczytajPlansze.Location = new System.Drawing.Point(37, 99);
            this.WczytajPlansze.Name = "WczytajPlansze";
            this.WczytajPlansze.Size = new System.Drawing.Size(75, 23);
            this.WczytajPlansze.TabIndex = 3;
            this.WczytajPlansze.Text = "Wczytaj grę";
            this.WczytajPlansze.UseVisualStyleBackColor = true;
            this.WczytajPlansze.Click += new System.EventHandler(this.WczytajPlansze_Click);
            // 
            // ZapiszPlansze
            // 
            this.ZapiszPlansze.Location = new System.Drawing.Point(37, 128);
            this.ZapiszPlansze.Name = "ZapiszPlansze";
            this.ZapiszPlansze.Size = new System.Drawing.Size(75, 23);
            this.ZapiszPlansze.TabIndex = 4;
            this.ZapiszPlansze.Text = "Zapisz";
            this.ZapiszPlansze.UseVisualStyleBackColor = true;
            this.ZapiszPlansze.Visible = false;
            this.ZapiszPlansze.Click += new System.EventHandler(this.ZapiszPlansze_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(37, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "10x10";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(37, 186);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "10x15";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(37, 215);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "15x15";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(149, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 94);
            this.panel1.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1654, 708);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.ZapiszPlansze);
            this.Controls.Add(this.WczytajPlansze);
            this.Controls.Add(this.STOP);
            this.Controls.Add(this.START);
            this.Controls.Add(this.GRAJ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GRAJ;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Button STOP;
        private System.Windows.Forms.Button WczytajPlansze;
        private System.Windows.Forms.Button ZapiszPlansze;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}

