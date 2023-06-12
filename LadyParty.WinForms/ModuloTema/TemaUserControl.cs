namespace LadyParty.WinForms.ModuloTema
{
    public partial class TemaUserControl : UserControl
    {
        public TemaUserControl()
        {
            InitializeComponent();

            ConfigurarColunas();
            grid.ConfigurarGrid();
            grid.ConfigGridSoLeitura();
        }

        private void ConfigurarColunas()
        {
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Name = "ID";
            id.HeaderText = "ID";

            DataGridViewTextBoxColumn nomeTema = new DataGridViewTextBoxColumn();
            nomeTema.Name = "nome";
            nomeTema.HeaderText = "Nome do Tema";

            DataGridViewTextBoxColumn listaItens = new DataGridViewTextBoxColumn();
            listaItens.Name = "listaItens";
            listaItens.HeaderText = "Quantidade de Itens";

            grid.Columns.AddRange(id);
            grid.Columns.AddRange(nomeTema);
            grid.Columns.AddRange(listaItens);
        }

        //public void AtualizarRegistros(List<Tema> listaTemas)
        //{
        //    grid.Rows.Clear();

        //    foreach (Tema tema in listaTemas)
        //    {
        //        grid.Rows.Add(tema.id, tema.nomeTema, tema.listaItens.Count);
        //    }
        //}

        public int ObterIdSelecionado()
        {
            return Convert.ToInt32(grid.SelectedRows[0].Cells[0].Value);
        }

        public void AtualizarRegistros<T>(List<T> listaEntidade) where T : Tema
        {
            grid.Rows.Clear();

            foreach (Tema tema in listaEntidade)
            {
                grid.Rows.Add(tema.id, tema.nomeTema, tema.listaItens.Count);
            }
        }
    }
}
