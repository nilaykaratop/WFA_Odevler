namespace WFA_OdevIfElse
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
            this.txtDeger1 = new System.Windows.Forms.TextBox();
            this.txtDeger2 = new System.Windows.Forms.TextBox();
            this.btnOrnek2 = new System.Windows.Forms.Button();
            this.btnOrnek4 = new System.Windows.Forms.Button();
            this.btnOrnek5 = new System.Windows.Forms.Button();
            this.txtDeger3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDeger1
            // 
            this.txtDeger1.Location = new System.Drawing.Point(25, 12);
            this.txtDeger1.Name = "txtDeger1";
            this.txtDeger1.Size = new System.Drawing.Size(181, 20);
            this.txtDeger1.TabIndex = 0;
            // 
            // txtDeger2
            // 
            this.txtDeger2.Location = new System.Drawing.Point(25, 38);
            this.txtDeger2.Name = "txtDeger2";
            this.txtDeger2.Size = new System.Drawing.Size(181, 20);
            this.txtDeger2.TabIndex = 1;
            // 
            // btnOrnek2
            // 
            this.btnOrnek2.Location = new System.Drawing.Point(44, 109);
            this.btnOrnek2.Name = "btnOrnek2";
            this.btnOrnek2.Size = new System.Drawing.Size(141, 23);
            this.btnOrnek2.TabIndex = 3;
            this.btnOrnek2.Text = "Not Kontrolü";
            this.btnOrnek2.UseVisualStyleBackColor = true;
            this.btnOrnek2.Click += new System.EventHandler(this.btnOrnek2_Click);
            // 
            // btnOrnek4
            // 
            this.btnOrnek4.Location = new System.Drawing.Point(44, 138);
            this.btnOrnek4.Name = "btnOrnek4";
            this.btnOrnek4.Size = new System.Drawing.Size(141, 23);
            this.btnOrnek4.TabIndex = 5;
            this.btnOrnek4.Text = "Market Kontrolü";
            this.btnOrnek4.UseVisualStyleBackColor = true;
            this.btnOrnek4.Click += new System.EventHandler(this.btnOrnek4_Click);
            // 
            // btnOrnek5
            // 
            this.btnOrnek5.Location = new System.Drawing.Point(44, 167);
            this.btnOrnek5.Name = "btnOrnek5";
            this.btnOrnek5.Size = new System.Drawing.Size(141, 23);
            this.btnOrnek5.TabIndex = 6;
            this.btnOrnek5.Text = "Satış İşlemi";
            this.btnOrnek5.UseVisualStyleBackColor = true;
            this.btnOrnek5.Click += new System.EventHandler(this.btnOrnek5_Click);
            // 
            // txtDeger3
            // 
            this.txtDeger3.Location = new System.Drawing.Point(25, 64);
            this.txtDeger3.Name = "txtDeger3";
            this.txtDeger3.Size = new System.Drawing.Size(181, 20);
            this.txtDeger3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 202);
            this.Controls.Add(this.txtDeger3);
            this.Controls.Add(this.btnOrnek5);
            this.Controls.Add(this.btnOrnek4);
            this.Controls.Add(this.btnOrnek2);
            this.Controls.Add(this.txtDeger2);
            this.Controls.Add(this.txtDeger1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeger1;
        private System.Windows.Forms.TextBox txtDeger2;
        private System.Windows.Forms.Button btnOrnek2;
        private System.Windows.Forms.Button btnOrnek4;
        private System.Windows.Forms.Button btnOrnek5;
        private System.Windows.Forms.TextBox txtDeger3;
    }
}

