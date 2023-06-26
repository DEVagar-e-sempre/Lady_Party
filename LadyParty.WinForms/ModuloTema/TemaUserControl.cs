using LadyParty.Dominio.ModuloTema;

namespace LadyParty.WinForms.ModuloTema
{
    public partial class TemaUserControl : UserControl
    {
        public TemaUserControl()
        {
            InitializeComponent();

            ConfigurarColunas();
            grid.ConfigurarGrid();
            grid.ConfigurarGridZebrado();
        }

        private void ConfigurarColunas()
        {
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Name = "ID";
            id.HeaderText = "ID";

            DataGridViewTextBoxColumn nomeTema = new DataGridViewTextBoxColumn();
            nomeTema.Name = "nome";
            nomeTema.HeaderText = "Nome do Tema";

            DataGridViewTextBoxColumn preco = new DataGridViewTextBoxColumn();
            preco.Name = "preco";
            preco.HeaderText = "Preço";

            DataGridViewTextBoxColumn listaItens = new DataGridViewTextBoxColumn();
            listaItens.Name = "listaItens";
            listaItens.HeaderText = "Quantidade de Itens";

            grid.Columns.AddRange(id);
            grid.Columns.AddRange(nomeTema);
            grid.Columns.AddRange(preco);
            grid.Columns.AddRange(listaItens);
        }

        public void AtualizarRegistros(List<Tema> listaTemas)
        {
            grid.Rows.Clear();

            foreach (Tema tema in  listaTemas)
            {
                grid.Rows.Add(tema.id, tema.nomeTema, tema.CalcularValorTotal(), tema.listaItens.Count);
            }
        }

        public int ObterIdSelecionado()
        {
            if (grid.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(grid.SelectedRows[0].Cells["ID"].Value);

            return id;
        }
    }
}
