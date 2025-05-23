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
    public partial class AlgorithmSelectionForm : Form
    {
        public AlgorithmSelectionForm()
        {
            InitializeComponent();
        }

        private void btnDES_Click(object sender, EventArgs e)
        {
            DESKeyForm desKeyForm = new DESKeyForm();
            desKeyForm.Show();
            this.Hide();
        }

        private void btnAES_Click(object sender, EventArgs e)
        {
            KeyForm aesKeyForm = new KeyForm();
            aesKeyForm.Show();
            this.Hide();
        }
    }
}
