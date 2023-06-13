namespace LadyParty.WinForms.ModuloEvento
{
    partial class TelaFiltroEventoForm
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
            groupBox1 = new GroupBox();
            rbnIntervaloCustomizado = new RadioButton();
            rbnEventosAtuais = new RadioButton();
            rbnEventosAnteriores = new RadioButton();
            rbnVisualizarTodos = new RadioButton();
            rbnEventosHoje = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            labelDataFinal = new Label();
            txtDataFinal = new DateTimePicker();
            labelDataInicial = new Label();
            txtDataInicial = new DateTimePicker();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(rbnIntervaloCustomizado);
            groupBox1.Controls.Add(rbnEventosAtuais);
            groupBox1.Controls.Add(rbnEventosAnteriores);
            groupBox1.Controls.Add(rbnVisualizarTodos);
            groupBox1.Controls.Add(rbnEventosHoje);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(34, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(256, 185);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // rbnIntervaloCustomizado
            // 
            rbnIntervaloCustomizado.AutoSize = true;
            rbnIntervaloCustomizado.Location = new Point(42, 160);
            rbnIntervaloCustomizado.Name = "rbnIntervaloCustomizado";
            rbnIntervaloCustomizado.Size = new Size(182, 19);
            rbnIntervaloCustomizado.TabIndex = 4;
            rbnIntervaloCustomizado.Text = "Definir Intervalo Customizado";
            rbnIntervaloCustomizado.UseVisualStyleBackColor = true;
            rbnIntervaloCustomizado.CheckedChanged += rbnIntervaloCustomizado_CheckedChanged;
            // 
            // rbnEventosAtuais
            // 
            rbnEventosAtuais.AutoSize = true;
            rbnEventosAtuais.Location = new Point(42, 91);
            rbnEventosAtuais.Name = "rbnEventosAtuais";
            rbnEventosAtuais.Size = new Size(154, 19);
            rbnEventosAtuais.TabIndex = 3;
            rbnEventosAtuais.Text = "Visualizar Eventos Atuais";
            rbnEventosAtuais.UseVisualStyleBackColor = true;
            rbnEventosAtuais.CheckedChanged += rbnEventosAtuais_CheckedChanged;
            // 
            // rbnEventosAnteriores
            // 
            rbnEventosAnteriores.AutoSize = true;
            rbnEventosAnteriores.Location = new Point(42, 125);
            rbnEventosAnteriores.Name = "rbnEventosAnteriores";
            rbnEventosAnteriores.Size = new Size(175, 19);
            rbnEventosAnteriores.TabIndex = 2;
            rbnEventosAnteriores.Text = "Visualizar Eventos Anteriores";
            rbnEventosAnteriores.UseVisualStyleBackColor = true;
            rbnEventosAnteriores.CheckedChanged += rbnEventosAnteriores_CheckedChanged;
            // 
            // rbnVisualizarTodos
            // 
            rbnVisualizarTodos.AutoSize = true;
            rbnVisualizarTodos.Checked = true;
            rbnVisualizarTodos.Location = new Point(42, 22);
            rbnVisualizarTodos.Name = "rbnVisualizarTodos";
            rbnVisualizarTodos.Size = new Size(108, 19);
            rbnVisualizarTodos.TabIndex = 1;
            rbnVisualizarTodos.TabStop = true;
            rbnVisualizarTodos.Text = "Visualizar Todos";
            rbnVisualizarTodos.UseVisualStyleBackColor = true;
            rbnVisualizarTodos.CheckedChanged += rbnVisualizarTodos_CheckedChanged;
            // 
            // rbnEventosHoje
            // 
            rbnEventosHoje.AutoSize = true;
            rbnEventosHoje.Location = new Point(42, 57);
            rbnEventosHoje.Name = "rbnEventosHoje";
            rbnEventosHoje.Size = new Size(146, 19);
            rbnEventosHoje.TabIndex = 0;
            rbnEventosHoje.Text = "Visualizar Eventos Hoje";
            rbnEventosHoje.UseVisualStyleBackColor = true;
            rbnEventosHoje.CheckedChanged += rbnEventosHoje_CheckedChanged;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(110, 301);
            button1.Name = "button1";
            button1.Size = new Size(87, 40);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(203, 301);
            button2.Name = "button2";
            button2.Size = new Size(87, 40);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // labelDataFinal
            // 
            labelDataFinal.AutoSize = true;
            labelDataFinal.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDataFinal.Location = new Point(49, 254);
            labelDataFinal.Name = "labelDataFinal";
            labelDataFinal.Size = new Size(83, 21);
            labelDataFinal.TabIndex = 12;
            labelDataFinal.Text = "Data Inicial:";
            // 
            // txtDataFinal
            // 
            txtDataFinal.Enabled = false;
            txtDataFinal.Format = DateTimePickerFormat.Short;
            txtDataFinal.Location = new Point(138, 251);
            txtDataFinal.Name = "txtDataFinal";
            txtDataFinal.Size = new Size(102, 23);
            txtDataFinal.TabIndex = 11;
            txtDataFinal.ValueChanged += txtDataFinal_ValueChanged;
            // 
            // labelDataInicial
            // 
            labelDataInicial.AutoSize = true;
            labelDataInicial.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDataInicial.Location = new Point(49, 225);
            labelDataInicial.Name = "labelDataInicial";
            labelDataInicial.Size = new Size(83, 21);
            labelDataInicial.TabIndex = 10;
            labelDataInicial.Text = "Data Inicial:";
            // 
            // txtDataInicial
            // 
            txtDataInicial.Enabled = false;
            txtDataInicial.Format = DateTimePickerFormat.Short;
            txtDataInicial.Location = new Point(138, 222);
            txtDataInicial.Name = "txtDataInicial";
            txtDataInicial.Size = new Size(102, 23);
            txtDataInicial.TabIndex = 9;
            txtDataInicial.ValueChanged += txtDataInicial_ValueChanged;
            // 
            // TelaFiltroEventoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Lady_Party_Tela__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(324, 369);
            Controls.Add(labelDataFinal);
            Controls.Add(txtDataFinal);
            Controls.Add(labelDataInicial);
            Controls.Add(txtDataInicial);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "TelaFiltroEventoForm";
            Text = "Filtrar Eventos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbnEventosAtuais;
        private RadioButton rbnEventosAnteriores;
        private RadioButton rbnVisualizarTodos;
        private RadioButton rbnEventosHoje;
        private Button button1;
        private Button button2;
        private RadioButton rbnIntervaloCustomizado;
        private Label labelDataFinal;
        private DateTimePicker txtDataFinal;
        private Label labelDataInicial;
        private DateTimePicker txtDataInicial;
    }
}