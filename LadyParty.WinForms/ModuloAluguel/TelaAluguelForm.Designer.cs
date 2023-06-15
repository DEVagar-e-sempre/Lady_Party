namespace LadyParty.WinForms.ModuloAluguel
{
    partial class TelaAluguelForm
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
            components = new System.ComponentModel.Container();
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
            labelTitulo = new Label();
            groupBox1 = new GroupBox();
            label9 = new Label();
            txtValorTema = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label10 = new Label();
            txtValorEntrada = new NumericUpDown();
            label8 = new Label();
            clienteUserControl1 = new ModuloCliente.ClienteUserControl();
            txtValorDevido = new TextBox();
            txtPagarDivida = new NumericUpDown();
            cbxPagarDivida = new CheckBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtValorEntrada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPagarDivida).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Thistle;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(102, 94);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(136, 92);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(121, 23);
            txtId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Thistle;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(78, 127);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 2;
            label2.Text = "Cliente:";
            // 
            // cbnClientes
            // 
            cbnClientes.FormattingEnabled = true;
            cbnClientes.Location = new Point(136, 125);
            cbnClientes.Name = "cbnClientes";
            cbnClientes.Size = new Size(121, 23);
            cbnClientes.TabIndex = 3;
            cbnClientes.SelectedValueChanged += cbnClientes_SelectedValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Thistle;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(83, 159);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 4;
            label3.Text = "Tema:";
            // 
            // cbnTemas
            // 
            cbnTemas.Enabled = false;
            cbnTemas.FormattingEnabled = true;
            cbnTemas.Location = new Point(136, 157);
            cbnTemas.Name = "cbnTemas";
            cbnTemas.Size = new Size(121, 23);
            cbnTemas.TabIndex = 5;
            cbnTemas.SelectedValueChanged += cbnTemas_SelectedValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Thistle;
            label4.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(20, 80);
            label4.Name = "label4";
            label4.Size = new Size(100, 21);
            label4.TabIndex = 6;
            label4.Text = "Data da Festa:";
            // 
            // txtData
            // 
            txtData.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(126, 80);
            txtData.Name = "txtData";
            txtData.Size = new Size(98, 23);
            txtData.TabIndex = 7;
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.CustomFormat = "HH:mm";
            txtHoraInicio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoraInicio.Format = DateTimePickerFormat.Custom;
            txtHoraInicio.Location = new Point(126, 125);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.ShowUpDown = true;
            txtHoraInicio.Size = new Size(58, 23);
            txtHoraInicio.TabIndex = 8;
            // 
            // label5
            // 
            label5.BackColor = Color.Thistle;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(56, 118);
            label5.Name = "label5";
            label5.Size = new Size(64, 30);
            label5.TabIndex = 9;
            label5.Text = "Horário    do Início:";
            // 
            // label6
            // 
            label6.BackColor = Color.Thistle;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(208, 118);
            label6.Name = "label6";
            label6.Size = new Size(70, 30);
            label6.TabIndex = 11;
            label6.Text = "Horário     do Término:";
            // 
            // txtHoraTermino
            // 
            txtHoraTermino.CustomFormat = "HH:mm";
            txtHoraTermino.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoraTermino.Format = DateTimePickerFormat.Custom;
            txtHoraTermino.Location = new Point(284, 125);
            txtHoraTermino.Name = "txtHoraTermino";
            txtHoraTermino.ShowUpDown = true;
            txtHoraTermino.Size = new Size(58, 23);
            txtHoraTermino.TabIndex = 10;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGravar.Location = new Point(104, 471);
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
            btnCancelar.Location = new Point(210, 471);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(89, 42);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Thistle;
            label7.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(51, 41);
            label7.Name = "label7";
            label7.Size = new Size(69, 21);
            label7.TabIndex = 14;
            label7.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereco.Location = new Point(126, 39);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(227, 23);
            txtEndereco.TabIndex = 15;
            // 
            // labelTitulo
            // 
            labelTitulo.BackColor = Color.Thistle;
            labelTitulo.FlatStyle = FlatStyle.Flat;
            labelTitulo.Font = new Font("Segoe Script", 19.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.Location = new Point(12, 20);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(316, 44);
            labelTitulo.TabIndex = 16;
            labelTitulo.Text = "Cadastro de Aluguel";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEndereco);
            groupBox1.Controls.Add(txtData);
            groupBox1.Controls.Add(txtHoraInicio);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtHoraTermino);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(14, 279);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(371, 165);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados da Festa";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Thistle;
            label9.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(30, 197);
            label9.Name = "label9";
            label9.Size = new Size(102, 21);
            label9.TabIndex = 18;
            label9.Text = "Valor do tema:";
            // 
            // txtValorTema
            // 
            txtValorTema.AutoSize = true;
            txtValorTema.BackColor = Color.Thistle;
            txtValorTema.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtValorTema.Location = new Point(138, 197);
            txtValorTema.Name = "txtValorTema";
            txtValorTema.Size = new Size(50, 21);
            txtValorTema.TabIndex = 19;
            txtValorTema.Text = "{valor}";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Thistle;
            label10.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(14, 232);
            label10.Name = "label10";
            label10.Size = new Size(118, 21);
            label10.TabIndex = 21;
            label10.Text = "Valor de entrada:";
            // 
            // txtValorEntrada
            // 
            txtValorEntrada.Enabled = false;
            txtValorEntrada.Location = new Point(138, 230);
            txtValorEntrada.Name = "txtValorEntrada";
            txtValorEntrada.Size = new Size(69, 23);
            txtValorEntrada.TabIndex = 22;
            txtValorEntrada.ValueChanged += txtValorEntrada_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Thistle;
            label8.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(220, 197);
            label8.Name = "label8";
            label8.Size = new Size(90, 21);
            label8.TabIndex = 24;
            label8.Text = "Valor devido:";
            // 
            // clienteUserControl1
            // 
            clienteUserControl1.BackgroundImageLayout = ImageLayout.Stretch;
            clienteUserControl1.Location = new Point(386, 152);
            clienteUserControl1.Name = "clienteUserControl1";
            clienteUserControl1.Size = new Size(8, 8);
            clienteUserControl1.TabIndex = 25;
            // 
            // txtValorDevido
            // 
            txtValorDevido.Location = new Point(316, 197);
            txtValorDevido.Name = "txtValorDevido";
            txtValorDevido.ReadOnly = true;
            txtValorDevido.Size = new Size(75, 23);
            txtValorDevido.TabIndex = 26;
            // 
            // txtPagarDivida
            // 
            txtPagarDivida.Enabled = false;
            txtPagarDivida.Location = new Point(329, 230);
            txtPagarDivida.Name = "txtPagarDivida";
            txtPagarDivida.Size = new Size(65, 23);
            txtPagarDivida.TabIndex = 29;
            // 
            // cbxPagarDivida
            // 
            cbxPagarDivida.BackColor = Color.Thistle;
            cbxPagarDivida.CheckAlign = ContentAlignment.MiddleRight;
            cbxPagarDivida.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbxPagarDivida.Location = new Point(213, 230);
            cbxPagarDivida.Name = "cbxPagarDivida";
            cbxPagarDivida.Size = new Size(113, 21);
            cbxPagarDivida.TabIndex = 30;
            cbxPagarDivida.Text = "Pagar Dívida?";
            cbxPagarDivida.UseVisualStyleBackColor = false;
            cbxPagarDivida.CheckedChanged += cbxPagarDivida_CheckedChanged;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Lady_Party_Tela__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(405, 526);
            Controls.Add(cbxPagarDivida);
            Controls.Add(txtPagarDivida);
            Controls.Add(txtValorDevido);
            Controls.Add(clienteUserControl1);
            Controls.Add(label8);
            Controls.Add(txtValorEntrada);
            Controls.Add(label10);
            Controls.Add(txtValorTema);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            Controls.Add(labelTitulo);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(cbnTemas);
            Controls.Add(label3);
            Controls.Add(cbnClientes);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "TelaAluguelForm";
            Text = "Cadastro de Aluguel";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtValorEntrada).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPagarDivida).EndInit();
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
        private Label labelTitulo;
        private GroupBox groupBox1;
        private Label label9;
        private Label txtValorTema;
        private ContextMenuStrip contextMenuStrip1;
        private Label label10;
        private NumericUpDown txtValorEntrada;
        private Label label8;
        private ModuloCliente.ClienteUserControl clienteUserControl1;
        private TextBox txtValorDevido;
        private NumericUpDown txtPagarDivida;
        private CheckBox cbxPagarDivida;
    }
}