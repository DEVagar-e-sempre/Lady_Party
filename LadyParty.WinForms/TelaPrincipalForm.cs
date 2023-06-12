using LadyParty.WinForms.ModuloTema;

namespace LadyParty.WinForms
{
    public partial class TelaPrincipalForm : Form
    {
        private RepositorioArquivoTema repTema = new RepositorioArquivoTema();
        private TelaCadastroTema telaCadTema = new TelaCadastroTema();
        private static TelaPrincipalForm telaPrincipal;

        public TelaPrincipalForm()
        {
            InitializeComponent();

            lbl_status.Text = "";
            this.ConfigurarTelas();
        }

        public static TelaPrincipalForm TelaPrincipal
        {
            get
            {
                if (telaPrincipal == null)
                {
                    telaPrincipal = new TelaPrincipalForm();
                }

                return telaPrincipal;

            }
        }

        private void btn_temas_Click(object sender, EventArgs e)
        {
            ControladorBase<Tema, TelaCadastroTema> ctrlTema = new ControladorTema(repTema);

            ConfigurarListagem(ctrlTema);
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {

        }

        private void btn_loja_Click(object sender, EventArgs e)
        {

        }

        private void btn_festas_Click(object sender, EventArgs e)
        {

        }

        private void ConfigurarListagem<T>(T ctrlBase)
        {

            UserControl listagem = ctrlBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            pnl_principal.Controls.Clear();//precisa disso para limpar o painel principal e poder
                                           //colocar outro painel por cima, sem que haja conflito

            pnl_principal.Controls.Add(listagem);

        }

        public void AtualizarRodape(string msg)
        {
            lbl_status.Text = msg;
        }

    }
}