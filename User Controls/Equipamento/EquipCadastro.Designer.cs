namespace DetranApp.User_Controls
{
    partial class EquipCadastro
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipCadastro));
            this.btn_incluir = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_retornar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_equip = new System.Windows.Forms.Button();
            this.lb_baseAtend = new System.Windows.Forms.Label();
            this.lb_setor = new System.Windows.Forms.Label();
            this.lb_subSetor = new System.Windows.Forms.Label();
            this.cb_baseAtend = new System.Windows.Forms.ComboBox();
            this.cb_setor = new System.Windows.Forms.ComboBox();
            this.cb_subSetor = new System.Windows.Forms.ComboBox();
            this.dg_dados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_incluir
            // 
            this.btn_incluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_incluir.Image")));
            this.btn_incluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_incluir.Location = new System.Drawing.Point(3, 3);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(92, 92);
            this.btn_incluir.TabIndex = 0;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_incluir.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_excluir.Location = new System.Drawing.Point(101, 3);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(92, 92);
            this.btn_excluir.TabIndex = 1;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_retornar
            // 
            this.btn_retornar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retornar.Image = ((System.Drawing.Image)(resources.GetObject("btn_retornar.Image")));
            this.btn_retornar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_retornar.Location = new System.Drawing.Point(555, 3);
            this.btn_retornar.Name = "btn_retornar";
            this.btn_retornar.Size = new System.Drawing.Size(92, 92);
            this.btn_retornar.TabIndex = 2;
            this.btn_retornar.Text = "Retornar";
            this.btn_retornar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_retornar.UseVisualStyleBackColor = true;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.Image")));
            this.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_imprimir.Location = new System.Drawing.Point(457, 3);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(92, 92);
            this.btn_imprimir.TabIndex = 3;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_equip
            // 
            this.btn_equip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equip.Image = ((System.Drawing.Image)(resources.GetObject("btn_equip.Image")));
            this.btn_equip.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_equip.Location = new System.Drawing.Point(280, 3);
            this.btn_equip.Name = "btn_equip";
            this.btn_equip.Size = new System.Drawing.Size(92, 92);
            this.btn_equip.TabIndex = 4;
            this.btn_equip.Text = "Equip.";
            this.btn_equip.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_equip.UseVisualStyleBackColor = true;
            // 
            // lb_baseAtend
            // 
            this.lb_baseAtend.AutoSize = true;
            this.lb_baseAtend.Location = new System.Drawing.Point(14, 142);
            this.lb_baseAtend.Name = "lb_baseAtend";
            this.lb_baseAtend.Size = new System.Drawing.Size(80, 13);
            this.lb_baseAtend.TabIndex = 5;
            this.lb_baseAtend.Text = "Base de Atend:";
            // 
            // lb_setor
            // 
            this.lb_setor.AutoSize = true;
            this.lb_setor.Location = new System.Drawing.Point(58, 186);
            this.lb_setor.Name = "lb_setor";
            this.lb_setor.Size = new System.Drawing.Size(35, 13);
            this.lb_setor.TabIndex = 6;
            this.lb_setor.Text = "Setor:";
            // 
            // lb_subSetor
            // 
            this.lb_subSetor.AutoSize = true;
            this.lb_subSetor.Location = new System.Drawing.Point(38, 232);
            this.lb_subSetor.Name = "lb_subSetor";
            this.lb_subSetor.Size = new System.Drawing.Size(57, 13);
            this.lb_subSetor.TabIndex = 7;
            this.lb_subSetor.Text = "Sub-Setor:";
            // 
            // cb_baseAtend
            // 
            this.cb_baseAtend.FormattingEnabled = true;
            this.cb_baseAtend.Location = new System.Drawing.Point(101, 139);
            this.cb_baseAtend.Name = "cb_baseAtend";
            this.cb_baseAtend.Size = new System.Drawing.Size(528, 21);
            this.cb_baseAtend.TabIndex = 8;
            // 
            // cb_setor
            // 
            this.cb_setor.FormattingEnabled = true;
            this.cb_setor.Location = new System.Drawing.Point(101, 183);
            this.cb_setor.Name = "cb_setor";
            this.cb_setor.Size = new System.Drawing.Size(528, 21);
            this.cb_setor.TabIndex = 9;
            // 
            // cb_subSetor
            // 
            this.cb_subSetor.FormattingEnabled = true;
            this.cb_subSetor.Location = new System.Drawing.Point(101, 229);
            this.cb_subSetor.Name = "cb_subSetor";
            this.cb_subSetor.Size = new System.Drawing.Size(528, 21);
            this.cb_subSetor.TabIndex = 10;
            // 
            // dg_dados
            // 
            this.dg_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_dados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_dados.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dg_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_dados.Location = new System.Drawing.Point(3, 256);
            this.dg_dados.Name = "dg_dados";
            this.dg_dados.Size = new System.Drawing.Size(644, 241);
            this.dg_dados.TabIndex = 11;
            // 
            // EquipCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.dg_dados);
            this.Controls.Add(this.cb_subSetor);
            this.Controls.Add(this.cb_setor);
            this.Controls.Add(this.cb_baseAtend);
            this.Controls.Add(this.lb_subSetor);
            this.Controls.Add(this.lb_setor);
            this.Controls.Add(this.lb_baseAtend);
            this.Controls.Add(this.btn_equip);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_retornar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_incluir);
            this.Name = "EquipCadastro";
            this.Size = new System.Drawing.Size(650, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_retornar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_equip;
        private System.Windows.Forms.Label lb_baseAtend;
        private System.Windows.Forms.Label lb_setor;
        private System.Windows.Forms.Label lb_subSetor;
        private System.Windows.Forms.ComboBox cb_baseAtend;
        private System.Windows.Forms.ComboBox cb_setor;
        private System.Windows.Forms.ComboBox cb_subSetor;
        private System.Windows.Forms.DataGridView dg_dados;
    }
}
