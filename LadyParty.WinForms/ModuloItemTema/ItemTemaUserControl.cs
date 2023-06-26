using LadyParty.Dominio.ModuloItemTema;

namespace LadyParty.WinForms.ModuloItemTema
{
    public partial class ItemTemaUserControl : UserControl
    {
        public ItemTemaUserControl()
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

            DataGridViewTextBoxColumn descricao = new DataGridViewTextBoxColumn();
            descricao.Name = "descricao";
            descricao.HeaderText = "Descricao";

            DataGridViewTextBoxColumn preco = new DataGridViewTextBoxColumn();
            preco.Name = "preco";
            preco.HeaderText = "Preço";

            grid.Columns.AddRange(id);
            grid.Columns.AddRange(descricao);
            grid.Columns.AddRange(preco);
        }

        public void AtualizarRegistros(List<ItemTema> listaItens)
        {
            grid.Rows.Clear();

            foreach (ItemTema item in listaItens)
            {
                grid.Rows.Add(item.id, item.descricao, item.preco);
            }
        }

        public int ObterIdSelecionado()
        {
            if (grid.SelectedRows.Count == 0)
            {
                return -1;
            }

            int id = Convert.ToInt32(grid.SelectedRows[0].Cells["ID"].Value);

            return id;
        }
    }
}
