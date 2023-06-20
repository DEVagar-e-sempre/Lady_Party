using LadyParty.WinForms.ModuloItemTema;

namespace LadyParty.WinForms.ModuloTema
{
    public partial class TelaCadastroTema : Form
    {
        private Tema tema;
        public TelaCadastroTema(List<ItemTema> listaItens)
        {
            InitializeComponent();

            this.ConfigurarTelas();
            txb_id.ReadOnly = true;

            CarregarItens(listaItens);
        }

        private void CarregarItens(List<ItemTema> listaItens)
        {
            foreach (ItemTema item in listaItens)
            {
                checkedList.Items.Add(item);
            }
        }

        public Tema Tema
        {
            set
            {
                txb_nomeTema.Text = value.nomeTema;
                txb_preco.Text = value.preco.ToString();
                txb_id.Text = value.id.ToString();
            }
            get
            {
                return tema;
            }
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm tlPrinc = TelaPrincipalForm.TelaPrincipal;

            int id = Convert.ToInt32(txb_id.Text);

            string nome = txb_nomeTema.Text;

            if (decimal.TryParse(txb_preco.Text, out decimal preco) == false)
            {
                txb_preco.Text = "0";
                preco = 0;
            }

            tema = new Tema(nome, preco);

            tema.id = id;

            tema.CalcularValorTotal();

            string[] erros = tema.Validar();

            if (erros.Length > 0)
            {
                tlPrinc.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
            else
            {
                tlPrinc.AtualizarRodape("");
            }
        }

        public void DefinirID(int id)
        {
            txb_id.Text = id.ToString();
        }
    }
}
