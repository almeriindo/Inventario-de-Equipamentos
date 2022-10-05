using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetranApp.User_Controls.Cadastro
{
    public partial class Fabricante : UserControl
    {
        public Fabricante(Panel p)
        {
            InitializeComponent();

            this.Top = p.Height / 2 - this.Height / 2;
            this.Left = p.Width / 2 - this.Width / 2;
        }
    }
}
