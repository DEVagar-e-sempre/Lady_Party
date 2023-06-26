using LadyParty.Dominio.ModuloAluguel;
using LadyParty.Dominio.ModuloTema;
using LadyParty.Infra.Compartilhado;
using LadyParty.WinForms.ModuloCliente;

namespace LadyParty.WinForms.ModuloAluguel
{
    public partial class TabelaAluguelUserControl : UserControl
    {
        public TabelaAluguelUserControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            this.ConfigurarUserControl();
            gridTabela.ConfigurarGrid();
            gridTabela.ConfigurarGridZebrado();
        }
        public void AtualizarTabela(List<Aluguel> listaEventos, RepositorioArquivoBase<Cliente> repCliente, RepositorioArquivoBase<Tema> repTema)
        {
            gridTabela.Rows.Clear();

            foreach (var aluguel in listaEventos)
            {
                Cliente cliente = repCliente.SelecionarPorId(aluguel.idCliente);
                Tema tema = repTema.SelecionarPorId(aluguel.idTema);
                //Deve exibir: Id, Nome do Cliente, Telefone do Cliente, Tema, Data e Valor Total
                gridTabela.Rows.Add(aluguel.id, cliente.nomeCliente,cliente.telefoneCliente, tema.nomeTema, aluguel.festa.data.ToShortDateString(), aluguel.valorAluguel);
            }
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn() { Name  = "id", HeaderText = "ID" },
                new DataGridViewTextBoxColumn() { Name  = "Cliente", HeaderText = "Cliente" },
                new DataGridViewTextBoxColumn() { Name  = "Telefone", HeaderText = "Telefone" },
                new DataGridViewTextBoxColumn() { Name  = "Tema", HeaderText = "Tema" },
                new DataGridViewTextBoxColumn() { Name  = "Data", HeaderText = "Data" },
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
