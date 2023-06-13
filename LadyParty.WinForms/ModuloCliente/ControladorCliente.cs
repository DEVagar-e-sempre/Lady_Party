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
        private ClienteUserControl tabelaCliente;
        private RepositorioArquivoBase<Cliente> repCliente;

        public ControladorCliente(RepositorioArquivoBase<Cliente> repCliente)
        {
            this.repCliente = repCliente;
        }
        public override string ObterTipoCadastro => "Cliente";

        public override void Inserir()
        {
            TelaClienteForm telaCliente = new TelaClienteForm();

            telaCliente.DefinirID(repCliente.Contador);

            DialogResult opcaoEscolhida = telaCliente.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repCliente.Inserir(telaCliente.ObterCliente());
                CarregarCliente();
            }
        }
        private void CarregarCliente()
        {

            List<Cliente> clientes = repCliente.SelecionarTodos();

            tabelaCliente.AtualizarRegistros(clientes);
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }


        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
