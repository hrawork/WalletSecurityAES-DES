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
    public partial class DESKeyForm : Form
    {
        public DESKeyForm()
        {
            InitializeComponent();
        }
        public static class GlobalDESKey
        {
            public static string DesKey { get; set; }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtKey.Text.Length == 8)
            {
                GlobalDESKey.DesKey = txtKey.Text;
                FormDES formDes = new FormDES();
                formDes.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("DES key must be exactly 8 characters (64 bits).");
            }
        }
    }
}
