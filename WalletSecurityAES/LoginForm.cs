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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text == "1234")
            {
                AlgorithmSelectionForm algoForm = new AlgorithmSelectionForm();
                algoForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
