namespace LadyParty.WinForms.ModuloCliente
{
    partial class ClienteUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grid = new DataGridView();
            lblClientes = new Label();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // grid
            // 
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new Point(118, 167);
            grid.Name = "grid";
            grid.RowTemplate.Height = 25;
            grid.Size = new Size(449, 243);
            grid.TabIndex = 0;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.BackColor = Color.Transparent;
            lblClientes.Font = new Font("Segoe Print", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblClientes.Location = new Point(252, 66);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(171, 65);
            lblClientes.TabIndex = 1;
            lblClientes.Text = "Clientes";
            // 
            // ClienteUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Lady_Party_Tela__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lblClientes);
            Controls.Add(grid);
            DoubleBuffered = true;
            Name = "ClienteUserControl";
            Size = new Size(678, 466);
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grid;
        private Label lblClientes;
    }
}
