using LadyParty.Dominio.ModuloItemTema;
using LadyParty.Dominio.ModuloTema;
using LadyParty.Infra.ModuloTema;

namespace LadyParty.WinForms.ModuloTema
{
    public partial class TelaCadastroTema : Form
    {
        private RepositorioArquivoTema repTema;
        private Tema tema;
        public TelaCadastroTema(List<ItemTema> listaItens, RepositorioArquivoTema repTema)
        {
            InitializeComponent();

            this.ConfigurarTelas();
            txb_id.ReadOnly = true;

            this.repTema = repTema;

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

            bool ehRepetido = false;

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
            else if (repTema.EhRepetido(tema))
            {
                tlPrinc.AtualizarRodape("Não pode dar o mesmo Nome para os dois Temas!");
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
