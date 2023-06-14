namespace LadyParty.WinForms.ModuloTema
{
    public partial class TelaCadastroItemForm : Form
    {
        private ItemTema item;
        public TelaCadastroItemForm(Tema tema)
        {
            InitializeComponent();

            this.ConfigurarTelas();

            ConfigurarTelaItem(tema);
        }

        private void ConfigurarTelaItem(Tema tema)
        {
            txb_id.Text = tema.id.ToString();
            txb_tema.Text = tema.nomeTema;

            listBox_itens.Items.AddRange(tema.listaItens.ToArray());
        }

        public List<ItemTema> ObterItensCad()
        {
            return listBox_itens.Items.Cast<ItemTema>().ToList();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            string nome = txb_nome.Text;
            decimal preco = Convert.ToDecimal(txb_preco.Text);

            ItemTema item = new ItemTema(nome, preco);

            listBox_itens.Items.Add(item);

            txb_nome.Text = "";
            txb_preco.Text = "";
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            string nome = txb_nome.Text;
            decimal preco = Convert.ToDecimal(txb_preco.Text);

            this.item = new ItemTema(nome, preco);
        }
    }
}
