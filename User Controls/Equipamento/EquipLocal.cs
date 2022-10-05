using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetranApp.User_Controls.Equipamento
{
    public partial class EquipLocal : UserControl
    {
        private Panel p;
        public EquipLocal(Panel p)
        {
            InitializeComponent();

            this.Top = p.Height / 2 - this.Height / 2;
            this.Left = p.Width / 2 - this.Width / 2;

            this.p = p;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_idEquip.Text = "";
            txt_numSerie.Text = "";
            txt_tombamento.Text = "";
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            p.Controls.Clear();
        }
    }
}
