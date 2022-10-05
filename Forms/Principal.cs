using DetranApp.User_Controls;
using DetranApp.User_Controls.Cadastro;
using DetranApp.User_Controls.Equipamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetranApp.Forms
{
    public partial class form_principal : Form
    {
        private ToolStripMenuItem itemDisabled;
        public form_principal()
        {
            InitializeComponent();
            itemDisabled = null;
        }

        private void item_cadastro_Click(object sender, EventArgs e)
        {
            DisableItem(item_cadastro);

            panel_principal.Controls.Clear();
            panel_principal.Controls.Add(new EquipCadastro(panel_principal));
        }

        private void item_localEquipamento_Click(object sender, EventArgs e)
        {
            DisableItem(item_localEquipamento);

            panel_principal.Controls.Clear();
            panel_principal.Controls.Add(new EquipLocal(panel_principal));
        }

        private void itemPrincipal_sair_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Você quer mesmo sair?", "Confirmar ´saída", MessageBoxButtons.OKCancel);

            if (confirmResult == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                //Não fecha o programa.
            }
        }

        private void item_grupoSetor_Click(object sender, EventArgs e)
        {
            DisableItem(item_grupoSetor);

            panel_principal.Controls.Clear();
            panel_principal.Controls.Add(new GrupoSetor(panel_principal));
        }

        private void item_baseAtendimento_Click(object sender, EventArgs e)
        {
            DisableItem(item_baseAtendimento);

            panel_principal.Controls.Clear();
            panel_principal.Controls.Add(new BaseDeAtendimento(panel_principal));
        }

        private void item_setor_Click(object sender, EventArgs e)
        {
            DisableItem(item_setor);

            panel_principal.Controls.Clear();
            panel_principal.Controls.Add(new Setor(panel_principal));
        }

        private void item_subSetor_Click(object sender, EventArgs e)
        {
            DisableItem(item_subSetor);
        }

        private void item_fabricante_Click(object sender, EventArgs e)
        {
            DisableItem(item_fabricante);

            panel_principal.Controls.Clear();
            panel_principal.Controls.Add(new Fabricante(panel_principal));
        }

        private void item_fornecedor_Click(object sender, EventArgs e)
        {
            DisableItem(item_fornecedor);
        }

        private void item_cargo_Click(object sender, EventArgs e)
        {
            DisableItem(item_cargo);
        }

        private void item_ferias_Click(object sender, EventArgs e)
        {
            DisableItem(item_ferias);
        }

        private void item_funcao_Click(object sender, EventArgs e)
        {
            DisableItem(item_funcao);
        }

        private void item_funcionario_Click(object sender, EventArgs e)
        {
            DisableItem(item_funcionario);
        }

        private void item_tipoServico_Click(object sender, EventArgs e)
        {
            DisableItem(item_tipoServico);
        }

        private void item_servico_Click(object sender, EventArgs e)
        {
            DisableItem(item_servico);
        }

        private void item_itensEquipamento_Click(object sender, EventArgs e)
        {
            DisableItem(item_itensEquipamento);
        }

        private void item_tiposEquipamento_Click(object sender, EventArgs e)
        {
            DisableItem(item_tiposEquipamento);
        }

        private void item_modeloEquip_Click(object sender, EventArgs e)
        {
            DisableItem(item_modeloEquip);
        }

        private void subitem_sitChamado_Click(object sender, EventArgs e)
        {
            DisableItem(subitem_sitChamado);
        }

        private void subitem_sitEquipamento_Click(object sender, EventArgs e)
        {
            DisableItem(subitem_sitEquipamento);
        }

        private void subitem_sitFuncionario_Click(object sender, EventArgs e)
        {
            DisableItem(subitem_sitFuncionario);
        }

        private void subitem_sitOrdemServico_Click(object sender, EventArgs e)
        {
            DisableItem(subitem_sitOrdemServico);
        }

        private void item_movEquipamento_Click(object sender, EventArgs e)
        {
            DisableItem(item_movEquipamento);
        }

        private void item_chamadoAssistTecnica_Click(object sender, EventArgs e)
        {
            DisableItem(item_chamadoAssistTecnica);
        }

        private void localidade_analitico_Click(object sender, EventArgs e)
        {
            DisableItem(localidade_analitico);
        }

        private void localidade_sintetico_Click(object sender, EventArgs e)
        {
            DisableItem(localidade_sintetico);
        }

        private void subitem_tipoServico_Click(object sender, EventArgs e)
        {
            DisableItem(subitem_tipoServico);
        }

        private void subitem_sintetico_Click(object sender, EventArgs e)
        {
            DisableItem(subitem_sintetico);
        }

        private void equipLocalidade_analitico_Click(object sender, EventArgs e)
        {
            DisableItem(equipLocalidade_analitico);
        }

        private void equipLocalidade_sintetico_Click(object sender, EventArgs e)
        {
            DisableItem(equipLocalidade_sintetico);
        }

        private void item_movPeriodo_Click(object sender, EventArgs e)
        {
            DisableItem(item_movPeriodo);
        }

        private void DisableItem(ToolStripMenuItem itemToDisable)
        {
            if (itemDisabled == null)
            {
                itemDisabled = itemToDisable;
                itemDisabled.Enabled = false;
            }
            else if (itemDisabled != itemToDisable)
            {
                itemDisabled.Enabled = true;
                itemDisabled = itemToDisable;
                itemDisabled.Enabled = false;
            }
        }
    }
}
