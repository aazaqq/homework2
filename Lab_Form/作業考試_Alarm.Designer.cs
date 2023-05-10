namespace Lab_Form
{
    partial class 作業考試_Alarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(作業考試_Alarm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LabTimer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.LabShowTimer = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LabTimer
            // 
            this.LabTimer.AutoSize = true;
            this.LabTimer.BackColor = System.Drawing.Color.Transparent;
            this.LabTimer.Font = new System.Drawing.Font("微軟正黑體", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabTimer.ForeColor = System.Drawing.Color.DimGray;
            this.LabTimer.Location = new System.Drawing.Point(12, 9);
            this.LabTimer.Name = "LabTimer";
            this.LabTimer.Size = new System.Drawing.Size(66, 17);
            this.LabTimer.TabIndex = 0;
            this.LabTimer.Text = "LabTimer";
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("微軟正黑體", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStart.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnStart.Location = new System.Drawing.Point(94, 223);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(137, 58);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // LabShowTimer
            // 
            this.LabShowTimer.AutoSize = true;
            this.LabShowTimer.BackColor = System.Drawing.Color.Transparent;
            this.LabShowTimer.Font = new System.Drawing.Font("微軟正黑體", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabShowTimer.ForeColor = System.Drawing.Color.Brown;
            this.LabShowTimer.Location = new System.Drawing.Point(40, 105);
            this.LabShowTimer.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.LabShowTimer.Name = "LabShowTimer";
            this.LabShowTimer.Padding = new System.Windows.Forms.Padding(10);
            this.LabShowTimer.Size = new System.Drawing.Size(173, 52);
            this.LabShowTimer.TabIndex = 2;
            this.LabShowTimer.Text = "Alarm Time";
            this.LabShowTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // 作業考試_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(329, 293);
            this.Controls.Add(this.LabShowTimer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.LabTimer);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "作業考試_Alarm";
            this.Text = "作業考試_Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LabTimer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label LabShowTimer;
        private System.Windows.Forms.Timer timer2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}