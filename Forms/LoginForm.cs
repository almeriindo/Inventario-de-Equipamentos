using DetranApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetranApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            cb_ambiente.SelectedIndex = 0;
        }

        private void txt_login_TextChanged(object sender, EventArgs e)
        {
            if((txt_login.Text != "") && (txt_senha.Text != "") && (cb_ambiente.Text != "")) {
                btn_ok.Enabled = true;
            }
            else
            {
                btn_ok.Enabled = false;
            }
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            if ((txt_login.Text != "") && (txt_senha.Text != "") && (cb_ambiente.Text != ""))
            {
                btn_ok.Enabled = true;
            }
            else
            {
                btn_ok.Enabled = false;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fPrincipal = new form_principal();
            fPrincipal.Closed += (s, args) => this.Close();
            fPrincipal.Show();
        }
    }
}
