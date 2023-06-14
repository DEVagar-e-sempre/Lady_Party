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


        public ControladorAluguel(RepositorioArquivoAluguel repAluguel, RepositorioArquivoCliente repCliente, RepositorioArquivoTema repTema)
        {
            this.repAluguel = repAluguel;
            this.repCliente = repCliente;
            this.repTema = repTema;
        }

        public override string ObterTipoCadastro => "Aluguel";

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

            TelaAluguelForm telaAluguel = new TelaAluguelForm();

            telaAluguel.CarregarClientes(repCliente.SelecionarTodos());

            telaAluguel.CarregarTemas(repTema.SelecionarTodos());

            telaAluguel.ConfigurarTela(aluguelSelecionado, repCliente.SelecionarPorId(aluguelSelecionado.idCliente), repTema.SelecionarPorId(aluguelSelecionado.idTema));

            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                repAluguel.Editar(aluguelSelecionado.id, telaAluguel.ObterAluguel());
            }
            CarregarAluguels(dataInicial, dataFinal);
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
            DialogResult opcaoEscolhida = MessageBox.Show(
                $"Deseja excluir o {ObterTipoCadastro} selecionado?",
                $"Exclusão de {ObterTipoCadastro}",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repAluguel.Excluir(aluguelSelecionado);
                CarregarAluguels(dataInicial, dataFinal);
            }
        }

        public override void Inserir()
        {
            TelaAluguelForm telaAluguel = new TelaAluguelForm();

            telaAluguel.DefinirID(repAluguel.Contador);

            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repAluguel.Inserir(telaAluguel.ObterAluguel());
                CarregarAluguels(dataInicial, dataFinal);
            }
        }

        private void CarregarAluguels(DateTime dataInicial, DateTime dataFinal)
        {
            List<Aluguel> alugueis = repAluguel.SelecionarTodos();
            
            if (dataInicial == default(DateTime) && dataFinal == default(DateTime))
            {
                
            }
            else if (dataInicial == DateTime.Now.Date && dataFinal == DateTime.Now.Date)
            {
                alugueis = alugueis.Where(x => x.festa.data == dataInicial && x.festa.data == dataFinal).ToList();
            }
            else if (dataInicial != default(DateTime) && dataFinal == default(DateTime))
            {
                alugueis = alugueis.Where(x => x.festa.data >= dataInicial).ToList();
            }
            else if (dataInicial == default(DateTime) && dataFinal == DateTime.Now.Date.AddDays(-1))
            {
                alugueis = alugueis.Where(x => x.festa.data <= dataFinal).ToList();
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
