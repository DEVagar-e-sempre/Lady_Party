using System.Security.Cryptography;

namespace LadyParty.WinForms.ModuloTema
{
    public partial class TelaCadastroTema : Form, ITelaBase
    {
        private Tema tema;
        public TelaCadastroTema()
        {
            InitializeComponent();

            InicializarCheckedList();
        }

        public void InicializarCheckedList()
        {
            if (checkedList.Items.Count == 0)
            {
                checkedList.Items.Add("Personagens");
                checkedList.Items.Add("Doces tematizados");
                checkedList.Items.Add("Salgados");
                checkedList.Items.Add("Bebidas");
                checkedList.Items.Add("Centro de mesa");
                checkedList.Items.Add("Enfeite de parede");
                checkedList.Items.Add("Balões coloridos");
                checkedList.Items.Add("Bonecos para mesa");
                checkedList.Items.Add("Potes com balas para mesa");
                checkedList.Items.Add("Balas");
                checkedList.Items.Add("Chicletes");
                checkedList.Items.Add("Bombons");
                checkedList.Items.Add("Lembrancinha");
            }
        }

        private List<string> VerificarItensSelec()
        {
            List<string> list = new List<string>();

            foreach (string item in checkedList.SelectedItems)
            {
                list.Add(item);
            }

            return list;
        }

        public void AtualizarPainelCadastro(Tema entidadeSelec)
        {
            txb_nomeTema.Text = entidadeSelec.nomeTema;
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm tlPrinc = TelaPrincipalForm.TelaPrincipal;
            
            string nome = txb_nomeTema.Text;

            List<string> listaItens = VerificarItensSelec();

            tema = new Tema(nome, listaItens);

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

        public Tema PegarDadosTela<T>()
        {
            return tema;
        }

        public void AtualizarPainelCadastro<T>(Tema entidade)
        {
            txb_nomeTema.Text = entidade.nomeTema;
        }
    }
}
