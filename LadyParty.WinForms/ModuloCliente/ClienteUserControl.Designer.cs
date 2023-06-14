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
            label1 = new Label();
            grid = new DataGridView();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Thistle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe Print", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(284, 51);
            label1.TabIndex = 13;
            label1.Text = "Tabela de Clientes";
            // 
            // grid
            // 
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Dock = DockStyle.Fill;
            grid.Location = new Point(0, 0);
            grid.Name = "grid";
            grid.RowTemplate.Height = 25;
            grid.Size = new Size(411, 195);
            grid.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Lady_Party_Tela__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(465, 394);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(grid);
            panel1.Location = new Point(31, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 195);
            panel1.TabIndex = 14;
            // 
            // ClienteUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "ClienteUserControl";
            Size = new Size(465, 394);
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView grid;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
