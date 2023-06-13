using LadyParty.WinForms.ModuloCliente;
using LadyParty.WinForms.ModuloTema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LadyParty.WinForms.ModuloEvento
{
    public partial class TabelaEventoUserControl : UserControl
    {
        public TabelaEventoUserControl()
        {
            InitializeComponent();
            this.ConfigurarUserControl();
            gridTabela.ConfigurarGrid();
            gridTabela.ConfigurarGridZebrado();
        }
        public void AtualizarTabela(RepositorioArquivoBase<Evento> repEvento, RepositorioArquivoBase<Cliente> repCliente, RepositorioArquivoBase<Tema> repTema)
        {
            gridTabela.Rows.Clear();

            foreach (var evento in repEvento.SelecionarTodos())
            {
                Cliente cliente = repCliente.SelecionarPorId(evento.idCliente);
                Tema tema = repTema.SelecionarPorId(evento.idTema);
                gridTabela.Rows.Add(evento.id, cliente.nome, tema.temaNome, evento.endereco, evento.data.ToShortDateString(), evento.horaInicio.ToString(@"hh\:mm"), evento.horaTermino.ToString(@"hh\:mm"));
            }
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn() { Name  = "id", HeaderText = "ID" },
                new DataGridViewTextBoxColumn() { Name  = "Cliente", HeaderText = "Cliente" },
                new DataGridViewTextBoxColumn() { Name  = "Tema", HeaderText = "Tema" },
                new DataGridViewTextBoxColumn() { Name  = "Endereco", HeaderText = "Endereço"},
                new DataGridViewTextBoxColumn() { Name  = "Data", HeaderText = "Data" },
                new DataGridViewTextBoxColumn() { Name  = "HoraInicio", HeaderText = "Hora de Início" },
                new DataGridViewTextBoxColumn() { Name  = "HoraTermino", HeaderText = "Hora de Término" },
            };
            gridTabela.Columns.AddRange(colunas);
        }
        public int ObterIdSelecionado()
        {
            if (gridTabela.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(gridTabela.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
