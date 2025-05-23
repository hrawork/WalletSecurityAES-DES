using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalletSecurityAES
{
    public partial class FormDES : Form
    {
        public FormDES()
        {
            InitializeComponent();
        }
        private string GetSelectedTextForConversion()
        {
            if (chkEncryptedText.Checked)
                return txtEncryptedText.Text;
            else if (chkDecryptedText.Checked)
                return txtDecryptedText.Text;
            else
                return txtPlainText.Text;
        }
        private string ConvertToBinary(string input)
        {
            StringBuilder binary = new StringBuilder();
            foreach (char c in input)
                binary.Append(Convert.ToString(c, 2).PadLeft(8, '0') + " ");
            return binary.ToString();
        }
        private string ConvertToDecimal(string input)
        {
            StringBuilder decimalVal = new StringBuilder();
            foreach (char c in input)
                decimalVal.Append(((int)c).ToString() + " ");
            return decimalVal.ToString();
        }

        private string ConvertToHex(string input)
        {
            StringBuilder hex = new StringBuilder();
            foreach (char c in input)
                hex.Append(((int)c).ToString("X2") + " ");
            return hex.ToString();
        }
        private string ConvertBase64ToHex(string base64Input)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(base64Input);
                StringBuilder hex = new StringBuilder();
                foreach (byte b in bytes)
                    hex.Append(b.ToString("X2") + " ");
                return hex.ToString();
            }
            catch
            {
                return "Invalid Base64 string.";
            }
        }
        private void btnToBinary_Click(object sender, EventArgs e)
        {
            string textToConvert = GetSelectedTextForConversion();
            if (string.IsNullOrWhiteSpace(textToConvert))
            {
                MessageBox.Show("No input available to convert.");
                return;
            }
            string binary = ConvertToBinary(textToConvert);
            lstProcessLog.Items.Add("Binary: " + binary);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlainText.Text))
            {
                MessageBox.Show("Please enter text to encrypt.");
                return;
            }
            string encrypted = DESHelper.Encrypt(txtPlainText.Text);
            txtEncryptedText.Text = encrypted;
            lstProcessLog.Items.Add("Encrypted: " + encrypted);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DESKeyForm.GlobalDESKey.DesKey) || DESKeyForm.GlobalDESKey.DesKey.Length != 8)
            {
                MessageBox.Show("Invalid DES Key. Please enter a valid 8-character key.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEncryptedText.Text))
            {
                MessageBox.Show("Cipher text is empty. Please paste a valid cipher.");
                return;
            }
            string decryptedText = DESHelper.Decrypt(txtEncryptedText.Text.Trim());
            txtDecryptedText.Text = decryptedText;
        }

        private void btnToDecimal_Click(object sender, EventArgs e)
        {
            string textToConvert = GetSelectedTextForConversion();
            if (string.IsNullOrWhiteSpace(textToConvert))
            {
                MessageBox.Show("No input available to convert.");
                return;
            }
            string decimalVal = ConvertToDecimal(textToConvert);
            lstProcessLog.Items.Add("Decimal: " + decimalVal);
        }

        private void btnToHex_Click(object sender, EventArgs e)
        {
            string textToConvert = GetSelectedTextForConversion();
            if (string.IsNullOrWhiteSpace(textToConvert))
            {
                MessageBox.Show("No input available to convert.");
                return;
            }

            string hexResult = chkEncryptedText.Checked ? ConvertBase64ToHex(textToConvert) : ConvertToHex(textToConvert);
            lstProcessLog.Items.Add("Hexadecimal: " + hexResult);
        }
    }
}
