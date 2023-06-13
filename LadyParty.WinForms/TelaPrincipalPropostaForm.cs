using LadyParty.WinForms.Compartilhado;
using LadyParty.WinForms.ModuloEvento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LadyParty.WinForms
{
    public partial class TelaPrincipalPropostaForm : Form
    {
        private RepositorioArquivoBase<Evento> repEvento;

        private ControladorBase controlador;
        private static TelaPrincipalPropostaForm telaPrincipalProspostaForm;
        public TelaPrincipalPropostaForm()
        {
            InitializeComponent();
        }
        public static TelaPrincipalPropostaForm Instancia
        {
            get
            {
                if (telaPrincipalProspostaForm == null)
                    telaPrincipalProspostaForm = new TelaPrincipalPropostaForm();

                return telaPrincipalProspostaForm;
            }
        }
        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }
        private void toolStripItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem itemClicado = (ToolStripMenuItem)sender;
            switch (itemClicado.Name)
            {
                case "clientesMenuItem":
                    //controlador = new ;
                    break;
                case "temasMenuItem":
                    //controlador = new ;
                    break;
                case "eventosMenuItem":
                    controlador = new ControladorEvento(repEvento);
                    break;
                default:
                    break;
            }
            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);

            ConfigurarTelaPrincipal(controlador);
        }
        private void botaoBarraFerramentas_Click(object sender, EventArgs e)
        {
            ToolStripButton botaoCliclado = (ToolStripButton)sender;
            switch (botaoCliclado.Name)
            {
                case "btnInserir":
                    controlador.Inserir();
                    break;
                case "btnEditar":
                    controlador.Editar();
                    break;
                case "btnExcluir":
                    controlador.Excluir();
                    break;
                case "btnFiltrar":
                    controlador.Filtrar();
                    break;
                default:
                    break;
            }
        }
        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            labelTipoCadastro.Text = controladorBase.ObterTipoCadastro;

            tsBarraFerramentas.Enabled = true;

            ConfigurarToolTips(controladorBase);

            ConfigurarEstados(controlador);

            ConfigurarListagem(controladorBase);

        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl tabela = controladorBase.ObterListagem();

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(tabela);
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            //btnInserir.ToolTipText = controlador.ToolTipInserir;
            //btnEditar.ToolTipText = controlador.ToolTipEditar;
            //btnExcluir.ToolTipText = controlador.ToolTipExcluir;
            //btnFiltrar.ToolTipText = controlador.ToolTipFiltrar;
            //btnAdicionarItens.ToolTipText = controlador.ToolTipAdicionarItens;
            //btnConcluirItens.ToolTipText = controlador.ToolTipConcluirItens;
        }

        private void ConfigurarEstados(ControladorBase controlador)
        {
            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnExcluir.Enabled = controlador.ExcluirHabilitado;
            btnFiltrar.Enabled = controlador.FiltrarHabilitado;
            btnAdicionarItens.Enabled = controlador.AdicionarItensHabilitado;
            btnConcluirItens.Enabled = controlador.ConcluirItensHabilitado;
        }
    }
}
