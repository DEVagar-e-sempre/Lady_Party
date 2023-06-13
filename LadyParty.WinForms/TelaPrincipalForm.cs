using LadyParty.WinForms.ModuloEvento;
using LadyParty.WinForms.ModuloTema;

namespace LadyParty.WinForms
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase ctrl;
        private RepositorioArquivoTema repTema = new RepositorioArquivoTema();
        //private RepositorioArquivoTema repEV = new RepositorioEvento();

        private static TelaPrincipalForm telaPrincipal;

        public TelaPrincipalForm()
        {
            InitializeComponent();

            lbl_status.Text = "";
            this.ConfigurarTelas();
            Desabilitador();
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
        private void Desabilitador()
        {
            btn_inserir.Enabled = false;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;

            btn_filtrar.Enabled = false;
        }

        private void Habilitador()
        {
            btn_inserir.Enabled = true;
            btn_editar.Enabled = true;
            btn_excluir.Enabled = true;

            if (ctrl is ControladorTema || ctrl is ControladorEvento)
            {
                btn_filtrar.Enabled = true;
            }
        }

        private void btn_temas_Click_1(object sender, EventArgs e)
        {
            ctrl = new ControladorTema(repTema);

            Desabilitador();
            Habilitador();

            ConfigurarTelaPrincipal(ctrl);
        }
        private void btn_cliente_Click(object sender, EventArgs e)
        {
            ctrl = new ControladorTema(repTema);

            Desabilitador();
            Habilitador();

            ConfigurarTelaPrincipal(ctrl);
        }

        private void btn_compra_Click(object sender, EventArgs e)
        {
            //ctrl = new ControladorTema(repTema);

            //Desabilitador();
            //Habilitador();

            //ConfigurarTelaPrincipal(ctrl);
        }

        private void btn_evento_Click(object sender, EventArgs e)
        {
            //ctrl = new ControladorEvento(repTema);

            //Desabilitador();
            //Habilitador();

            //ConfigurarTelaPrincipal(ctrl);
        }

        private void ConfigurarTelaPrincipal(ControladorBase ctrlBase)
        {
            lbl_tipoCad.Text = ctrlBase.ObterTipoCadastro;

            ConfigurarToolTips(ctrl);

            ConfigurarListagem(ctrl);
        }

        private void ConfigurarListagem(ControladorBase ctrlBase)
        {

            UserControl listagem = ctrlBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            pnl_principal.Controls.Clear();//precisa disso para limpar o painel principal e poder
                                           //colocar outro painel por cima, sem que haja conflito

            pnl_principal.Controls.Add(listagem);

        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btn_inserir.ToolTipText = controlador.ToolTipInserir;
            btn_editar.ToolTipText = controlador.ToolTipEditar;
            btn_excluir.ToolTipText = controlador.ToolTipExcluir;

            btn_filtrar.ToolTipText = controlador.ToolTipFiltrar;
        }

        public void AtualizarRodape(string msg)
        {
            lbl_status.Text = msg;
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            ctrl.Inserir();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            ctrl.Editar();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            ctrl.Excluir();
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            ctrl.Filtrar();
        }
    }
}