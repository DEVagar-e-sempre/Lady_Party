namespace LadyParty.WinForms.ModuloTema
{
    partial class TelaCadastroTema
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
            btn_gravar = new Button();
            btn_cancelar = new Button();
            label3 = new Label();
            label4 = new Label();
            txb_preco = new TextBox();
            txb_nomeTema = new TextBox();
            label1 = new Label();
            txb_id = new TextBox();
            label2 = new Label();
            checkedList = new CheckedListBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Lady_Party_Tela__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(420, 389);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_gravar
            // 
            btn_gravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_gravar.BackColor = Color.White;
            btn_gravar.DialogResult = DialogResult.OK;
            btn_gravar.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_gravar.Location = new Point(237, 347);
            btn_gravar.Name = "btn_gravar";
            btn_gravar.Size = new Size(74, 30);
            btn_gravar.TabIndex = 16;
            btn_gravar.Text = "Gravar";
            btn_gravar.UseVisualStyleBackColor = false;
            btn_gravar.Click += btn_gravar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.BackColor = Color.White;
            btn_cancelar.DialogResult = DialogResult.Cancel;
            btn_cancelar.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.Location = new Point(317, 347);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(74, 30);
            btn_cancelar.TabIndex = 17;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Thistle;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 21);
            label3.Name = "label3";
            label3.Size = new Size(220, 37);
            label3.TabIndex = 18;
            label3.Text = "Cadastro de Temas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 256);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 19;
            label4.Text = "Preço:";
            // 
            // txb_preco
            // 
            txb_preco.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txb_preco.Location = new Point(30, 282);
            txb_preco.Name = "txb_preco";
            txb_preco.ReadOnly = true;
            txb_preco.Size = new Size(163, 30);
            txb_preco.TabIndex = 20;
            txb_preco.Text = "500";
            // 
            // txb_nomeTema
            // 
            txb_nomeTema.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nomeTema.Location = new Point(30, 210);
            txb_nomeTema.Name = "txb_nomeTema";
            txb_nomeTema.Size = new Size(163, 30);
            txb_nomeTema.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 184);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 10;
            label1.Text = "Nome:";
            // 
            // txb_id
            // 
            txb_id.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txb_id.Location = new Point(30, 146);
            txb_id.Name = "txb_id";
            txb_id.ReadOnly = true;
            txb_id.Size = new Size(51, 30);
            txb_id.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 120);
            label2.Name = "label2";
            label2.Size = new Size(28, 23);
            label2.TabIndex = 21;
            label2.Text = "ID:";
            // 
            // checkedList
            // 
            checkedList.FormattingEnabled = true;
            checkedList.Location = new Point(215, 146);
            checkedList.Name = "checkedList";
            checkedList.Size = new Size(180, 166);
            checkedList.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(215, 120);
            label5.Name = "label5";
            label5.Size = new Size(102, 23);
            label5.TabIndex = 24;
            label5.Text = "Lista de Itens:";
            // 
            // TelaCadastroTema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 389);
            Controls.Add(label5);
            Controls.Add(checkedList);
            Controls.Add(txb_id);
            Controls.Add(label2);
            Controls.Add(txb_preco);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_gravar);
            Controls.Add(txb_nomeTema);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "TelaCadastroTema";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Tema";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_gravar;
        private Button btn_cancelar;
        private Label label3;
        private Label label4;
        private TextBox txb_preco;
        private TextBox txb_nomeTema;
        private Label label1;
        private TextBox txb_id;
        private Label label2;
        private CheckedListBox checkedList;
        private Label label5;
    }
}