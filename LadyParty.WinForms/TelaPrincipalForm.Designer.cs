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
            statusStrip1 = new StatusStrip();
            lbl_status = new ToolStripStatusLabel();
            label1 = new Label();
            pnl_principal = new Panel();
            toolStrip2 = new ToolStrip();
            btn_inserir = new ToolStripButton();
            btn_editar = new ToolStripButton();
            btn_excluir = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btn_filtrar = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            lbl_tipoCad = new ToolStripLabel();
            lbl = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            toolStrip1 = new ToolStrip();
            btn_temas = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btn_cliente = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btn_compra = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btn_evento = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            statusStrip1.SuspendLayout();
            pnl_principal.SuspendLayout();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.White;
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbl_status });
            statusStrip1.Location = new Point(0, 444);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(499, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbl_status
            // 
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(39, 17);
            lbl_status.Text = "Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Thistle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe Print", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 21);
            label1.Name = "label1";
            label1.Size = new Size(188, 51);
            label1.TabIndex = 9;
            label1.Text = "Lady Party";
            // 
            // pnl_principal
            // 
            pnl_principal.Controls.Add(lbl);
            pnl_principal.Controls.Add(pictureBox2);
            pnl_principal.Controls.Add(label1);
            pnl_principal.Controls.Add(pictureBox1);
            pnl_principal.Location = new Point(0, 71);
            pnl_principal.Name = "pnl_principal";
            pnl_principal.Size = new Size(499, 370);
            pnl_principal.TabIndex = 10;
            // 
            // toolStrip2
            // 
            toolStrip2.Items.AddRange(new ToolStripItem[] { btn_inserir, btn_editar, btn_excluir, toolStripSeparator4, btn_filtrar, toolStripSeparator5, lbl_tipoCad });
            toolStrip2.Location = new Point(0, 39);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(499, 29);
            toolStrip2.TabIndex = 12;
            toolStrip2.Text = "toolStrip2";
            // 
            // btn_inserir
            // 
            btn_inserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_inserir.Image = Properties.Resources.add_circle_FILL0_wght400_GRAD0_opsz24;
            btn_inserir.ImageTransparentColor = Color.Magenta;
            btn_inserir.Name = "btn_inserir";
            btn_inserir.Padding = new Padding(3);
            btn_inserir.Size = new Size(26, 26);
            btn_inserir.Text = "toolStripButton1";
            btn_inserir.Click += btn_inserir_Click;
            // 
            // btn_editar
            // 
            btn_editar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_editar.Image = Properties.Resources.edit_FILL0_wght400_GRAD0_opsz24;
            btn_editar.ImageTransparentColor = Color.Magenta;
            btn_editar.Name = "btn_editar";
            btn_editar.Padding = new Padding(3);
            btn_editar.Size = new Size(26, 26);
            btn_editar.Text = "toolStripButton2";
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_excluir.Image = Properties.Resources.delete_forever_FILL0_wght400_GRAD0_opsz24;
            btn_excluir.ImageTransparentColor = Color.Magenta;
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Padding = new Padding(3);
            btn_excluir.Size = new Size(26, 26);
            btn_excluir.Text = "toolStripButton3";
            btn_excluir.Click += btn_excluir_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 29);
            // 
            // btn_filtrar
            // 
            btn_filtrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_filtrar.Image = Properties.Resources.filter_alt_FILL0_wght400_GRAD0_opsz24;
            btn_filtrar.ImageTransparentColor = Color.Magenta;
            btn_filtrar.Name = "btn_filtrar";
            btn_filtrar.Padding = new Padding(3);
            btn_filtrar.Size = new Size(26, 26);
            btn_filtrar.Text = "toolStripButton4";
            btn_filtrar.Click += btn_filtrar_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 29);
            // 
            // lbl_tipoCad
            // 
            lbl_tipoCad.Name = "lbl_tipoCad";
            lbl_tipoCad.Size = new Size(97, 26);
            lbl_tipoCad.Text = "Tipo do Cadastro";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.White;
            lbl.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            lbl.Location = new Point(14, 122);
            lbl.Name = "lbl";
            lbl.Size = new Size(473, 33);
            lbl.TabIndex = 11;
            lbl.Text = "Vamos lá, escolha um tema para a sua FESTA!!";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Video_Facebook_Gerente_de_Comunidade_Simples_Vermehlo;
            pictureBox2.Location = new Point(153, 168);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 166);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Lady_Party_Tela__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Lady_Party_Tela__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 370);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.White;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_temas, toolStripSeparator1, btn_cliente, toolStripSeparator2, btn_compra, toolStripSeparator3, btn_evento, toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(499, 39);
            toolStrip1.TabIndex = 11;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_temas
            // 
            btn_temas.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_temas.Image = Properties.Resources.domino_mask_FILL0_wght400_GRAD0_opsz24;
            btn_temas.ImageTransparentColor = Color.Magenta;
            btn_temas.Name = "btn_temas";
            btn_temas.Padding = new Padding(5);
            btn_temas.Size = new Size(78, 36);
            btn_temas.Text = "Temas";
            btn_temas.Click += btn_temas_Click_1;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // btn_cliente
            // 
            btn_cliente.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_cliente.Image = Properties.Resources.group_FILL0_wght400_GRAD0_opsz24;
            btn_cliente.ImageTransparentColor = Color.Magenta;
            btn_cliente.Name = "btn_cliente";
            btn_cliente.Padding = new Padding(5);
            btn_cliente.Size = new Size(85, 36);
            btn_cliente.Text = "Clientes";
            btn_cliente.Click += btn_cliente_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 39);
            // 
            // btn_compra
            // 
            btn_compra.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_compra.Image = Properties.Resources.shopping_cart_FILL0_wght400_GRAD0_opsz24;
            btn_compra.ImageTransparentColor = Color.Magenta;
            btn_compra.Name = "btn_compra";
            btn_compra.Padding = new Padding(5);
            btn_compra.Size = new Size(93, 36);
            btn_compra.Text = "Compras";
            btn_compra.Click += btn_compra_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 39);
            // 
            // btn_evento
            // 
            btn_evento.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_evento.Image = Properties.Resources.cake_FILL0_wght400_GRAD0_opsz24;
            btn_evento.ImageTransparentColor = Color.Magenta;
            btn_evento.Name = "btn_evento";
            btn_evento.Padding = new Padding(5);
            btn_evento.Size = new Size(71, 36);
            btn_evento.Text = "Festa";
            btn_evento.Click += btn_evento_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.Image = Properties.Resources.sentiment_satisfied_FILL0_wght400_GRAD0_opsz24;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Padding = new Padding(10);
            toolStripLabel1.Size = new Size(36, 36);
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 466);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(pnl_principal);
            Name = "TelaPrincipalForm";
            Text = "Tela Principal";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnl_principal.ResumeLayout(false);
            pnl_principal.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private ToolStripButton btn_temas;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btn_cliente;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btn_compra;
        private ToolStripSeparator toolStripSeparator3;
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
    }
}