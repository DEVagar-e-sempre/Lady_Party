using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LadyParty.WinForms.ModuloTema;

namespace LadyParty.WinForms.ModuloCliente
{
    public partial class ClienteUserControl : UserControl
    {
        public ClienteUserControl()
        {
            InitializeComponent();
            grid.ConfigurarGrid();
            grid.ConfigurarGridZebrado();
        }

        private void ConfigurarColunas()
        {
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Name = "ID";
            id.HeaderText = "ID";

            DataGridViewTextBoxColumn nomeCliente = new DataGridViewTextBoxColumn();
            nomeCliente.Name = "nome";
            nomeCliente.HeaderText = "Nome do Cliente";

            DataGridViewTextBoxColumn telefoneCliente = new DataGridViewTextBoxColumn();
            telefoneCliente.Name = "listaClientes";
            telefoneCliente.HeaderText = "Telefone";

            grid.Columns.AddRange(id);
            grid.Columns.AddRange(nomeCliente);
            grid.Columns.AddRange(telefoneCliente);
        }

        public void AtualizarRegistros(List<Cliente> listaClientes)
        {
            grid.Rows.Clear();

            foreach (Cliente cliente in listaClientes)
            {
                grid.Rows.Add(cliente.id, cliente.nomeCliente, cliente.telefoneCliente);
            }
        }

        public int ObterIdSelecionado()
        {
            return Convert.ToInt32(grid.SelectedRows[0].Cells[0].Value);
        }
    }
}
