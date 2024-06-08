namespace CursoWindowsForms
{
    partial class Frm_Principal_Menu_UC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal_Menu_UC));
			this.Mnu_Principal = new System.Windows.Forms.MenuStrip();
			this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.demosntraçãoKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helloWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mascaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.valídaCPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.valídaCPF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.valídaSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.apagarAbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.byteBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.acoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.abrirImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.windowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Tbc_Aplicacoes = new System.Windows.Forms.TabControl();
			this.Iml_Imagens = new System.Windows.Forms.ImageList(this.components);
			this.agênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Mnu_Principal.SuspendLayout();
			this.SuspendLayout();
			// 
			// Mnu_Principal
			// 
			this.Mnu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.byteBankToolStripMenuItem,
            this.acoesToolStripMenuItem,
            this.windowaToolStripMenuItem});
			this.Mnu_Principal.Location = new System.Drawing.Point(0, 0);
			this.Mnu_Principal.Name = "Mnu_Principal";
			this.Mnu_Principal.Size = new System.Drawing.Size(800, 24);
			this.Mnu_Principal.TabIndex = 0;
			this.Mnu_Principal.Text = "menuStrip1";
			// 
			// arquivoToolStripMenuItem
			// 
			this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.desconectarToolStripMenuItem,
            this.novoToolStripMenuItem,
            this.apagarAbaToolStripMenuItem,
            this.sairToolStripMenuItem});
			this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
			this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.arquivoToolStripMenuItem.Text = "Arquivo";
			// 
			// conectarToolStripMenuItem
			// 
			this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
			this.conectarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.conectarToolStripMenuItem.Text = "Conectar";
			this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
			// 
			// desconectarToolStripMenuItem
			// 
			this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
			this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.desconectarToolStripMenuItem.Text = "Desconectar";
			this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
			// 
			// novoToolStripMenuItem
			// 
			this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demosntraçãoKeyToolStripMenuItem,
            this.helloWorldToolStripMenuItem,
            this.mascaraToolStripMenuItem,
            this.valídaCPFToolStripMenuItem,
            this.valídaCPF2ToolStripMenuItem,
            this.valídaSenhaToolStripMenuItem});
			this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
			this.novoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.novoToolStripMenuItem.Text = "Novo";
			// 
			// demosntraçãoKeyToolStripMenuItem
			// 
			this.demosntraçãoKeyToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_DemonstracaoKey;
			this.demosntraçãoKeyToolStripMenuItem.Name = "demosntraçãoKeyToolStripMenuItem";
			this.demosntraçãoKeyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
			this.demosntraçãoKeyToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.demosntraçãoKeyToolStripMenuItem.Text = "Demosntração &Key";
			this.demosntraçãoKeyToolStripMenuItem.Click += new System.EventHandler(this.demosntracaoKeyToolStripMenuItem_Click);
			// 
			// helloWorldToolStripMenuItem
			// 
			this.helloWorldToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_HelloWorld;
			this.helloWorldToolStripMenuItem.Name = "helloWorldToolStripMenuItem";
			this.helloWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
			this.helloWorldToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.helloWorldToolStripMenuItem.Text = "Hello &World";
			this.helloWorldToolStripMenuItem.Click += new System.EventHandler(this.helloWorldToolStripMenuItem_Click);
			// 
			// mascaraToolStripMenuItem
			// 
			this.mascaraToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_Mascara;
			this.mascaraToolStripMenuItem.Name = "mascaraToolStripMenuItem";
			this.mascaraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
			this.mascaraToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.mascaraToolStripMenuItem.Text = "&Mascara";
			this.mascaraToolStripMenuItem.Click += new System.EventHandler(this.mascaraToolStripMenuItem_Click);
			// 
			// valídaCPFToolStripMenuItem
			// 
			this.valídaCPFToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_ValidaCPF;
			this.valídaCPFToolStripMenuItem.Name = "valídaCPFToolStripMenuItem";
			this.valídaCPFToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
			this.valídaCPFToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.valídaCPFToolStripMenuItem.Text = "Valída &CPF";
			this.valídaCPFToolStripMenuItem.Click += new System.EventHandler(this.valídaCPFToolStripMenuItem_Click);
			// 
			// valídaCPF2ToolStripMenuItem
			// 
			this.valídaCPF2ToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_ValidaCPF2;
			this.valídaCPF2ToolStripMenuItem.Name = "valídaCPF2ToolStripMenuItem";
			this.valídaCPF2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
			this.valídaCPF2ToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.valídaCPF2ToolStripMenuItem.Text = "Valída C&PF2";
			this.valídaCPF2ToolStripMenuItem.Click += new System.EventHandler(this.valídaCPF2ToolStripMenuItem_Click);
			// 
			// valídaSenhaToolStripMenuItem
			// 
			this.valídaSenhaToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_ValidaSenha;
			this.valídaSenhaToolStripMenuItem.Name = "valídaSenhaToolStripMenuItem";
			this.valídaSenhaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
			this.valídaSenhaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.valídaSenhaToolStripMenuItem.Text = "Valída &Senha";
			this.valídaSenhaToolStripMenuItem.Click += new System.EventHandler(this.valídaSenhaToolStripMenuItem_Click);
			// 
			// apagarAbaToolStripMenuItem
			// 
			this.apagarAbaToolStripMenuItem.Name = "apagarAbaToolStripMenuItem";
			this.apagarAbaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.apagarAbaToolStripMenuItem.Text = "Apagar Aba";
			this.apagarAbaToolStripMenuItem.Click += new System.EventHandler(this.apagarAbaToolStripMenuItem_Click);
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
			// 
			// byteBankToolStripMenuItem
			// 
			this.byteBankToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
			this.byteBankToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.money;
			this.byteBankToolStripMenuItem.Name = "byteBankToolStripMenuItem";
			this.byteBankToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
			this.byteBankToolStripMenuItem.Text = "ByteBank";
			// 
			// cadastrosToolStripMenuItem
			// 
			this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.agênciaToolStripMenuItem});
			this.cadastrosToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Cadastros;
			this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
			this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.cadastrosToolStripMenuItem.Text = "Cadastros";
			// 
			// clientesToolStripMenuItem
			// 
			this.clientesToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.user;
			this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.clientesToolStripMenuItem.Text = "Clientes";
			this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
			// 
			// acoesToolStripMenuItem
			// 
			this.acoesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagemToolStripMenuItem});
			this.acoesToolStripMenuItem.Name = "acoesToolStripMenuItem";
			this.acoesToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.acoesToolStripMenuItem.Text = "Ações";
			// 
			// abrirImagemToolStripMenuItem
			// 
			this.abrirImagemToolStripMenuItem.Name = "abrirImagemToolStripMenuItem";
			this.abrirImagemToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.abrirImagemToolStripMenuItem.Text = "Abrir Imagem";
			this.abrirImagemToolStripMenuItem.Click += new System.EventHandler(this.abrirImagemToolStripMenuItem_Click);
			// 
			// windowaToolStripMenuItem
			// 
			this.windowaToolStripMenuItem.Name = "windowaToolStripMenuItem";
			this.windowaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.windowaToolStripMenuItem.Text = "Windowa";
			// 
			// Tbc_Aplicacoes
			// 
			this.Tbc_Aplicacoes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Tbc_Aplicacoes.ImageList = this.Iml_Imagens;
			this.Tbc_Aplicacoes.Location = new System.Drawing.Point(0, 24);
			this.Tbc_Aplicacoes.Name = "Tbc_Aplicacoes";
			this.Tbc_Aplicacoes.SelectedIndex = 0;
			this.Tbc_Aplicacoes.Size = new System.Drawing.Size(800, 587);
			this.Tbc_Aplicacoes.TabIndex = 1;
			this.Tbc_Aplicacoes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tbc_Aplicacoes_MouseDown);
			// 
			// Iml_Imagens
			// 
			this.Iml_Imagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Iml_Imagens.ImageStream")));
			this.Iml_Imagens.TransparentColor = System.Drawing.Color.Transparent;
			this.Iml_Imagens.Images.SetKeyName(0, "Frm_DemonstracaoKey.png");
			this.Iml_Imagens.Images.SetKeyName(1, "Frm_HelloWorld.png");
			this.Iml_Imagens.Images.SetKeyName(2, "Frm_Mascara.png");
			this.Iml_Imagens.Images.SetKeyName(3, "Frm_ValidaCPF.png");
			this.Iml_Imagens.Images.SetKeyName(4, "Frm_ValidaCPF2.png");
			this.Iml_Imagens.Images.SetKeyName(5, "Frm_ValidaSenha.png");
			this.Iml_Imagens.Images.SetKeyName(6, "icons8-folder-94.png");
			this.Iml_Imagens.Images.SetKeyName(7, "user.png");
			// 
			// agênciaToolStripMenuItem
			// 
			this.agênciaToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.money;
			this.agênciaToolStripMenuItem.Name = "agênciaToolStripMenuItem";
			this.agênciaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.agênciaToolStripMenuItem.Text = "Agência";
			this.agênciaToolStripMenuItem.Click += new System.EventHandler(this.agênciaToolStripMenuItem_Click);
			// 
			// Frm_Principal_Menu_UC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 611);
			this.Controls.Add(this.Tbc_Aplicacoes);
			this.Controls.Add(this.Mnu_Principal);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.Mnu_Principal;
			this.Name = "Frm_Principal_Menu_UC";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Principal";
			this.Mnu_Principal.ResumeLayout(false);
			this.Mnu_Principal.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mnu_Principal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demosntraçãoKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mascaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valídaCPFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valídaCPF2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valídaSenhaToolStripMenuItem;
        private System.Windows.Forms.TabControl Tbc_Aplicacoes;
        private System.Windows.Forms.ImageList Iml_Imagens;
        private System.Windows.Forms.ToolStripMenuItem apagarAbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem byteBankToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agênciaToolStripMenuItem;
	}
}