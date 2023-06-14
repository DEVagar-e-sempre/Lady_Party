using LadyParty.WinForms.ModuloAluguel;
using LadyParty.WinForms.ModuloCliente;
using LadyParty.WinForms.ModuloTema;

namespace LadyParty.WinForms
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private RepositorioArquivoCliente repCliente = new RepositorioArquivoCliente();
        private RepositorioArquivoTema repTema = new RepositorioArquivoTema();
        private RepositorioArquivoItemTema repItem = new RepositorioArquivoItemTema();
        private RepositorioArquivoAluguel repEvento = new RepositorioArquivoAluguel();

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

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            lbl_tipoCad.Text = controladorBase.ObterTipoCadastro;

            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);
        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {

            UserControl listagem = controladorBase.ObterListagem();

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
            btn_addItem.ToolTipText = controlador.ToolTipAdd;
        }

        public void AtualizarRodape(string msg)
        {
            lbl_status.Text = msg;
        }
        private void botaoBarraFerramentas_Click(object sender, EventArgs e)
        {
            ToolStripButton botaoCliclado = (ToolStripButton)sender;

            switch (botaoCliclado.Name)
            {
                case "btn_inserir":
                    controlador.Inserir();
                    break;
                case "btn_editar":
                    controlador.Editar();
                    break;
                case "btn_excluir":
                    controlador.Excluir();
                    break;
                case "btn_filtrar":
                    controlador.Filtrar();
                    break;
                case "btn_addItem":
                    controlador.AddItem();
                    break;
                default:
                    break;
            }
        }
        private void selecaoModulo_Click(object sender, EventArgs e)
        {
            ToolStripButton itemClicado = (ToolStripButton)sender;

            switch (itemClicado.Name)
            {
                case "btn_cliente":
                    controlador = new ControladorCliente(repCliente);
                    break;
                case "btn_tema":
                    controlador = new ControladorTema(repTema, repItem);
                    break;
                case "btn_evento":
                    controlador = new ControladorAluguel(repEvento, repCliente, repTema);
                    break;
                default:
                    break;
            }
            ConfigurarEstados(controlador);

            ConfigurarTelaPrincipal(controlador);
        }
        private void ConfigurarEstados(ControladorBase controlador)
        {
            //desnecessário. Já que todos serão habilitados, não precisa mexer neles
            btn_inserir.Enabled = controlador.InserirHabilitado;
            btn_editar.Enabled = controlador.EditarHabilitado;
            btn_excluir.Enabled = controlador.ExcluirHabilitado;
            btn_addItem.Enabled = controlador.AddItemHabilitado;
            btn_filtrar.Enabled = controlador.FiltrarHabilitado;
        }
    }
}