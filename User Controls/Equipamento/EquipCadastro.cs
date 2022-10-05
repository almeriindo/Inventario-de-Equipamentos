using DetranApp.DB;
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

namespace DetranApp.User_Controls
{
    public partial class EquipCadastro : UserControl
    {
        private List<EquipamentoTeste> equip;
        private MongoDBConnection db = new MongoDBConnection();
        public EquipCadastro(Panel p)
        {
            InitializeComponent();

            this.Top = p.Height / 2 - this.Height / 2;
            this.Left = p.Width / 2 - this.Width / 2;

            equip = this.Populacionar();

            dg_dados.DataSource = equip;

            //db.printDbs();
        }

        private List<EquipamentoTeste> Populacionar()
        {
            var l = new List<EquipamentoTeste>();

            l.Add(new EquipamentoTeste()
            {
                IdEquip = 1,
                TipoEquipamento = "ccccc ccccc",
                ModeloEquipamento = "Modelo A"
            });
            l.Add(new EquipamentoTeste()
            {
                IdEquip = 2,
                TipoEquipamento = "dddddd dd",
                ModeloEquipamento = "Modelo B"
            });
            l.Add(new EquipamentoTeste()
            {
                IdEquip = 3,
                TipoEquipamento = "eeeeeeeeeeeeeee",
                ModeloEquipamento = "Modelo C"
            });

            return l;

        }
    }




}
