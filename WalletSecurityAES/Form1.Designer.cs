namespace WalletSecurityAES
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
            this.lblPlainText = new System.Windows.Forms.Label();
            this.lblEncryptedText = new System.Windows.Forms.Label();
            this.lblDecryptedText = new System.Windows.Forms.Label();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.txtEncryptedText = new System.Windows.Forms.TextBox();
            this.txtDecryptedText = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnToBinary = new System.Windows.Forms.Button();
            this.btnToDecimal = new System.Windows.Forms.Button();
            this.btnToHex = new System.Windows.Forms.Button();
            this.lstProcessLog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEncryptedText = new System.Windows.Forms.CheckBox();
            this.chkDecryptedText = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblPlainText
            // 
            this.lblPlainText.AutoSize = true;
            this.lblPlainText.Location = new System.Drawing.Point(39, 85);
            this.lblPlainText.Name = "lblPlainText";
            this.lblPlainText.Size = new System.Drawing.Size(85, 20);
            this.lblPlainText.TabIndex = 0;
            this.lblPlainText.Text = "Plain Text :";
            // 
            // lblEncryptedText
            // 
            this.lblEncryptedText.AutoSize = true;
            this.lblEncryptedText.Location = new System.Drawing.Point(39, 149);
            this.lblEncryptedText.Name = "lblEncryptedText";
            this.lblEncryptedText.Size = new System.Drawing.Size(123, 20);
            this.lblEncryptedText.TabIndex = 1;
            this.lblEncryptedText.Text = "Encrypted Text :";
            // 
            // lblDecryptedText
            // 
            this.lblDecryptedText.AutoSize = true;
            this.lblDecryptedText.Location = new System.Drawing.Point(38, 246);
            this.lblDecryptedText.Name = "lblDecryptedText";
            this.lblDecryptedText.Size = new System.Drawing.Size(124, 20);
            this.lblDecryptedText.TabIndex = 2;
            this.lblDecryptedText.Text = "Decrypted Text :";
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(168, 85);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(316, 26);
            this.txtPlainText.TabIndex = 3;
            // 
            // txtEncryptedText
            // 
            this.txtEncryptedText.Location = new System.Drawing.Point(168, 146);
            this.txtEncryptedText.Multiline = true;
            this.txtEncryptedText.Name = "txtEncryptedText";
            this.txtEncryptedText.Size = new System.Drawing.Size(316, 26);
            this.txtEncryptedText.TabIndex = 4;
            // 
            // txtDecryptedText
            // 
            this.txtDecryptedText.Location = new System.Drawing.Point(168, 243);
            this.txtDecryptedText.Multiline = true;
            this.txtDecryptedText.Name = "txtDecryptedText";
            this.txtDecryptedText.ReadOnly = true;
            this.txtDecryptedText.Size = new System.Drawing.Size(316, 26);
            this.txtDecryptedText.TabIndex = 5;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(515, 59);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(128, 67);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(515, 164);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(128, 76);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnToBinary
            // 
            this.btnToBinary.Location = new System.Drawing.Point(40, 300);
            this.btnToBinary.Name = "btnToBinary";
            this.btnToBinary.Size = new System.Drawing.Size(207, 50);
            this.btnToBinary.TabIndex = 8;
            this.btnToBinary.Text = "Convert to Binary";
            this.btnToBinary.UseVisualStyleBackColor = true;
            this.btnToBinary.Click += new System.EventHandler(this.btnToBinary_Click);
            // 
            // btnToDecimal
            // 
            this.btnToDecimal.Location = new System.Drawing.Point(282, 300);
            this.btnToDecimal.Name = "btnToDecimal";
            this.btnToDecimal.Size = new System.Drawing.Size(202, 50);
            this.btnToDecimal.TabIndex = 9;
            this.btnToDecimal.Text = "Convert to Decimal";
            this.btnToDecimal.UseVisualStyleBackColor = true;
            this.btnToDecimal.Click += new System.EventHandler(this.btnToDecimal_Click);
            // 
            // btnToHex
            // 
            this.btnToHex.Location = new System.Drawing.Point(515, 300);
            this.btnToHex.Name = "btnToHex";
            this.btnToHex.Size = new System.Drawing.Size(216, 50);
            this.btnToHex.TabIndex = 10;
            this.btnToHex.Text = "Convert to Hexadecimal";
            this.btnToHex.UseVisualStyleBackColor = true;
            this.btnToHex.Click += new System.EventHandler(this.btnToHex_Click);
            // 
            // lstProcessLog
            // 
            this.lstProcessLog.FormattingEnabled = true;
            this.lstProcessLog.ItemHeight = 20;
            this.lstProcessLog.Location = new System.Drawing.Point(40, 401);
            this.lstProcessLog.Name = "lstProcessLog";
            this.lstProcessLog.Size = new System.Drawing.Size(691, 164);
            this.lstProcessLog.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Paste Base64 Cipher Text here for manual decryption.\n\n";
            // 
            // chkEncryptedText
            // 
            this.chkEncryptedText.AutoSize = true;
            this.chkEncryptedText.Location = new System.Drawing.Point(43, 371);
            this.chkEncryptedText.Name = "chkEncryptedText";
            this.chkEncryptedText.Size = new System.Drawing.Size(174, 24);
            this.chkEncryptedText.TabIndex = 13;
            this.chkEncryptedText.Text = "Use Encrypted Text";
            this.chkEncryptedText.UseVisualStyleBackColor = true;
            // 
            // chkDecryptedText
            // 
            this.chkDecryptedText.AutoSize = true;
            this.chkDecryptedText.Location = new System.Drawing.Point(252, 371);
            this.chkDecryptedText.Name = "chkDecryptedText";
            this.chkDecryptedText.Size = new System.Drawing.Size(175, 24);
            this.chkDecryptedText.TabIndex = 14;
            this.chkDecryptedText.Text = "Use Decrypted Text";
            this.chkDecryptedText.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 595);
            this.Controls.Add(this.chkDecryptedText);
            this.Controls.Add(this.chkEncryptedText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProcessLog);
            this.Controls.Add(this.btnToHex);
            this.Controls.Add(this.btnToDecimal);
            this.Controls.Add(this.btnToBinary);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtDecryptedText);
            this.Controls.Add(this.txtEncryptedText);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.lblDecryptedText);
            this.Controls.Add(this.lblEncryptedText);
            this.Controls.Add(this.lblPlainText);
            this.Name = "Form1";
            this.Text = "WalletSecurityAES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlainText;
        private System.Windows.Forms.Label lblEncryptedText;
        private System.Windows.Forms.Label lblDecryptedText;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.TextBox txtEncryptedText;
        private System.Windows.Forms.TextBox txtDecryptedText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnToBinary;
        private System.Windows.Forms.Button btnToDecimal;
        private System.Windows.Forms.Button btnToHex;
        private System.Windows.Forms.ListBox lstProcessLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkEncryptedText;
        private System.Windows.Forms.CheckBox chkDecryptedText;
    }
}

