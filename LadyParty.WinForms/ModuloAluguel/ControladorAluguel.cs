using LadyParty.Dominio.ModuloAluguel;
using LadyParty.Infra.ModuloAluguel;
using LadyParty.Infra.ModuloCliente;
using LadyParty.Infra.ModuloTema;
using LadyParty.WinForms.ModuloCliente;

namespace LadyParty.WinForms.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private DateTime dataInicial;
        private DateTime dataFinal;

        private TabelaAluguelUserControl tabelaAluguel;

        private RepositorioAluguelSQL repAluguel;

        private RepositorioClienteSQL repCliente;

        private RepositorioTemaSQL repTema;

        private TelaFiltroAluguelForm telaFiltroAluguel;



        public ControladorAluguel(RepositorioAluguelSQL repAluguel, RepositorioClienteSQL repCliente, RepositorioTemaSQL repTema)
        {
            this.repAluguel = repAluguel;
            this.repCliente = repCliente;
            this.repTema = repTema;
        }

        public override string ObterTipoCadastro => "Aluguel";

        public override string ToolTipFiltrar => $"Filtrar Alugueis";

        public override bool FiltrarHabilitado => true;



        public override void Editar()
        {
            Aluguel aluguelSelecionado = ObterIdSelecionado();

            if (aluguelSelecionado == null)
            {
                MessageBox.Show($"Selecione um {ObterTipoCadastro} primeiro!",
                    "Edição de {ObterTipoCadastro}s",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            if (repCliente.SelecionarTodos().Count == 0)
            {
                MessageBox.Show("Não há clientes cadastrados, cadastre um cliente antes de Editar um aluguel", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (repTema.SelecionarTodos().Count == 0)
            {
                MessageBox.Show("Não há temas cadastrados, cadastre um tema antes de Editar um aluguel", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (aluguelSelecionado.Validar().Length > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, aluguelSelecionado.Validar()), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            TelaAluguelForm telaAluguel = new TelaAluguelForm(repAluguel, repCliente.SelecionarTodos(), repTema.SelecionarTodos());

            telaAluguel.ConfigurarTela(aluguelSelecionado, repCliente.SelecionarPorId(aluguelSelecionado.idCliente), repTema.SelecionarPorId(aluguelSelecionado.idTema));

            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel aluguel = telaAluguel.ObterAluguel();

                if (aluguel.StatusAluguel() == StatusAluguelEnum.Concluido && aluguelSelecionado.StatusAluguel() != StatusAluguelEnum.Concluido)
                {
                    Cliente auxCliente = repCliente.SelecionarPorId(aluguelSelecionado.idCliente);

                    auxCliente.IncrementarContadorDeAlugueis();

                    repCliente.Editar(auxCliente.id, auxCliente);
                }
                repAluguel.Editar(aluguelSelecionado.id, telaAluguel.ObterAluguel());
            }
            CarregarAlugueis(dataInicial, dataFinal);
        }

        private Aluguel ObterIdSelecionado()
        {
            int id = tabelaAluguel.ObterIdSelecionado();

            return repAluguel.SelecionarPorId(id);
        }

        public override void Excluir()
        {
            Aluguel aluguelSelecionado = ObterIdSelecionado();

            if (aluguelSelecionado == null)
            {
                MessageBox.Show($"Selecione um {ObterTipoCadastro} primeiro!",
                    $"Exclusão de {ObterTipoCadastro}",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            if (aluguelSelecionado.StatusAluguel() != StatusAluguelEnum.Concluido)
            {
                TelaPrincipalForm.TelaPrincipal.AtualizarRodape($"Não é possível excluir um {ObterTipoCadastro} que não esteja concluído!");
                MessageBox.Show($"Não é possível excluir um {ObterTipoCadastro} que não esteja concluído!",
                                $"Exclusão de {ObterTipoCadastro}",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show(
                $"Deseja excluir o {ObterTipoCadastro} selecionado?",
                $"Exclusão de {ObterTipoCadastro}",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Cliente auxCliente = repCliente.SelecionarPorId(aluguelSelecionado.idCliente);

                auxCliente.DecrementarContadorDeAlugueis();

                repAluguel.Excluir(aluguelSelecionado);

                CarregarAlugueis(dataInicial, dataFinal);
            }
        }

        public override void Inserir()
        {

            if (repCliente.SelecionarTodos().Count == 0)
            {
                MessageBox.Show("Não há clientes cadastrados, cadastre um cliente antes de cadastrar um aluguel", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (repTema.SelecionarTodos().Count == 0)
            {
                MessageBox.Show("Não há temas cadastrados, cadastre um tema antes de cadastrar um aluguel", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TelaAluguelForm telaAluguel = new TelaAluguelForm(repAluguel, repCliente.SelecionarTodos(), repTema.SelecionarTodos());

            telaAluguel.DefinirID(repAluguel.Contador);

            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel auxAluguel = telaAluguel.ObterAluguel();

                repAluguel.Inserir(auxAluguel);

                Cliente auxCliente = repCliente.SelecionarPorId(auxAluguel.idCliente);

                auxCliente.IncrementarContadorDeAlugueis();

                CarregarAlugueis(dataInicial, dataFinal);
            }
        }
        public override void Filtrar()
        {
            if (telaFiltroAluguel == null)
            {
                telaFiltroAluguel = new TelaFiltroAluguelForm();
            }
            DialogResult opcaoEscolhida = telaFiltroAluguel.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                telaFiltroAluguel.ObterDatas(out this.dataInicial, out this.dataFinal); ;
                CarregarAlugueis(dataInicial, dataFinal);
            }
        }
        private void CarregarAlugueis(DateTime dataInicial, DateTime dataFinal)
        {
            List<Aluguel> alugueis = repAluguel.SelecionarTodos();

            if (dataInicial == default(DateTime) && dataFinal == default(DateTime))
            {

            }
            else if (dataInicial == DateTime.Now.Date && dataFinal == DateTime.Now.Date)
            {
                alugueis = alugueis.Where(x => x.festa.data == dataInicial).ToList();
            }
            else if (dataInicial == DateTime.Now.Date && dataFinal == default(DateTime))
            {
                alugueis = alugueis.Where(x => x.festa.data >= dataInicial).ToList();
            }
            else if (dataInicial == default(DateTime) && dataFinal == DateTime.Now.Date)
            {
                alugueis = alugueis.Where(x => x.festa.data < dataFinal).ToList();
            }
            else if (dataInicial != default(DateTime) && dataFinal != default(DateTime))
            {
                alugueis = alugueis.Where(x => x.festa.data >= dataInicial && x.festa.data <= dataFinal).ToList();
            }
            tabelaAluguel.AtualizarTabela(alugueis, repCliente, repTema);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaAluguel == null)
            {
                tabelaAluguel = new TabelaAluguelUserControl();
            }
            tabelaAluguel.AtualizarTabela(repAluguel.SelecionarTodos(), repCliente, repTema);
            return tabelaAluguel;
        }
    }
}
