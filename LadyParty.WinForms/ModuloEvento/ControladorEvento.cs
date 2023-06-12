using LadyParty.WinForms.Compartilhado;

namespace LadyParty.WinForms.ModuloEvento
{
    public class ControladorEvento : ControladorBase
    {
        private DateTime dataInicial;
        private DateTime dataFinal;

        private TabelaEventoUserControl tabelaEvento;

        private RepositorioEvento repEvento;

        public ControladorEvento(RepositorioEvento repEvento)
        {
            this.repEvento = repEvento;
        }

        public override string ObterTipoCadastro => "Evento";

        public override bool FiltrarHabilitado => true;

        public override void Editar()
        {
            Evento eventoSelecionado = ObterEventoSelecionado();

            if (eventoSelecionado == null)
            {
                MessageBox.Show($"Selecione um {ObterTipoCadastro} primeiro!",
                    "Edição de {ObterTipoCadastro}s",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaEventoForm telaEvento = new TelaEventoForm();

            //telaEvento.CarregarEventos(repCliente, repTema);

            telaEvento.ConfigurarTela(eventoSelecionado); //, repCliente.SelecionarPorId(eventoSelecionado.idCliente), repTema.SelecionarPorId(eventoSelecionado.idTema));

            DialogResult opcaoEscolhida = telaEvento.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                repEvento.Editar(eventoSelecionado.id, telaEvento.ObterEvento());
            }
            CarregarEventos(dataInicial, dataFinal);
        }

        private Evento ObterEventoSelecionado()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            Evento eventoSelecionado = ObterEventoSelecionado();
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

            //telaEvento.CarregarClientes(repCliente.SelecionarTodos());
            //telaEvento.CarregarTemas(repTema.SelecionarTodos());

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
            /*
            if (dataInicial != default(DateTime) && dataFinal != default(DateTime))
            {
                eventos = eventos.Where(x => x.data >= dataInicial && x.data <= dataFinal).ToList();
            }
            else if (dataInicial != default(DateTime) && dataFinal == default(DateTime))
            {
                eventos = eventos.Where(x => x.data >= dataInicial).ToList();
            }
            else if (dataFinal != default(DateTime))
            {
                eventos = eventos.Where(x => x.data <= dataFinal).ToList();
            }
            */
            tabelaEvento.AtualizarTabela(eventos);
        }

        public override UserControl ObterTabela()
        {
            if (tabelaEvento == null)
            {
                tabelaEvento = new TabelaEventoUserControl();
            }
            tabelaEvento.AtualizarTabela(repEvento.SelecionarTodos());
            return tabelaEvento;
        }
    }
}
