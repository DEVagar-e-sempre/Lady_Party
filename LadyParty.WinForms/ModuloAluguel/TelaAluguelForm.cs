using LadyParty.Dominio.ModuloAluguel;
using LadyParty.Dominio.ModuloTema;
using LadyParty.Infra.ModuloAluguel;
using LadyParty.WinForms.ModuloCliente;

namespace LadyParty.WinForms.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        private List<Cliente> clientes;
        private List<Tema> temas;

        private RepositorioArquivoAluguel repAluguel;

        private Cliente cliente;
        private Tema tema;

        private decimal valorDoTema;

        private decimal valorDevido;
        private decimal valorDevidoTemp;

        public TelaAluguelForm(RepositorioArquivoAluguel repAluguel, List<Cliente> clientes, List<Tema> temas)
        {
            InitializeComponent();
            this.repAluguel = repAluguel;
            this.clientes = clientes;
            this.temas = temas;
            CarregarClientes();
            CarregarTemas();
            this.ConfigurarTelas();
            this.valorDoTema = 0;
            ConfigurarDataHora();
        }

        public void DefinirID(int id = 0)
        {
            txtId.Text = id.ToString();
        }
        private void ConfigurarDataHora()
        {
            txtData.MinDate = DateTime.Now.Date;

        }
        public void ConfigurarTela(Aluguel aluguel, Cliente cliente, Tema tema)
        {
            this.Text = "Edição de Aluguel";

            labelTitulo.Text = Text;

            //Informações do Aluguel

            txtId.Text = aluguel.id.ToString();

            cbnClientes.SelectedItem = cliente;

            cbnTemas.SelectedItem = tema;

            //Informações do Pagamento

            txtValorEntrada.Value = aluguel.valorDaEntrada;

            txtValorEntrada.Enabled = false;

            if (aluguel.StatusAluguel() == StatusAluguelEnum.PagamentoPendente)
            {
                cbxPagarDivida.Enabled = true;
            }

            if (aluguel.StatusAluguel() == StatusAluguelEnum.Concluido)
            {
                txtDataQuitacao.Text = aluguel.dataQuitacao.ToShortDateString();
                txtDataQuitacao.Visible = true;
                labelDataQuitacao.Visible = true;
            }

            this.valorDevido = aluguel.ObterValorDevido();
            this.valorDevidoTemp = aluguel.ObterValorDevido();

            txtValorDevido.Text = $"R$ {valorDevido}";

            txtTotalPago.Text = $"R$ {aluguel.ObterTotalPago()}";

            txtValorTema.Text = aluguel.valorAluguel.ToString();

            //Dados da Festa

            if (aluguel.StatusAluguel() is StatusAluguelEnum.PagamentoPendente or StatusAluguelEnum.Concluido)
            {
                txtEndereco.ReadOnly = true;

                txtData.Enabled = false;

                txtHoraInicio.Enabled = false;

                txtHoraTermino.Enabled = false;

                cbnClientes.Enabled = false;
                cbnTemas.Enabled = false;

            }

            txtEndereco.Text = aluguel.festa.endereco;

            txtData.MinDate = aluguel.festa.data;
            txtData.Value = aluguel.festa.data;


            txtHoraInicio.Value = DateTime.Now.Date.Add(aluguel.festa.horaInicio);

            txtHoraTermino.Value = DateTime.Now.Date.Add(aluguel.festa.horaTermino);


        }
        public Aluguel ObterAluguel()
        {

            Aluguel aluguel = new Aluguel();
            aluguel.festa = new Festa(txtEndereco.Text, txtData.Value.Date, txtHoraInicio.Value.TimeOfDay, txtHoraTermino.Value.TimeOfDay);

            aluguel.id = Convert.ToInt32(txtId.Text);

            aluguel.valorDaEntrada = txtValorEntrada.Value;

            aluguel.valorAluguel = valorDoTema;

            aluguel.valorDevidoPago = txtValorDevidoPago.Value;

            if (cliente != null)
            {
                aluguel.idCliente = cliente.id;
            }
            if (tema != null)
            {
                aluguel.idTema = tema.id;
            }

            return aluguel;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Aluguel aluguel = ObterAluguel();
            string[] erros = aluguel.Validar();

            if (repAluguel.EhRepetido(aluguel))
            {
                TelaPrincipalForm.TelaPrincipal.AtualizarRodape("Aluguel já cadastrado!");

                DialogResult = DialogResult.None;
            }

            if (erros.Length > 0)
            {
                TelaPrincipalForm.TelaPrincipal.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        public void CarregarClientes()
        {
            cbnClientes.Items.Clear();
            foreach (Cliente cliente in clientes)
            {
                cbnClientes.Items.Add(cliente);
            }
        }

        public void CarregarTemas()
        {
            cbnTemas.Items.Clear();
            foreach (Tema tema in temas)
            {
                cbnTemas.Items.Add(tema);
            }
        }

        private void cbnTemas_SelectedValueChanged(object sender, EventArgs e)
        {
            this.tema = (Tema)cbnTemas.SelectedItem;
            if (tema == null)
            {
                return;
            }

            if (cliente.VerificarSeClienteEhEspecial())
            {
                valorDoTema = tema.CalcularValorTotal() * 0.85m;

                txtValorTema.Text = $"R$ {valorDoTema} (com 15% OFF)";
            }
            else
            {
                valorDoTema = tema.CalcularValorTotal();
                txtValorTema.Text = $"R$ {valorDoTema}";

            }

            txtValorEntrada.Maximum = valorDoTema / 2;

            txtValorEntrada.Minimum = valorDoTema * 0.40m;

            txtValorEntrada.Enabled = true;
            cbxPagarDivida.Enabled = false;

        }
        private void cbnClientes_SelectedValueChanged(object sender, EventArgs e)
        {
            this.cliente = (Cliente)cbnClientes.SelectedItem;
            this.cbnTemas.Enabled = true;
        }

        private void txtValorEntrada_ValueChanged(object sender, EventArgs e)
        {
            valorDevido = valorDoTema - txtValorEntrada.Value;
            txtValorDevido.Text = $"R$ {valorDevido}";
            txtTotalPago.Text = $"R$ {txtValorEntrada.Value}";
        }

        private void cbxPagarDivida_CheckedChanged(object sender, EventArgs e)
        {
            txtValorDevidoPago.Enabled = !txtValorDevidoPago.Enabled;
            if (cbxPagarDivida.CheckState == CheckState.Checked)
            {
                txtValorDevidoPago.Maximum = valorDevido;
            }
        }

        private void txtPagarDivida_ValueChanged(object sender, EventArgs e)
        {
            valorDevidoTemp = valorDevido - txtValorDevidoPago.Value;
            txtValorDevido.Text = $"R$ {valorDevidoTemp}";
            txtTotalPago.Text = $"R$ {txtValorEntrada.Value + txtValorDevidoPago.Value}";
        }
    }
}
