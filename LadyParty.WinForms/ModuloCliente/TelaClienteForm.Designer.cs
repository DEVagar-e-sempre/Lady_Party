namespace LadyParty.WinForms.ModuloCliente
{
    partial class TelaClienteForm
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
            statusStrip1 = new StatusStrip();
            lbl_Cliente = new Label();
            lbl_nomeCliente = new Label();
            txb_nomeCliente = new TextBox();
            txb_telefone = new TextBox();
            lbl_telefone = new Label();
            txb_id = new TextBox();
            lbl_id = new Label();
            lbl_tipoCliente = new Label();
            rdb_clienteEspecial = new RadioButton();
            rdb_clienteConvencional = new RadioButton();
            btn_gravar = new Button();
            btn_cancelar = new Button();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 322);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(461, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbl_Cliente
            // 
            lbl_Cliente.AutoSize = true;
            lbl_Cliente.BackColor = Color.Transparent;
            lbl_Cliente.Font = new Font("MV Boli", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Cliente.Location = new Point(32, 28);
            lbl_Cliente.Name = "lbl_Cliente";
            lbl_Cliente.Size = new Size(114, 39);
            lbl_Cliente.TabIndex = 11;
            lbl_Cliente.Text = "Cliente";
            lbl_Cliente.Click += lbl_Cliente_Click;
            // 
            // lbl_nomeCliente
            // 
            lbl_nomeCliente.AutoSize = true;
            lbl_nomeCliente.Location = new Point(43, 130);
            lbl_nomeCliente.Name = "lbl_nomeCliente";
            lbl_nomeCliente.Size = new Size(43, 15);
            lbl_nomeCliente.TabIndex = 12;
            lbl_nomeCliente.Text = "Nome:";
            // 
            // txb_nomeCliente
            // 
            txb_nomeCliente.Location = new Point(101, 122);
            txb_nomeCliente.Name = "txb_nomeCliente";
            txb_nomeCliente.Size = new Size(194, 23);
            txb_nomeCliente.TabIndex = 13;
            // 
            // txb_telefone
            // 
            txb_telefone.Location = new Point(100, 162);
            txb_telefone.Name = "txb_telefone";
            txb_telefone.Size = new Size(152, 23);
            txb_telefone.TabIndex = 15;
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Location = new Point(32, 170);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(54, 15);
            lbl_telefone.TabIndex = 14;
            lbl_telefone.Text = "Telefone:";
            // 
            // txb_id
            // 
            txb_id.Location = new Point(100, 81);
            txb_id.Name = "txb_id";
            txb_id.Size = new Size(21, 23);
            txb_id.TabIndex = 19;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(66, 89);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(20, 15);
            lbl_id.TabIndex = 16;
            lbl_id.Text = "Id:";
            // 
            // lbl_tipoCliente
            // 
            lbl_tipoCliente.AutoSize = true;
            lbl_tipoCliente.Location = new Point(53, 204);
            lbl_tipoCliente.Name = "lbl_tipoCliente";
            lbl_tipoCliente.Size = new Size(33, 15);
            lbl_tipoCliente.TabIndex = 20;
            lbl_tipoCliente.Text = "Tipo:";
            // 
            // rdb_clienteEspecial
            // 
            rdb_clienteEspecial.AutoSize = true;
            rdb_clienteEspecial.Location = new Point(100, 202);
            rdb_clienteEspecial.Name = "rdb_clienteEspecial";
            rdb_clienteEspecial.Size = new Size(107, 19);
            rdb_clienteEspecial.TabIndex = 21;
            rdb_clienteEspecial.TabStop = true;
            rdb_clienteEspecial.Text = "Cliente Especial";
            rdb_clienteEspecial.UseVisualStyleBackColor = true;
            // 
            // rdb_clienteConvencional
            // 
            rdb_clienteConvencional.AutoSize = true;
            rdb_clienteConvencional.Location = new Point(213, 202);
            rdb_clienteConvencional.Name = "rdb_clienteConvencional";
            rdb_clienteConvencional.Size = new Size(138, 19);
            rdb_clienteConvencional.TabIndex = 22;
            rdb_clienteConvencional.TabStop = true;
            rdb_clienteConvencional.Text = "Cliente Convencional";
            rdb_clienteConvencional.UseVisualStyleBackColor = true;
            // 
            // btn_gravar
            // 
            btn_gravar.Location = new Point(213, 263);
            btn_gravar.Name = "btn_gravar";
            btn_gravar.Size = new Size(97, 43);
            btn_gravar.TabIndex = 23;
            btn_gravar.Text = "Gravar";
            btn_gravar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(331, 263);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(97, 43);
            btn_cancelar.TabIndex = 24;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 344);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_gravar);
            Controls.Add(rdb_clienteConvencional);
            Controls.Add(rdb_clienteEspecial);
            Controls.Add(lbl_tipoCliente);
            Controls.Add(txb_id);
            Controls.Add(lbl_id);
            Controls.Add(txb_telefone);
            Controls.Add(lbl_telefone);
            Controls.Add(txb_nomeCliente);
            Controls.Add(lbl_nomeCliente);
            Controls.Add(lbl_Cliente);
            Controls.Add(statusStrip1);
            Name = "TelaCadastroCliente";
            Text = "Inserir Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private Label lbl_Cliente;
        private Label lbl_nomeCliente;
        private TextBox txb_nomeCliente;
        private TextBox txb_telefone;
        private Label lbl_telefone;
        private TextBox textBox3;
        private Label label3;
        private TextBox txb_id;
        private Label lbl_id;
        private Label lbl_tipoCliente;
        private RadioButton rdb_clienteEspecial;
        private RadioButton rdb_clienteConvencional;
        private Button btn_gravar;
        private Button btn_cancelar;
        private Label label4;
    }
}