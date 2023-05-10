namespace Lab_Form
{
    partial class 作業0711_MyClac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(作業0711_MyClac));
            this.Lab數字1 = new System.Windows.Forms.Label();
            this.Lab數字2 = new System.Windows.Forms.Label();
            this.LabAnswer = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lab數字1
            // 
            this.Lab數字1.AutoSize = true;
            this.Lab數字1.BackColor = System.Drawing.Color.Transparent;
            this.Lab數字1.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab數字1.Location = new System.Drawing.Point(33, 99);
            this.Lab數字1.Name = "Lab數字1";
            this.Lab數字1.Size = new System.Drawing.Size(53, 18);
            this.Lab數字1.TabIndex = 0;
            this.Lab數字1.Text = "Num1";
            // 
            // Lab數字2
            // 
            this.Lab數字2.AutoSize = true;
            this.Lab數字2.BackColor = System.Drawing.Color.Transparent;
            this.Lab數字2.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab數字2.Location = new System.Drawing.Point(33, 145);
            this.Lab數字2.Name = "Lab數字2";
            this.Lab數字2.Size = new System.Drawing.Size(53, 18);
            this.Lab數字2.TabIndex = 1;
            this.Lab數字2.Text = "Num2";
            // 
            // LabAnswer
            // 
            this.LabAnswer.AutoSize = true;
            this.LabAnswer.BackColor = System.Drawing.Color.Transparent;
            this.LabAnswer.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabAnswer.Location = new System.Drawing.Point(33, 232);
            this.LabAnswer.Name = "LabAnswer";
            this.LabAnswer.Size = new System.Drawing.Size(67, 18);
            this.LabAnswer.TabIndex = 2;
            this.LabAnswer.Text = "Answer";
            // 
            // btnPlus
            // 
            this.btnPlus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlus.Location = new System.Drawing.Point(252, 58);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(59, 28);
            this.btnPlus.TabIndex = 5;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNum2.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum2.Location = new System.Drawing.Point(120, 142);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(99, 29);
            this.txtNum2.TabIndex = 2;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum1
            // 
            this.txtNum1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNum1.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum1.Location = new System.Drawing.Point(120, 96);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(99, 29);
            this.txtNum1.TabIndex = 1;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnswer.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAnswer.ForeColor = System.Drawing.Color.Red;
            this.txtAnswer.Location = new System.Drawing.Point(120, 229);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(99, 29);
            this.txtAnswer.TabIndex = 3;
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMinus
            // 
            this.btnMinus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMinus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinus.Location = new System.Drawing.Point(252, 92);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(59, 28);
            this.btnMinus.TabIndex = 6;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMul
            // 
            this.btnMul.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMul.BackColor = System.Drawing.Color.Transparent;
            this.btnMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMul.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMul.Location = new System.Drawing.Point(252, 126);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(59, 28);
            this.btnMul.TabIndex = 7;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDiv.BackColor = System.Drawing.Color.Transparent;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDiv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDiv.Location = new System.Drawing.Point(252, 160);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(59, 28);
            this.btnDiv.TabIndex = 8;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // 作業0711_MyClac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.LabAnswer);
            this.Controls.Add(this.Lab數字2);
            this.Controls.Add(this.Lab數字1);
            this.Name = "作業0711_MyClac";
            this.Text = "作業0711_MyClac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab數字1;
        private System.Windows.Forms.Label Lab數字2;
        private System.Windows.Forms.Label LabAnswer;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
    }
}