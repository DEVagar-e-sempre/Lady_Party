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

        public void DefinirID(int id)
        {
            txb_id.Text = id.ToString();
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
            TelaPrincipalForm tlPrinc = TelaPrincipalForm.TelaPrincipal;

            string nome = txb_nome.Text;

            if (decimal.TryParse(txb_preco.Text, out decimal preco) == false)
            {
                txb_preco.Text = "0";
                preco = 0;
            }

            ItemTema item = new ItemTema(nome, preco);

            string[] erros = item.Validar();

            if (erros.Length > 0)
            {
                tlPrinc.AtualizarRodape(erros[0]);
            }
            else
            {
                tlPrinc.AtualizarRodape("");
                listBox_itens.Items.Add(item);

                txb_nome.Text = "";
                txb_preco.Text = "";
            }

        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            string nome = txb_nome.Text;

            if (decimal.TryParse(txb_preco.Text, out decimal preco) == false)
            {
                txb_preco.Text = "0";
                preco = 0;
            }

            this.item = new ItemTema(nome, preco);
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {

        }
    }
}
