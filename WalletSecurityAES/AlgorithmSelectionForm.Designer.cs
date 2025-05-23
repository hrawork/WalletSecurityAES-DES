namespace WalletSecurityAES
{
    partial class AlgorithmSelectionForm
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
            this.btnAES = new System.Windows.Forms.Button();
            this.btnDES = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAES
            // 
            this.btnAES.Location = new System.Drawing.Point(93, 154);
            this.btnAES.Name = "btnAES";
            this.btnAES.Size = new System.Drawing.Size(184, 82);
            this.btnAES.TabIndex = 0;
            this.btnAES.Text = "AES";
            this.btnAES.UseVisualStyleBackColor = true;
            this.btnAES.Click += new System.EventHandler(this.btnAES_Click);
            // 
            // btnDES
            // 
            this.btnDES.Location = new System.Drawing.Point(483, 154);
            this.btnDES.Name = "btnDES";
            this.btnDES.Size = new System.Drawing.Size(184, 82);
            this.btnDES.TabIndex = 1;
            this.btnDES.Text = "DES";
            this.btnDES.UseVisualStyleBackColor = true;
            this.btnDES.Click += new System.EventHandler(this.btnDES_Click);
            // 
            // AlgorithmSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDES);
            this.Controls.Add(this.btnAES);
            this.Name = "AlgorithmSelectionForm";
            this.Text = "AlgorithmSelectionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAES;
        private System.Windows.Forms.Button btnDES;
    }
}