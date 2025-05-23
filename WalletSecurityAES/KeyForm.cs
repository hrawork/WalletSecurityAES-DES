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
    public partial class KeyForm : Form
    {
        public KeyForm()
        {
            InitializeComponent();
        }
        public static class GlobalKey
        {
            public static string AesKey { get; set; }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtKey.Text.Length == 16)
            {
                GlobalKey.AesKey = txtKey.Text;
                Form1 main = new Form1();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("AES key must be exactly 16 characters (128 bits).");
            }
        }
    }
}
