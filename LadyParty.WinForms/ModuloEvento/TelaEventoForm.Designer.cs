namespace LadyParty.WinForms.ModuloEvento
{
    partial class TelaEventoForm
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
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            cbnClientes = new ComboBox();
            label3 = new Label();
            cbnTemas = new ComboBox();
            label4 = new Label();
            txtData = new DateTimePicker();
            txtHoraInicio = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            txtHoraTermino = new DateTimePicker();
            btnGravar = new Button();
            btnCancelar = new Button();
            label7 = new Label();
            txtEndereco = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(102, 92);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(136, 92);
            txtId.Name = "txtId";
            txtId.Size = new Size(121, 23);
            txtId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(76, 131);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 2;
            label2.Text = "Cliente:";
            // 
            // cbnClientes
            // 
            cbnClientes.FormattingEnabled = true;
            cbnClientes.Location = new Point(136, 131);
            cbnClientes.Name = "cbnClientes";
            cbnClientes.Size = new Size(121, 23);
            cbnClientes.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(83, 172);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 4;
            label3.Text = "Tema:";
            // 
            // cbnTemas
            // 
            cbnTemas.FormattingEnabled = true;
            cbnTemas.Location = new Point(136, 170);
            cbnTemas.Name = "cbnTemas";
            cbnTemas.Size = new Size(121, 23);
            cbnTemas.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 249);
            label4.Name = "label4";
            label4.Size = new Size(100, 21);
            label4.TabIndex = 6;
            label4.Text = "Data da Festa:";
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(136, 249);
            txtData.Name = "txtData";
            txtData.Size = new Size(98, 23);
            txtData.TabIndex = 7;
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.CustomFormat = "HH:mm";
            txtHoraInicio.Format = DateTimePickerFormat.Custom;
            txtHoraInicio.Location = new Point(136, 294);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.ShowUpDown = true;
            txtHoraInicio.Size = new Size(58, 23);
            txtHoraInicio.TabIndex = 8;
            // 
            // label5
            // 
            label5.Location = new Point(66, 287);
            label5.Name = "label5";
            label5.Size = new Size(64, 30);
            label5.TabIndex = 9;
            label5.Text = "Horário    do Início:";
            // 
            // label6
            // 
            label6.Location = new Point(218, 287);
            label6.Name = "label6";
            label6.Size = new Size(70, 30);
            label6.TabIndex = 11;
            label6.Text = "Horário     do Término:";
            // 
            // txtHoraTermino
            // 
            txtHoraTermino.CustomFormat = "HH:mm";
            txtHoraTermino.Format = DateTimePickerFormat.Custom;
            txtHoraTermino.Location = new Point(294, 294);
            txtHoraTermino.Name = "txtHoraTermino";
            txtHoraTermino.ShowUpDown = true;
            txtHoraTermino.Size = new Size(58, 23);
            txtHoraTermino.TabIndex = 10;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGravar.Location = new Point(168, 369);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(89, 42);
            btnGravar.TabIndex = 12;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(274, 369);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(89, 42);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(61, 210);
            label7.Name = "label7";
            label7.Size = new Size(69, 21);
            label7.TabIndex = 14;
            label7.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(136, 208);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(227, 23);
            txtEndereco.TabIndex = 15;
            // 
            // label8
            // 
            label8.BackColor = Color.Thistle;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe Script", 22.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 20);
            label8.Name = "label8";
            label8.Size = new Size(318, 56);
            label8.TabIndex = 16;
            label8.Text = "Cadastro de Festas";
            // 
            // TelaEventoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Lady_Party_Tela__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(436, 429);
            Controls.Add(label8);
            Controls.Add(txtEndereco);
            Controls.Add(label7);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(label6);
            Controls.Add(txtHoraTermino);
            Controls.Add(label5);
            Controls.Add(txtHoraInicio);
            Controls.Add(txtData);
            Controls.Add(label4);
            Controls.Add(cbnTemas);
            Controls.Add(label3);
            Controls.Add(cbnClientes);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "TelaEventoForm";
            Text = "Adicionar Evento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private ComboBox cbnClientes;
        private Label label3;
        private ComboBox cbnTemas;
        private Label label4;
        private DateTimePicker txtData;
        private DateTimePicker txtHoraInicio;
        private Label label5;
        private Label label6;
        private DateTimePicker txtHoraTermino;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label7;
        private TextBox txtEndereco;
        private Label label8;
    }
}