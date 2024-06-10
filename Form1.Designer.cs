namespace C_SHARP_FOR
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
            this.btntinh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lblkq = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(136, 137);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 0;
            this.btntinh.Text = "Tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Số";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(123, 55);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 2;
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(46, 93);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(53, 13);
            this.lblkq.TabIndex = 1;
            this.lblkq.Text = "Giai Thừa";
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(123, 90);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 20);
            this.txtkq.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.TextBox txtkq;
    }
}

