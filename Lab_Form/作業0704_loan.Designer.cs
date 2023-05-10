namespace Lab_Form
{
    partial class 作業0704_loan
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
            this.txt貸款金額 = new System.Windows.Forms.TextBox();
            this.txt期限 = new System.Windows.Forms.TextBox();
            this.txt利率 = new System.Windows.Forms.TextBox();
            this.txt頭期款 = new System.Windows.Forms.TextBox();
            this.btn月付款 = new System.Windows.Forms.Button();
            this.btn總付款 = new System.Windows.Forms.Button();
            this.Label貸款金額 = new System.Windows.Forms.Label();
            this.Label頭期款 = new System.Windows.Forms.Label();
            this.Label期限 = new System.Windows.Forms.Label();
            this.Label月利率 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt貸款金額
            // 
            this.txt貸款金額.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt貸款金額.Location = new System.Drawing.Point(167, 35);
            this.txt貸款金額.Name = "txt貸款金額";
            this.txt貸款金額.Size = new System.Drawing.Size(109, 29);
            this.txt貸款金額.TabIndex = 0;
            // 
            // txt期限
            // 
            this.txt期限.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt期限.Location = new System.Drawing.Point(167, 90);
            this.txt期限.Name = "txt期限";
            this.txt期限.Size = new System.Drawing.Size(109, 29);
            this.txt期限.TabIndex = 1;
            // 
            // txt利率
            // 
            this.txt利率.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt利率.Location = new System.Drawing.Point(167, 140);
            this.txt利率.Name = "txt利率";
            this.txt利率.Size = new System.Drawing.Size(109, 29);
            this.txt利率.TabIndex = 2;
            // 
            // txt頭期款
            // 
            this.txt頭期款.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt頭期款.Location = new System.Drawing.Point(167, 194);
            this.txt頭期款.Name = "txt頭期款";
            this.txt頭期款.Size = new System.Drawing.Size(109, 29);
            this.txt頭期款.TabIndex = 3;
            // 
            // btn月付款
            // 
            this.btn月付款.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn月付款.Location = new System.Drawing.Point(35, 245);
            this.btn月付款.Name = "btn月付款";
            this.btn月付款.Size = new System.Drawing.Size(125, 57);
            this.btn月付款.TabIndex = 4;
            this.btn月付款.Text = "PMT(月付款)";
            this.btn月付款.UseVisualStyleBackColor = true;
            this.btn月付款.Click += new System.EventHandler(this.btn月付款_Click);
            // 
            // btn總付款
            // 
            this.btn總付款.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn總付款.Location = new System.Drawing.Point(194, 245);
            this.btn總付款.Name = "btn總付款";
            this.btn總付款.Size = new System.Drawing.Size(125, 57);
            this.btn總付款.TabIndex = 7;
            this.btn總付款.Text = "總付款";
            this.btn總付款.UseVisualStyleBackColor = true;
            this.btn總付款.Click += new System.EventHandler(this.btn總付款_Click);
            // 
            // Label貸款金額
            // 
            this.Label貸款金額.AutoSize = true;
            this.Label貸款金額.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label貸款金額.Location = new System.Drawing.Point(57, 26);
            this.Label貸款金額.Name = "Label貸款金額";
            this.Label貸款金額.Size = new System.Drawing.Size(84, 18);
            this.Label貸款金額.TabIndex = 8;
            this.Label貸款金額.Text = "貸款金額";
            // 
            // Label頭期款
            // 
            this.Label頭期款.AutoSize = true;
            this.Label頭期款.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label頭期款.Location = new System.Drawing.Point(57, 185);
            this.Label頭期款.Name = "Label頭期款";
            this.Label頭期款.Size = new System.Drawing.Size(65, 18);
            this.Label頭期款.TabIndex = 9;
            this.Label頭期款.Text = "頭期款";
            // 
            // Label期限
            // 
            this.Label期限.AutoSize = true;
            this.Label期限.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label期限.Location = new System.Drawing.Point(57, 81);
            this.Label期限.Name = "Label期限";
            this.Label期限.Size = new System.Drawing.Size(79, 18);
            this.Label期限.TabIndex = 10;
            this.Label期限.Text = "期限(年)";
            // 
            // Label月利率
            // 
            this.Label月利率.AutoSize = true;
            this.Label月利率.Font = new System.Drawing.Font("新細明體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label月利率.Location = new System.Drawing.Point(57, 131);
            this.Label月利率.Name = "Label月利率";
            this.Label月利率.Size = new System.Drawing.Size(94, 18);
            this.Label月利率.TabIndex = 11;
            this.Label月利率.Text = "月利率(%)";
            // 
            // 作業0704_loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 340);
            this.Controls.Add(this.Label月利率);
            this.Controls.Add(this.Label期限);
            this.Controls.Add(this.Label頭期款);
            this.Controls.Add(this.Label貸款金額);
            this.Controls.Add(this.btn總付款);
            this.Controls.Add(this.btn月付款);
            this.Controls.Add(this.txt頭期款);
            this.Controls.Add(this.txt利率);
            this.Controls.Add(this.txt期限);
            this.Controls.Add(this.txt貸款金額);
            this.Name = "作業0704_loan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt貸款金額;
        private System.Windows.Forms.TextBox txt期限;
        private System.Windows.Forms.TextBox txt利率;
        private System.Windows.Forms.TextBox txt頭期款;
        private System.Windows.Forms.Button btn月付款;
        private System.Windows.Forms.Button btn總付款;
        private System.Windows.Forms.Label Label貸款金額;
        private System.Windows.Forms.Label Label頭期款;
        private System.Windows.Forms.Label Label期限;
        private System.Windows.Forms.Label Label月利率;
    }
}