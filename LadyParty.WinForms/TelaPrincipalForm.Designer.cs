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
            btn_temas = new Button();
            btn_clientes = new Button();
            btn_loja = new Button();
            btn_festas = new Button();
            label1 = new Label();
            pnl_principal = new Panel();
            pictureBox1 = new PictureBox();
            lbl_status = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            pnl_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.White;
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbl_status });
            statusStrip1.Location = new Point(0, 593);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(707, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // btn_temas
            // 
            btn_temas.BackColor = Color.Thistle;
            btn_temas.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_temas.Location = new Point(244, 234);
            btn_temas.Name = "btn_temas";
            btn_temas.Size = new Size(241, 69);
            btn_temas.TabIndex = 5;
            btn_temas.Text = "Temas";
            btn_temas.UseVisualStyleBackColor = false;
            btn_temas.Click += btn_temas_Click;
            // 
            // btn_clientes
            // 
            btn_clientes.BackColor = Color.Thistle;
            btn_clientes.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clientes.Location = new Point(244, 309);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(241, 69);
            btn_clientes.TabIndex = 6;
            btn_clientes.Text = "Clientes";
            btn_clientes.UseVisualStyleBackColor = false;
            btn_clientes.Click += btn_clientes_Click;
            // 
            // btn_loja
            // 
            btn_loja.BackColor = Color.Thistle;
            btn_loja.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_loja.Location = new Point(244, 384);
            btn_loja.Name = "btn_loja";
            btn_loja.Size = new Size(241, 69);
            btn_loja.TabIndex = 7;
            btn_loja.Text = "Loja";
            btn_loja.UseVisualStyleBackColor = false;
            btn_loja.Click += btn_loja_Click;
            // 
            // btn_festas
            // 
            btn_festas.BackColor = Color.Thistle;
            btn_festas.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_festas.Location = new Point(244, 459);
            btn_festas.Name = "btn_festas";
            btn_festas.Size = new Size(241, 69);
            btn_festas.TabIndex = 8;
            btn_festas.Text = "Festas";
            btn_festas.UseVisualStyleBackColor = false;
            btn_festas.Click += btn_festas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe Script", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(247, 61);
            label1.TabIndex = 9;
            label1.Text = "Lady Party";
            // 
            // pnl_principal
            // 
            pnl_principal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_principal.Controls.Add(pictureBox1);
            pnl_principal.Location = new Point(0, 0);
            pnl_principal.Name = "pnl_principal";
            pnl_principal.Size = new Size(707, 615);
            pnl_principal.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Lady_Party_Tela__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(707, 615);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lbl_status
            // 
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(39, 17);
            lbl_status.Text = "Status";
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 615);
            Controls.Add(label1);
            Controls.Add(btn_festas);
            Controls.Add(btn_loja);
            Controls.Add(btn_clientes);
            Controls.Add(btn_temas);
            Controls.Add(statusStrip1);
            Controls.Add(pnl_principal);
            Name = "TelaPrincipalForm";
            Text = "Tela Principal";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnl_principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private Button btn_temas;
        private Button btn_clientes;
        private Button btn_loja;
        private Button btn_festas;
        private Label label1;
        private Panel pnl_principal;
        private PictureBox pictureBox1;
        private ToolStripStatusLabel lbl_status;
    }
}