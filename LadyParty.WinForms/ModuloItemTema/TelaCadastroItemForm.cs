using LadyParty.WinForms.ModuloItemTema;

namespace LadyParty.WinForms.ModuloTema
{
    public partial class TelaCadastroItemForm : Form
    {
        private ItemTema item;
        private RepositorioArquivoItemTema repItem;
        public TelaCadastroItemForm(RepositorioArquivoItemTema repItem)
        {
            InitializeComponent();

            this.ConfigurarTelas();

            this.repItem = repItem;
        }

        public ItemTema Item
        {
            set
            {
                txb_descricao.Text = value.descricao;
                txb_preco.Text = value.preco.ToString();
                txb_id.Text = value.id.ToString();
            }
            get
            {
                return item;
            }
        }

        public void DefinirID(int id)
        {
            txb_id.Text = id.ToString();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm tlPrinc = TelaPrincipalForm.TelaPrincipal;

            bool ehRepetido = false;
            int id = Convert.ToInt32(txb_id.Text);
            string descricao = txb_descricao.Text;

            foreach (ItemTema item in repItem.SelecionarTodos())
            {
                if(descricao.Equals(item.descricao, StringComparison.InvariantCultureIgnoreCase))
                {
                    MessageBox.Show("Não pode dar a mesma descrição para os dois itens!");
                    DialogResult = DialogResult.None;
                    ehRepetido = true;
                    
                }
            }

            if (ehRepetido == false)
            {
                if (decimal.TryParse(txb_preco.Text, out decimal preco) == false)
                {
                    txb_preco.Text = "0";
                    preco = 0;
                }

                item = new ItemTema(descricao, preco);

                item.id = id;

                string[] erros = item.Validar();

                if (erros.Length > 0)
                {
                    tlPrinc.AtualizarRodape(erros[0]);
                    DialogResult = DialogResult.None;
                }
                else
                {
                    tlPrinc.AtualizarRodape("");

                    txb_descricao.Text = "";
                    txb_preco.Text = "";
                }
            }
        }
    }
}
