namespace PRG.Zip
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
            this.BtnZip = new System.Windows.Forms.Button();
            this.BtnUnzip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnZip
            // 
            this.BtnZip.Location = new System.Drawing.Point(19, 25);
            this.BtnZip.Name = "BtnZip";
            this.BtnZip.Size = new System.Drawing.Size(111, 40);
            this.BtnZip.TabIndex = 0;
            this.BtnZip.Text = "ZIP file";
            this.BtnZip.UseVisualStyleBackColor = true;
            this.BtnZip.Click += new System.EventHandler(this.BtnZip_Click);
            // 
            // BtnUnzip
            // 
            this.BtnUnzip.Location = new System.Drawing.Point(278, 25);
            this.BtnUnzip.Name = "BtnUnzip";
            this.BtnUnzip.Size = new System.Drawing.Size(151, 40);
            this.BtnUnzip.TabIndex = 1;
            this.BtnUnzip.Text = "Unzip";
            this.BtnUnzip.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 338);
            this.Controls.Add(this.BtnUnzip);
            this.Controls.Add(this.BtnZip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button BtnZip;
        private System.Windows.Forms.Button BtnUnzip;

        #endregion
    }
}