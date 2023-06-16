namespace LadyParty.WinForms.ModuloTema
{
    partial class TelaCadastroItemForm
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
            pictureBox1 = new PictureBox();
            btn_cancelar = new Button();
            btn_gravar = new Button();
            txb_preco = new TextBox();
            label4 = new Label();
            txb_nome = new TextBox();
            label1 = new Label();
            listBox_itens = new ListBox();
            btn_adicionar = new Button();
            txb_tema = new TextBox();
            label2 = new Label();
            txb_id = new TextBox();
            label3 = new Label();
            label5 = new Label();
            btn_remover = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Lady_Party_Tela__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(462, 391);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.BackColor = Color.White;
            btn_cancelar.DialogResult = DialogResult.Cancel;
            btn_cancelar.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.Location = new Point(374, 348);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(74, 30);
            btn_cancelar.TabIndex = 19;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_gravar
            // 
            btn_gravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_gravar.BackColor = Color.White;
            btn_gravar.DialogResult = DialogResult.OK;
            btn_gravar.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_gravar.Location = new Point(294, 348);
            btn_gravar.Name = "btn_gravar";
            btn_gravar.Size = new Size(74, 30);
            btn_gravar.TabIndex = 18;
            btn_gravar.Text = "Gravar";
            btn_gravar.UseVisualStyleBackColor = false;
            btn_gravar.Click += btn_gravar_Click;
            // 
            // txb_preco
            // 
            txb_preco.BackColor = Color.White;
            txb_preco.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txb_preco.Location = new Point(12, 297);
            txb_preco.Name = "txb_preco";
            txb_preco.Size = new Size(158, 30);
            txb_preco.TabIndex = 25;
            txb_preco.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 270);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 24;
            label4.Text = "Preço:";
            // 
            // txb_nome
            // 
            txb_nome.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nome.Location = new Point(12, 229);
            txb_nome.Name = "txb_nome";
            txb_nome.Size = new Size(158, 30);
            txb_nome.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 203);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 22;
            label1.Text = "Nome:";
            // 
            // listBox_itens
            // 
            listBox_itens.FormattingEnabled = true;
            listBox_itens.ItemHeight = 15;
            listBox_itens.Location = new Point(227, 143);
            listBox_itens.Name = "listBox_itens";
            listBox_itens.Size = new Size(221, 184);
            listBox_itens.TabIndex = 26;
            // 
            // btn_adicionar
            // 
            btn_adicionar.BackColor = Color.White;
            btn_adicionar.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_adicionar.Location = new Point(12, 349);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(75, 30);
            btn_adicionar.TabIndex = 27;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = false;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // txb_tema
            // 
            txb_tema.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txb_tema.Location = new Point(78, 164);
            txb_tema.Name = "txb_tema";
            txb_tema.ReadOnly = true;
            txb_tema.Size = new Size(92, 30);
            txb_tema.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(78, 138);
            label2.Name = "label2";
            label2.Size = new Size(51, 23);
            label2.TabIndex = 28;
            label2.Text = "Tema:";
            // 
            // txb_id
            // 
            txb_id.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txb_id.Location = new Point(12, 164);
            txb_id.Name = "txb_id";
            txb_id.ReadOnly = true;
            txb_id.Size = new Size(44, 30);
            txb_id.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 138);
            label3.Name = "label3";
            label3.Size = new Size(28, 23);
            label3.TabIndex = 31;
            label3.Text = "ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Thistle;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe Print", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 26);
            label5.Name = "label5";
            label5.Size = new Size(279, 51);
            label5.TabIndex = 32;
            label5.Text = "Cadastro de Itens";
            // 
            // btn_remover
            // 
            btn_remover.BackColor = Color.White;
            btn_remover.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_remover.Location = new Point(95, 349);
            btn_remover.Name = "btn_remover";
            btn_remover.Size = new Size(75, 30);
            btn_remover.TabIndex = 33;
            btn_remover.Text = "Remover";
            btn_remover.UseVisualStyleBackColor = false;
            btn_remover.Click += btn_remover_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(227, 117);
            label6.Name = "label6";
            label6.Size = new Size(45, 23);
            label6.TabIndex = 34;
            label6.Text = "Itens:";
            // 
            // TelaCadastroItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 390);
            Controls.Add(label6);
            Controls.Add(btn_remover);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txb_id);
            Controls.Add(txb_tema);
            Controls.Add(label2);
            Controls.Add(btn_adicionar);
            Controls.Add(listBox_itens);
            Controls.Add(txb_preco);
            Controls.Add(label4);
            Controls.Add(txb_nome);
            Controls.Add(label1);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_gravar);
            Controls.Add(pictureBox1);
            Name = "TelaCadastroItemForm";
            Text = "Cadastro de Item";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_cancelar;
        private Button btn_gravar;
        private TextBox txb_preco;
        private Label label4;
        private TextBox txb_nome;
        private Label label1;
        private ListBox listBox_itens;
        private Button btn_adicionar;
        private TextBox txb_tema;
        private Label label2;
        private TextBox txb_id;
        private Label label3;
        private Label label5;
        private Button btn_remover;
        private Label label6;
    }
}