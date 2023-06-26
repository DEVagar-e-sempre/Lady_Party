using LadyParty.Infra.ModuloAluguel;
using LadyParty.Infra.ModuloCliente;
using LadyParty.Infra.ModuloItemTema;
using LadyParty.Infra.ModuloTema;
using LadyParty.WinForms.ModuloAluguel;
using LadyParty.WinForms.ModuloCliente;
using LadyParty.WinForms.ModuloItemTema;
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

        private ContextoDados contextoDados = new ContextoDados();

        private static TelaPrincipalForm telaPrincipal;
        private CancellationTokenSource cancellationTokenSource;
        private Thread threadSalvarDados;

        // no botão de adicionar item terá que mostrar uma tabela com os itens e fazer do jeito normal a inserção e etc

        public TelaPrincipalForm()
        {
            InitializeComponent();

            //Area da serialização
            contextoDados.CarregarDadosJson();
            contextoDados.PreencherRepositorios(repCliente, repTema, repItem, repEvento);

            cancellationTokenSource = new CancellationTokenSource();
            threadSalvarDados = new Thread(() => SalvarDados(cancellationTokenSource));
            threadSalvarDados.Start();

            //Fim da area da serialização

            lbl_status.Text = "";
            this.ConfigurarTelas();

            telaPrincipal = this;
        }

        public void SalvarDados(CancellationTokenSource cancellationTokenSource)
        {
            while (!cancellationTokenSource.Token.IsCancellationRequested)
            {
                contextoDados.GravarEmJson(repCliente, repTema, repItem, repEvento);
                Thread.Sleep(2000);
            }
        }

        private void TelaPrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
            threadSalvarDados.Join();
        }

        public static TelaPrincipalForm TelaPrincipal
        {
            get
            {
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
            btn_list.ToolTipText = controlador.ToolTipListar;
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
                    //instanciar controlador do item tema --> como acontece no metodo a baixo

                    controlador = new ControladorItemTema(repItem);

                    ConfigurarEstados(controlador);
                    ConfigurarTelaPrincipal(controlador);

                    break;
                case "btn_list":
                    controlador.Listar();
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
            btn_list.Enabled = controlador.ListarHabilitado;
        }
    }
}