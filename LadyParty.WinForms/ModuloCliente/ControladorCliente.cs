using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LadyParty.WinForms.ModuloTema;

namespace LadyParty.WinForms.ModuloCliente
{
    internal class ControladorCliente : ControladorBase
    {
        private TelaClienteForm telaCliente;
        private ClienteUserControl tabelaCliente;
        private RepositorioArquivoCliente repCliente;

        public ControladorCliente(RepositorioArquivoCliente repCliente)
        {
            this.repCliente = repCliente;
        }
        public override string ObterTipoCadastro => "Cliente";

        //public override bool FiltrarHabilitado => true;

        public override void Inserir()
        {
            TelaClienteForm telaCliente = new TelaClienteForm();

            telaCliente.DefinirID(repCliente.Contador);

            DialogResult opcaoEscolhida = telaCliente.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repCliente.Inserir(telaCliente.Cliente);
                MessageBox.Show("Cliente gravado com Sucesso!");
                CarregarClientes();
                //repCliente.Serializador();
            }
        }
        private void CarregarClientes()
        {
            List<Cliente> clientes = repCliente.SelecionarTodos();

            tabelaCliente.AtualizarRegistros(clientes);
        }

        public override void Editar()
        {
            Cliente clienteSelec = ObterClienteSelecionado();

            if (clienteSelec == null)
            {
                MessageBox.Show($"Selecione um Cliente primeiro!",
                    "Edição de Clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                telaCliente = new TelaClienteForm();
                telaCliente.Cliente = clienteSelec;
                telaCliente.DefinirID(clienteSelec.id);

                DialogResult opcao = telaCliente.ShowDialog();

                if (opcao == DialogResult.OK)
                {
                    repCliente.Editar(telaCliente.Cliente.id, telaCliente.Cliente);

                    CarregarClientes();

                    //repCliente.Serializador();
                }
            }
        }
        private Cliente ObterClienteSelecionado()
        {
            int id = tabelaCliente.ObterIdSelecionado();

            return repCliente.SelecionarPorId(id);
        }

        public override void Excluir()
        {
            Cliente clienteSelec = ObterClienteSelecionado();

            if (clienteSelec == null)
            {
                MessageBox.Show($"Selecione um Cliente primeiro!",
                    "Edição de Clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o Cliente {clienteSelec.nomeCliente}?",
                    "Exclusão de Clientes",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (opcaoEscolhida == DialogResult.OK)
                {
                    repCliente.Excluir(clienteSelec);

                    CarregarClientes();

                    //repCliente.Serializador();
                }
            }
        }
        public override UserControl ObterListagem()
        {
            if (tabelaCliente == null)
            {
                tabelaCliente = new ClienteUserControl();
            }

            CarregarClientes();

            return tabelaCliente;
        }
    }
}
