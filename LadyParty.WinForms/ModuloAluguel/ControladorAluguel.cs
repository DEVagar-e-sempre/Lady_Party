using LadyParty.WinForms.Compartilhado;
using LadyParty.WinForms.ModuloCliente;
using LadyParty.WinForms.ModuloTema;
using static System.Net.Mime.MediaTypeNames;

namespace LadyParty.WinForms.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private DateTime dataInicial;
        private DateTime dataFinal;

        private TabelaAluguelUserControl tabelaAluguel;

        private RepositorioArquivoAluguel repAluguel;

        private RepositorioArquivoCliente repCliente;

        private RepositorioArquivoTema repTema;
        private TelaFiltroAluguelForm telaFiltroAluguel;



        public ControladorAluguel(RepositorioArquivoAluguel repAluguel, RepositorioArquivoCliente repCliente, RepositorioArquivoTema repTema)
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
