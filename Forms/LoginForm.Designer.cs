namespace DetranApp
{
    partial class LoginForm
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DetranLogo = new System.Windows.Forms.PictureBox();
            this.gb_dados = new System.Windows.Forms.GroupBox();
            this.cb_ambiente = new System.Windows.Forms.ComboBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.panel_container = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_dataVersao = new System.Windows.Forms.Label();
            this.lb_controleVeiculos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DetranLogo)).BeginInit();
            this.gb_dados.SuspendLayout();
            this.panel_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetranLogo
            // 
            this.DetranLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DetranLogo.ImageLocation = "C:\\Users\\almerindo.neto\\Desktop\\Images\\detran-logo.png";
            this.DetranLogo.InitialImage = null;
            this.DetranLogo.Location = new System.Drawing.Point(55, 65);
            this.DetranLogo.MaximumSize = new System.Drawing.Size(275, 117);
            this.DetranLogo.MinimumSize = new System.Drawing.Size(275, 117);
            this.DetranLogo.Name = "DetranLogo";
            this.DetranLogo.Size = new System.Drawing.Size(275, 117);
            this.DetranLogo.TabIndex = 0;
            this.DetranLogo.TabStop = false;
            // 
            // gb_dados
            // 
            this.gb_dados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_dados.BackColor = System.Drawing.Color.Transparent;
            this.gb_dados.Controls.Add(this.cb_ambiente);
            this.gb_dados.Controls.Add(this.txt_senha);
            this.gb_dados.Controls.Add(this.txt_login);
            this.gb_dados.Controls.Add(this.label1);
            this.gb_dados.Controls.Add(this.lb_senha);
            this.gb_dados.Controls.Add(this.lb_login);
            this.gb_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gb_dados.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gb_dados.Location = new System.Drawing.Point(341, 61);
            this.gb_dados.MaximumSize = new System.Drawing.Size(200, 181);
            this.gb_dados.MinimumSize = new System.Drawing.Size(200, 181);
            this.gb_dados.Name = "gb_dados";
            this.gb_dados.Size = new System.Drawing.Size(200, 181);
            this.gb_dados.TabIndex = 1;
            this.gb_dados.TabStop = false;
            this.gb_dados.Text = "Dados";
            // 
            // cb_ambiente
            // 
            this.cb_ambiente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ambiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ambiente.FormattingEnabled = true;
            this.cb_ambiente.Items.AddRange(new object[] {
            "DESENVOLVIMENTO",
            "HOMOLOGAÇÃO",
            "PRODUÇÃO"});
            this.cb_ambiente.Location = new System.Drawing.Point(20, 132);
            this.cb_ambiente.Name = "cb_ambiente";
            this.cb_ambiente.Size = new System.Drawing.Size(161, 24);
            this.cb_ambiente.TabIndex = 7;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(20, 89);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(161, 20);
            this.txt_senha.TabIndex = 6;
            this.txt_senha.UseSystemPasswordChar = true;
            this.txt_senha.TextChanged += new System.EventHandler(this.txt_senha_TextChanged);
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(20, 48);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(161, 20);
            this.txt_login.TabIndex = 5;
            this.txt_login.TextChanged += new System.EventHandler(this.txt_login_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(20, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ambiente:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lb_senha.Location = new System.Drawing.Point(17, 69);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(53, 17);
            this.lb_senha.TabIndex = 3;
            this.lb_senha.Text = "Senha:";
            this.lb_senha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.Location = new System.Drawing.Point(17, 29);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(43, 16);
            this.lb_login.TabIndex = 2;
            this.lb_login.Text = "Login:";
            this.lb_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_container
            // 
            this.panel_container.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_container.BackColor = System.Drawing.Color.Transparent;
            this.panel_container.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_container.Controls.Add(this.btn_cancelar);
            this.panel_container.Controls.Add(this.btn_ok);
            this.panel_container.Controls.Add(this.lb_data);
            this.panel_container.Controls.Add(this.lb_dataVersao);
            this.panel_container.Controls.Add(this.lb_controleVeiculos);
            this.panel_container.Controls.Add(this.DetranLogo);
            this.panel_container.Controls.Add(this.gb_dados);
            this.panel_container.Location = new System.Drawing.Point(100, 120);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(600, 300);
            this.panel_container.TabIndex = 2;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_cancelar.Location = new System.Drawing.Point(444, 248);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(102, 23);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Enabled = false;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.btn_ok.Location = new System.Drawing.Point(336, 248);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(102, 23);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.ForeColor = System.Drawing.Color.SandyBrown;
            this.lb_data.Location = new System.Drawing.Point(138, 222);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(61, 13);
            this.lb_data.TabIndex = 4;
            this.lb_data.Text = "00-00-0000";
            // 
            // lb_dataVersao
            // 
            this.lb_dataVersao.AutoSize = true;
            this.lb_dataVersao.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lb_dataVersao.Location = new System.Drawing.Point(52, 222);
            this.lb_dataVersao.Name = "lb_dataVersao";
            this.lb_dataVersao.Size = new System.Drawing.Size(84, 13);
            this.lb_dataVersao.TabIndex = 3;
            this.lb_dataVersao.Text = "Data de Versão:";
            // 
            // lb_controleVeiculos
            // 
            this.lb_controleVeiculos.AutoSize = true;
            this.lb_controleVeiculos.BackColor = System.Drawing.Color.Transparent;
            this.lb_controleVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lb_controleVeiculos.ForeColor = System.Drawing.Color.SandyBrown;
            this.lb_controleVeiculos.Location = new System.Drawing.Point(52, 189);
            this.lb_controleVeiculos.Name = "lb_controleVeiculos";
            this.lb_controleVeiculos.Size = new System.Drawing.Size(138, 17);
            this.lb_controleVeiculos.TabIndex = 2;
            this.lb_controleVeiculos.Text = "Controle de Veículos";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel_container);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DETRAN - Identificação de Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.DetranLogo)).EndInit();
            this.gb_dados.ResumeLayout(false);
            this.gb_dados.PerformLayout();
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DetranLogo;
        private System.Windows.Forms.GroupBox gb_dados;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_ambiente;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label lb_dataVersao;
        private System.Windows.Forms.Label lb_controleVeiculos;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_ok;
    }
}

