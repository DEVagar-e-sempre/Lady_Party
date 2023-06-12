namespace LadyParty.WinForms
{
    partial class TelaPrincipalProspostaForm
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
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clientesMenuItem = new ToolStripMenuItem();
            faturasToolStripMenuItem = new ToolStripMenuItem();
            temasMenuItem = new ToolStripMenuItem();
            eventosMenuItem = new ToolStripMenuItem();
            relatoriosToolStripMenuItem = new ToolStripMenuItem();
            tsBarraFerramentas = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnFiltrar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnAdicionarItens = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnConcluirItens = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            labelTipoCadastro = new ToolStripLabel();
            panelRegistros = new Panel();
            statusStripRodape = new StatusStrip();
            labelRodape = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            tsBarraFerramentas.SuspendLayout();
            statusStripRodape.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, relatoriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesMenuItem, temasMenuItem, eventosMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesMenuItem
            // 
            clientesMenuItem.DropDownItems.AddRange(new ToolStripItem[] { faturasToolStripMenuItem });
            clientesMenuItem.Name = "clientesMenuItem";
            clientesMenuItem.Size = new Size(116, 22);
            clientesMenuItem.Text = "Clientes";
            clientesMenuItem.Click += toolStripItem_Click;
            // 
            // faturasToolStripMenuItem
            // 
            faturasToolStripMenuItem.Name = "faturasToolStripMenuItem";
            faturasToolStripMenuItem.Size = new Size(112, 22);
            faturasToolStripMenuItem.Text = "Faturas";
            // 
            // temasMenuItem
            // 
            temasMenuItem.Name = "temasMenuItem";
            temasMenuItem.Size = new Size(116, 22);
            temasMenuItem.Text = "Temas";
            temasMenuItem.Click += toolStripItem_Click;
            // 
            // eventosMenuItem
            // 
            eventosMenuItem.Name = "eventosMenuItem";
            eventosMenuItem.Size = new Size(116, 22);
            eventosMenuItem.Text = "Eventos";
            eventosMenuItem.Click += toolStripItem_Click;
            // 
            // relatoriosToolStripMenuItem
            // 
            relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            relatoriosToolStripMenuItem.Size = new Size(71, 20);
            relatoriosToolStripMenuItem.Text = "Relatórios";
            // 
            // tsBarraFerramentas
            // 
            tsBarraFerramentas.Enabled = false;
            tsBarraFerramentas.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator1, btnFiltrar, toolStripSeparator2, btnAdicionarItens, toolStripSeparator3, btnConcluirItens, toolStripSeparator4, labelTipoCadastro });
            tsBarraFerramentas.Location = new Point(0, 24);
            tsBarraFerramentas.Name = "tsBarraFerramentas";
            tsBarraFerramentas.Size = new Size(800, 45);
            tsBarraFerramentas.TabIndex = 1;
            tsBarraFerramentas.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Image = Properties.Resources.add_circle_FILL0_wght400_GRAD0_opsz24;
            btnInserir.ImageScaling = ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(7);
            btnInserir.Size = new Size(42, 42);
            btnInserir.Text = "Inserir";
            btnInserir.Click += botaoBarraFerramentas_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = Properties.Resources.edit_FILL0_wght400_GRAD0_opsz24;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(7);
            btnEditar.Size = new Size(42, 42);
            btnEditar.Text = "toolStripButton2";
            btnEditar.Click += botaoBarraFerramentas_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = Properties.Resources.delete_forever_FILL0_wght400_GRAD0_opsz24;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(7);
            btnExcluir.Size = new Size(42, 42);
            btnExcluir.Text = "toolStripButton3";
            btnExcluir.Click += botaoBarraFerramentas_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 45);
            // 
            // btnFiltrar
            // 
            btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFiltrar.Image = Properties.Resources.filter_alt_FILL0_wght400_GRAD0_opsz24;
            btnFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Padding = new Padding(7);
            btnFiltrar.Size = new Size(42, 42);
            btnFiltrar.Text = "toolStripButton4";
            btnFiltrar.Click += botaoBarraFerramentas_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 45);
            // 
            // btnAdicionarItens
            // 
            btnAdicionarItens.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionarItens.Image = Properties.Resources.library_add_FILL0_wght400_GRAD0_opsz24;
            btnAdicionarItens.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionarItens.ImageTransparentColor = Color.Magenta;
            btnAdicionarItens.Name = "btnAdicionarItens";
            btnAdicionarItens.Padding = new Padding(7);
            btnAdicionarItens.Size = new Size(42, 42);
            btnAdicionarItens.Text = "toolStripButton5";
            btnAdicionarItens.Click += botaoBarraFerramentas_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 45);
            // 
            // btnConcluirItens
            // 
            btnConcluirItens.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnConcluirItens.Image = Properties.Resources.select_check_box_FILL0_wght400_GRAD0_opsz24;
            btnConcluirItens.ImageScaling = ToolStripItemImageScaling.None;
            btnConcluirItens.ImageTransparentColor = Color.Magenta;
            btnConcluirItens.Name = "btnConcluirItens";
            btnConcluirItens.Padding = new Padding(7);
            btnConcluirItens.Size = new Size(42, 42);
            btnConcluirItens.Text = "toolStripButton6";
            btnConcluirItens.Click += botaoBarraFerramentas_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 45);
            // 
            // labelTipoCadastro
            // 
            labelTipoCadastro.Name = "labelTipoCadastro";
            labelTipoCadastro.Size = new Size(85, 42);
            labelTipoCadastro.Text = "[TipoCadastro]";
            // 
            // panelRegistros
            // 
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 69);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(800, 381);
            panelRegistros.TabIndex = 2;
            // 
            // statusStripRodape
            // 
            statusStripRodape.Items.AddRange(new ToolStripItem[] { labelRodape });
            statusStripRodape.Location = new Point(0, 428);
            statusStripRodape.Name = "statusStripRodape";
            statusStripRodape.Size = new Size(800, 22);
            statusStripRodape.TabIndex = 3;
            statusStripRodape.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            labelRodape.Name = "labelRodape";
            labelRodape.Size = new Size(52, 17);
            labelRodape.Text = "[rodape]";
            // 
            // TelaPrincipalProspostaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStripRodape);
            Controls.Add(panelRegistros);
            Controls.Add(tsBarraFerramentas);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipalProspostaForm";
            Text = "Lady Party";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tsBarraFerramentas.ResumeLayout(false);
            tsBarraFerramentas.PerformLayout();
            statusStripRodape.ResumeLayout(false);
            statusStripRodape.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStrip tsBarraFerramentas;
        private Panel panelRegistros;
        private StatusStrip statusStripRodape;
        private ToolStripMenuItem clientesMenuItem;
        private ToolStripMenuItem faturasToolStripMenuItem;
        private ToolStripMenuItem eventosMenuItem;
        private ToolStripMenuItem temasMenuItem;
        private ToolStripMenuItem relatoriosToolStripMenuItem;
        private ToolStripStatusLabel labelRodape;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnFiltrar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnAdicionarItens;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnConcluirItens;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripLabel labelTipoCadastro;
    }
}