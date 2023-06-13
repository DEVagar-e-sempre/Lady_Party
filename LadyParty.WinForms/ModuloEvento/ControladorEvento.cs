using LadyParty.WinForms.Compartilhado;
using LadyParty.WinForms.ModuloCliente;
using LadyParty.WinForms.ModuloTema;
using static System.Net.Mime.MediaTypeNames;

namespace LadyParty.WinForms.ModuloEvento
{
    public class ControladorEvento : ControladorBase
    {
        private DateTime dataInicial;
        private DateTime dataFinal;

        private TabelaEventoUserControl tabelaEvento;

        private RepositorioArquivoBase<Evento> repEvento;

        private RepositorioArquivoBase<Cliente> repCliente;

        private RepositorioArquivoBase<Tema> repTema;


        public ControladorEvento(RepositorioArquivoBase<Evento> repEvento, RepositorioArquivoBase<Cliente> repCliente, RepositorioArquivoBase<Tema> repTema)
        {
            this.repEvento = repEvento;
            this.repCliente = repCliente;
            this.repTema = repTema;
        }

        public override string ObterTipoCadastro => "Evento";

        public override void Editar()
        {
            Evento eventoSelecionado = ObterIdSelecionado();

            if (eventoSelecionado == null)
            {
                MessageBox.Show($"Selecione um {ObterTipoCadastro} primeiro!",
                    "Edição de {ObterTipoCadastro}s",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaEventoForm telaEvento = new TelaEventoForm();

            telaEvento.CarregarClientes(repCliente.SelecionarTodos());

            telaEvento.CarregarTemas(repTema.SelecionarTodos());

            telaEvento.ConfigurarTela(eventoSelecionado, repCliente.SelecionarPorId(eventoSelecionado.idCliente), repTema.SelecionarPorId(eventoSelecionado.idTema));

            DialogResult opcaoEscolhida = telaEvento.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                repEvento.Editar(eventoSelecionado.id, telaEvento.ObterEvento());
            }
            CarregarEventos(dataInicial, dataFinal);
        }

        private Evento ObterIdSelecionado()
        {
            int id = tabelaEvento.ObterIdSelecionado();

            return repEvento.SelecionarPorId(id);
        }

        public override void Excluir()
        {
            Evento eventoSelecionado = ObterIdSelecionado();
            if (eventoSelecionado == null)
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
                repEvento.Excluir(eventoSelecionado);
                CarregarEventos(dataInicial, dataFinal);
            }
        }

        public override void Inserir()
        {
            TelaEventoForm telaEvento = new TelaEventoForm();

            telaEvento.DefinirID(repEvento.Contador);

            DialogResult opcaoEscolhida = telaEvento.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repEvento.Inserir(telaEvento.ObterEvento());
                CarregarEventos(dataInicial, dataFinal);
            }
        }

        private void CarregarEventos(DateTime dataInicial, DateTime dataFinal)
        {
            List<Evento> eventos = repEvento.SelecionarTodos();
            
            if (dataInicial == default(DateTime) && dataFinal == default(DateTime))
            {
                
            }
            else if (dataInicial == DateTime.Now.Date && dataFinal == DateTime.Now.Date)
            {
                eventos = eventos.Where(x => x.data == dataInicial && x.data == dataFinal).ToList();
            }
            else if (dataInicial != default(DateTime) && dataFinal == default(DateTime))
            {
                eventos = eventos.Where(x => x.data >= dataInicial).ToList();
            }
            else if (dataInicial == default(DateTime) && dataFinal == DateTime.Now.Date.AddDays(-1))
            {
                eventos = eventos.Where(x => x.data <= dataFinal).ToList();
            }
            else if (dataInicial != default(DateTime) && dataFinal != default(DateTime))
            {
                eventos = eventos.Where(x => x.data >= dataInicial && x.data <= dataFinal).ToList();
            }
            tabelaEvento.AtualizarTabela(eventos, repCliente, repTema);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaEvento == null)
            {
                tabelaEvento = new TabelaEventoUserControl();
            }
            tabelaEvento.AtualizarTabela(repEvento.SelecionarTodos(), repCliente, repTema);
            return tabelaEvento;
        }
    }
}
