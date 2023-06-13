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
            label1 = new Label();
            label2 = new Label();
            checkedList = new CheckedListBox();
            txb_nomeTema = new TextBox();
            btn_gravar = new Button();
            btn_cancelar = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Lady_Party_Tela__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 342);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 138);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 10;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(237, 138);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 11;
            label2.Text = "Lista de Itens:";
            // 
            // checkedList
            // 
            checkedList.FormattingEnabled = true;
            checkedList.Location = new Point(237, 164);
            checkedList.Name = "checkedList";
            checkedList.Size = new Size(137, 148);
            checkedList.TabIndex = 12;
            // 
            // txb_nomeTema
            // 
            txb_nomeTema.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nomeTema.Location = new Point(34, 164);
            txb_nomeTema.Name = "txb_nomeTema";
            txb_nomeTema.Size = new Size(183, 30);
            txb_nomeTema.TabIndex = 15;
            // 
            // btn_gravar
            // 
            btn_gravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_gravar.BackColor = Color.White;
            btn_gravar.DialogResult = DialogResult.OK;
            btn_gravar.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_gravar.Location = new Point(34, 282);
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
            btn_cancelar.Location = new Point(143, 282);
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
            label3.Location = new Point(12, 28);
            label3.Name = "label3";
            label3.Size = new Size(220, 37);
            label3.TabIndex = 18;
            label3.Text = "Cadastro de Temas";
            // 
            // TelaCadastroTema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 342);
            Controls.Add(label3);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_gravar);
            Controls.Add(txb_nomeTema);
            Controls.Add(checkedList);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "TelaCadastroTema";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastroTema";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private CheckedListBox checkedList;
        private TextBox txb_nomeTema;
        private Button btn_gravar;
        private Button btn_cancelar;
        private Label label3;
    }
}