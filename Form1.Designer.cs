namespace Lab12
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btToggle = new System.Windows.Forms.Button();
            this.lbCurWeather = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbClear = new System.Windows.Forms.Label();
            this.lbCloudy = new System.Windows.Forms.Label();
            this.lbOvercast = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbState = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.btToggle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 100);
            this.panel1.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(269, 34);
            this.trackBar1.Maximum = 4;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(228, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // btToggle
            // 
            this.btToggle.Location = new System.Drawing.Point(69, 34);
            this.btToggle.Name = "btToggle";
            this.btToggle.Size = new System.Drawing.Size(75, 23);
            this.btToggle.TabIndex = 0;
            this.btToggle.Text = "button1";
            this.btToggle.UseVisualStyleBackColor = true;
            this.btToggle.Click += new System.EventHandler(this.btToggle_Click);
            // 
            // lbCurWeather
            // 
            this.lbCurWeather.AutoSize = true;
            this.lbCurWeather.Location = new System.Drawing.Point(23, 103);
            this.lbCurWeather.Name = "lbCurWeather";
            this.lbCurWeather.Size = new System.Drawing.Size(0, 13);
            this.lbCurWeather.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stationary distribution:";
            // 
            // lbClear
            // 
            this.lbClear.AutoSize = true;
            this.lbClear.Location = new System.Drawing.Point(12, 152);
            this.lbClear.Name = "lbClear";
            this.lbClear.Size = new System.Drawing.Size(0, 13);
            this.lbClear.TabIndex = 3;
            // 
            // lbCloudy
            // 
            this.lbCloudy.AutoSize = true;
            this.lbCloudy.Location = new System.Drawing.Point(12, 174);
            this.lbCloudy.Name = "lbCloudy";
            this.lbCloudy.Size = new System.Drawing.Size(0, 13);
            this.lbCloudy.TabIndex = 4;
            // 
            // lbOvercast
            // 
            this.lbOvercast.AutoSize = true;
            this.lbOvercast.Location = new System.Drawing.Point(12, 197);
            this.lbOvercast.Name = "lbOvercast";
            this.lbOvercast.Size = new System.Drawing.Size(0, 13);
            this.lbOvercast.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Location = new System.Drawing.Point(266, 103);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(0, 13);
            this.lbState.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 572);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.lbOvercast);
            this.Controls.Add(this.lbCloudy);
            this.Controls.Add(this.lbClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCurWeather);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btToggle;
        private System.Windows.Forms.Label lbCurWeather;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbClear;
        private System.Windows.Forms.Label lbCloudy;
        private System.Windows.Forms.Label lbOvercast;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbState;
    }
}

