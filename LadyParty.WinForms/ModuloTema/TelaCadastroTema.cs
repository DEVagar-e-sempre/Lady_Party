using System.Security.Cryptography;

namespace LadyParty.WinForms.ModuloTema
{
    public partial class TelaCadastroTema : Form
    {
        private Tema tema;
        public TelaCadastroTema()
        {
            InitializeComponent();

            this.ConfigurarTelas();
            InicializarCheckedList();
            txb_id.ReadOnly = true;
        }

        public void InicializarCheckedList()
        {

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

            string nome = txb_nomeTema.Text;

            decimal preco = Convert.ToDecimal(txb_preco.Text);

            tema = new Tema(nome, preco);

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
