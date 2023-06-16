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
            lbl_Cliente = new Label();
            lbl_nomeCliente = new Label();
            lbl_telefone = new Label();
            txt_id = new TextBox();
            lbl_id = new Label();
            btn_gravar = new Button();
            btn_cancelar = new Button();
            txt_telefone = new MaskedTextBox();
            txt_nomeCliente = new TextBox();
            SuspendLayout();
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
            // 
            // lbl_nomeCliente
            // 
            lbl_nomeCliente.AutoSize = true;
            lbl_nomeCliente.BackColor = Color.Transparent;
            lbl_nomeCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nomeCliente.Location = new Point(50, 170);
            lbl_nomeCliente.Name = "lbl_nomeCliente";
            lbl_nomeCliente.Size = new Size(44, 15);
            lbl_nomeCliente.TabIndex = 12;
            lbl_nomeCliente.Text = "Nome:";
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.BackColor = Color.Transparent;
            lbl_telefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_telefone.Location = new Point(35, 215);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(59, 15);
            lbl_telefone.TabIndex = 14;
            lbl_telefone.Text = "Telefone:";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(100, 111);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(21, 23);
            txt_id.TabIndex = 19;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.BackColor = Color.Transparent;
            lbl_id.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_id.Location = new Point(73, 119);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(21, 15);
            lbl_id.TabIndex = 16;
            lbl_id.Text = "Id:";
            // 
            // btn_gravar
            // 
            btn_gravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_gravar.BackColor = Color.White;
            btn_gravar.DialogResult = DialogResult.OK;
            btn_gravar.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_gravar.Location = new Point(213, 263);
            btn_gravar.Name = "btn_gravar";
            btn_gravar.Size = new Size(97, 43);
            btn_gravar.TabIndex = 23;
            btn_gravar.Text = "Gravar";
            btn_gravar.UseVisualStyleBackColor = false;
            btn_gravar.Click += btn_gravar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.BackColor = Color.White;
            btn_cancelar.DialogResult = DialogResult.Cancel;
            btn_cancelar.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.Location = new Point(331, 263);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(97, 43);
            btn_cancelar.TabIndex = 24;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // txt_telefone
            // 
            txt_telefone.Location = new Point(100, 207);
            txt_telefone.Mask = "(00) 0000-0000";
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(152, 23);
            txt_telefone.TabIndex = 25;
            // 
            // txt_nomeCliente
            // 
            txt_nomeCliente.Location = new Point(101, 162);
            txt_nomeCliente.Name = "txt_nomeCliente";
            txt_nomeCliente.Size = new Size(151, 23);
            txt_nomeCliente.TabIndex = 27;
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Lady_Party_Tela__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(461, 344);
            Controls.Add(txt_nomeCliente);
            Controls.Add(txt_telefone);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_gravar);
            Controls.Add(txt_id);
            Controls.Add(lbl_id);
            Controls.Add(lbl_telefone);
            Controls.Add(lbl_nomeCliente);
            Controls.Add(lbl_Cliente);
            DoubleBuffered = true;
            Name = "TelaClienteForm";
            Text = "Inserir Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_Cliente;
        private Label lbl_nomeCliente;
        private Label lbl_telefone;
        private TextBox textBox3;
        private Label label3;
        private TextBox txt_id;
        private Label lbl_id;
        private Button btn_gravar;
        private Button btn_cancelar;
        private Label label4;
        private MaskedTextBox txt_telefone;
        private TextBox txt_nomeCliente;
    }
}