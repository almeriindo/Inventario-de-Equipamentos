namespace DetranApp.User_Controls.Cadastro
{
    partial class Fabricante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fabricante));
            this.dg_dados = new System.Windows.Forms.DataGridView();
            this.btn_retornar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_incluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_dados
            // 
            this.dg_dados.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dg_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_dados.Location = new System.Drawing.Point(3, 101);
            this.dg_dados.Name = "dg_dados";
            this.dg_dados.Size = new System.Drawing.Size(644, 396);
            this.dg_dados.TabIndex = 17;
            // 
            // btn_retornar
            // 
            this.btn_retornar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retornar.Image = ((System.Drawing.Image)(resources.GetObject("btn_retornar.Image")));
            this.btn_retornar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_retornar.Location = new System.Drawing.Point(555, 3);
            this.btn_retornar.Name = "btn_retornar";
            this.btn_retornar.Size = new System.Drawing.Size(92, 92);
            this.btn_retornar.TabIndex = 16;
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
            this.btn_imprimir.TabIndex = 15;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_excluir.Location = new System.Drawing.Point(101, 3);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(92, 92);
            this.btn_excluir.TabIndex = 14;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_incluir
            // 
            this.btn_incluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_incluir.Image")));
            this.btn_incluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_incluir.Location = new System.Drawing.Point(3, 3);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(92, 92);
            this.btn_incluir.TabIndex = 13;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_incluir.UseVisualStyleBackColor = true;
            // 
            // Fabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.dg_dados);
            this.Controls.Add(this.btn_retornar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_incluir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Fabricante";
            this.Size = new System.Drawing.Size(650, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_dados;
        private System.Windows.Forms.Button btn_retornar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_incluir;
    }
}
