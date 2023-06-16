namespace LadyParty.WinForms
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            statusStrip1 = new StatusStrip();
            lbl_status = new ToolStripStatusLabel();
            label1 = new Label();
            pnl_principal = new Panel();
            lbl = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            toolStrip2 = new ToolStrip();
            btn_inserir = new ToolStripButton();
            btn_editar = new ToolStripButton();
            btn_excluir = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btn_filtrar = new ToolStripButton();
            btn_addItem = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            lbl_tipoCad = new ToolStripLabel();
            toolStrip1 = new ToolStrip();
            btn_tema = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btn_cliente = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btn_evento = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            btn_ConfigurarDesconto = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            statusStrip1.SuspendLayout();
            pnl_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip2.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            resources.ApplyResources(statusStrip1, "statusStrip1");
            statusStrip1.BackColor = Color.White;
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbl_status });
            statusStrip1.Name = "statusStrip1";
            // 
            // lbl_status
            // 
            resources.ApplyResources(lbl_status, "lbl_status");
            lbl_status.Name = "lbl_status";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Thistle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Name = "label1";
            // 
            // pnl_principal
            // 
            resources.ApplyResources(pnl_principal, "pnl_principal");
            pnl_principal.Controls.Add(lbl);
            pnl_principal.Controls.Add(pictureBox2);
            pnl_principal.Controls.Add(label1);
            pnl_principal.Controls.Add(pictureBox1);
            pnl_principal.Name = "pnl_principal";
            // 
            // lbl
            // 
            resources.ApplyResources(lbl, "lbl");
            lbl.BackColor = Color.White;
            lbl.Name = "lbl";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Image = Properties.Resources.Video_Facebook_Gerente_de_Comunidade_Simples_Vermehlo;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BackgroundImage = Properties.Resources.Lady_Party_Tela__1_;
            pictureBox1.Image = Properties.Resources.Lady_Party_Tela__1_;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // toolStrip2
            // 
            resources.ApplyResources(toolStrip2, "toolStrip2");
            toolStrip2.Items.AddRange(new ToolStripItem[] { btn_inserir, btn_editar, btn_excluir, toolStripSeparator4, btn_filtrar, toolStripSeparator6, btn_ConfigurarDesconto, toolStripButton1, toolStripSeparator3, btn_addItem, toolStripSeparator5, lbl_tipoCad });
            toolStrip2.Name = "toolStrip2";
            // 
            // btn_inserir
            // 
            resources.ApplyResources(btn_inserir, "btn_inserir");
            btn_inserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_inserir.Image = Properties.Resources.add_circle_FILL0_wght400_GRAD0_opsz24;
            btn_inserir.Name = "btn_inserir";
            btn_inserir.Padding = new Padding(3);
            btn_inserir.Click += botaoBarraFerramentas_Click;
            // 
            // btn_editar
            // 
            resources.ApplyResources(btn_editar, "btn_editar");
            btn_editar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_editar.Image = Properties.Resources.edit_FILL0_wght400_GRAD0_opsz24;
            btn_editar.Name = "btn_editar";
            btn_editar.Padding = new Padding(3);
            btn_editar.Click += botaoBarraFerramentas_Click;
            // 
            // btn_excluir
            // 
            resources.ApplyResources(btn_excluir, "btn_excluir");
            btn_excluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_excluir.Image = Properties.Resources.delete_forever_FILL0_wght400_GRAD0_opsz24;
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Padding = new Padding(3);
            btn_excluir.Click += botaoBarraFerramentas_Click;
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(toolStripSeparator4, "toolStripSeparator4");
            toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // btn_filtrar
            // 
            resources.ApplyResources(btn_filtrar, "btn_filtrar");
            btn_filtrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_filtrar.Image = Properties.Resources.filter_alt_FILL0_wght400_GRAD0_opsz24;
            btn_filtrar.Name = "btn_filtrar";
            btn_filtrar.Padding = new Padding(3);
            btn_filtrar.Click += botaoBarraFerramentas_Click;
            // 
            // btn_addItem
            // 
            resources.ApplyResources(btn_addItem, "btn_addItem");
            btn_addItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_addItem.Image = Properties.Resources.library_add_FILL0_wght400_GRAD0_opsz24;
            btn_addItem.Name = "btn_addItem";
            btn_addItem.Padding = new Padding(3);
            btn_addItem.Click += botaoBarraFerramentas_Click;
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(toolStripSeparator5, "toolStripSeparator5");
            toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // lbl_tipoCad
            // 
            resources.ApplyResources(lbl_tipoCad, "lbl_tipoCad");
            lbl_tipoCad.Name = "lbl_tipoCad";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(toolStrip1, "toolStrip1");
            toolStrip1.BackColor = Color.White;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_tema, toolStripSeparator1, btn_cliente, toolStripSeparator2, btn_evento, toolStripLabel1 });
            toolStrip1.Name = "toolStrip1";
            // 
            // btn_tema
            // 
            resources.ApplyResources(btn_tema, "btn_tema");
            btn_tema.Image = Properties.Resources.domino_mask_FILL0_wght400_GRAD0_opsz24;
            btn_tema.Name = "btn_tema";
            btn_tema.Padding = new Padding(5);
            btn_tema.Click += selecaoModulo_Click;
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // btn_cliente
            // 
            resources.ApplyResources(btn_cliente, "btn_cliente");
            btn_cliente.Image = Properties.Resources.group_FILL0_wght400_GRAD0_opsz24;
            btn_cliente.Name = "btn_cliente";
            btn_cliente.Padding = new Padding(5);
            btn_cliente.Click += selecaoModulo_Click;
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
            toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // btn_evento
            // 
            resources.ApplyResources(btn_evento, "btn_evento");
            btn_evento.Image = Properties.Resources.cake_FILL0_wght400_GRAD0_opsz24;
            btn_evento.Name = "btn_evento";
            btn_evento.Padding = new Padding(5);
            btn_evento.Click += selecaoModulo_Click;
            // 
            // toolStripLabel1
            // 
            resources.ApplyResources(toolStripLabel1, "toolStripLabel1");
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.Image = Properties.Resources.sentiment_satisfied_FILL0_wght400_GRAD0_opsz24;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Padding = new Padding(10);
            // 
            // btn_ConfigurarDesconto
            // 
            resources.ApplyResources(btn_ConfigurarDesconto, "btn_ConfigurarDesconto");
            btn_ConfigurarDesconto.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_ConfigurarDesconto.Image = Properties.Resources.outline_discount_black_24dp;
            btn_ConfigurarDesconto.Name = "btn_ConfigurarDesconto";
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(toolStripSeparator3, "toolStripSeparator3");
            toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // toolStripSeparator6
            // 
            resources.ApplyResources(toolStripSeparator6, "toolStripSeparator6");
            toolStripSeparator6.Name = "toolStripSeparator6";
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(toolStripButton1, "toolStripButton1");
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.outline_view_list_black_24dp;
            toolStripButton1.Name = "toolStripButton1";
            // 
            // TelaPrincipalForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(pnl_principal);
            Name = "TelaPrincipalForm";
            FormClosing += TelaPrincipalForm_FormClosing;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnl_principal.ResumeLayout(false);
            pnl_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private Label label1;
        private Panel pnl_principal;
        private PictureBox pictureBox1;
        private ToolStripStatusLabel lbl_status;
        private Label lbl;
        private PictureBox pictureBox2;
        private ToolStrip toolStrip1;
        private ToolStripButton btn_tema;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btn_cliente;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btn_evento;
        private ToolStrip toolStrip2;
        private ToolStripButton btn_inserir;
        private ToolStripButton btn_editar;
        private ToolStripButton btn_excluir;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btn_filtrar;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripLabel lbl_tipoCad;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton btn_addItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton btn_ConfigurarDesconto;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton1;
    }
}