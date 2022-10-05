namespace DetranApp.Forms
{
    partial class uc_b1
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
            this.lb_b1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_b1
            // 
            this.lb_b1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_b1.AutoSize = true;
            this.lb_b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_b1.ForeColor = System.Drawing.SystemColors.Menu;
            this.lb_b1.Location = new System.Drawing.Point(338, 226);
            this.lb_b1.Name = "lb_b1";
            this.lb_b1.Size = new System.Drawing.Size(83, 55);
            this.lb_b1.TabIndex = 0;
            this.lb_b1.Text = "B1";
            this.lb_b1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uc_b1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.Controls.Add(this.lb_b1);
            this.Name = "uc_b1";
            this.Size = new System.Drawing.Size(784, 536);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_b1;
    }
}
