using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WalletSecurityAES.KeyForm;

namespace WalletSecurityAES
{
    public partial class Form1 : Form
    {
        public Form1()
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
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPlainText.Text))
                {
                    MessageBox.Show("Please enter text to encrypt.");
                    return;
                }

                string encrypted = AESHelper.Encrypt(txtPlainText.Text);
                txtEncryptedText.Text = encrypted;
                lstProcessLog.Items.Add($"Encrypted: {encrypted}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption error: " + ex.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string cipherTextBase64 = txtEncryptedText.Text.Trim();

            if (string.IsNullOrEmpty(GlobalKey.AesKey) || GlobalKey.AesKey.Length != 16)
            {
                MessageBox.Show("Invalid AES Key. Please enter a valid 16-character key.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cipherTextBase64))
            {
                MessageBox.Show("Cipher text is empty. Please paste a valid cipher.");
                return;
            }

            try
            {
                string decryptedText = AESHelper.Decrypt(cipherTextBase64);
                txtDecryptedText.Text = decryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Decryption failed: " + ex.Message);
            }

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

            string hexResult;

            if (chkEncryptedText.Checked)
                hexResult = ConvertBase64ToHex(textToConvert);
            else
                hexResult = ConvertToHex(textToConvert);

            lstProcessLog.Items.Add("Hexadecimal: " + hexResult);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
