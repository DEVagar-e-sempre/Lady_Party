using LadyParty.WinForms.ModuloCliente;
using LadyParty.WinForms.ModuloTema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LadyParty.WinForms.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        private List<Cliente> clientes;
        private List<Tema> temas;

        private Cliente cliente;
        private Tema tema;

        private decimal valorDoTema;

        private decimal valorDevido;

        public TelaAluguelForm(List<Cliente> clientes, List<Tema> temas)
        {
            InitializeComponent();
            this.clientes = clientes;
            this.temas = temas;
            CarregarClientes();
            CarregarTemas();
            this.ConfigurarTelas();
            this.valorDoTema = 0;
        }

        public void DefinirID(int id = 0)
        {
            txtId.Text = id.ToString();
        }

        public void ConfigurarTela(Aluguel aluguel, Cliente cliente, Tema tema)
        {
            this.Text = "Edição de Aluguel";
            labelTitulo.Text = Text;

            txtId.Text = aluguel.id.ToString();

            txtEndereco.Text = aluguel.festa.endereco;

            cbnClientes.SelectedItem = cliente;

            cbnTemas.SelectedItem = tema;

            txtData.Value = aluguel.festa.data;

            txtHoraInicio.Value = DateTime.Now.Date.Add(aluguel.festa.horaInicio);

            txtHoraTermino.Value = DateTime.Now.Date.Add(aluguel.festa.horaTermino);

            txtValorEntrada.Value = aluguel.ValorDaEntrada;
            txtValorDevido.Text = aluguel.ValorDevido.ToString();
            txtValorTema.Text = aluguel.ValorComDesconto.ToString();


        }
        public Aluguel ObterAluguel()
        {

            Aluguel aluguel = new Aluguel();
            aluguel.festa = new Festa(txtEndereco.Text, txtData.Value, txtHoraInicio.Value.TimeOfDay, txtHoraTermino.Value.TimeOfDay);

            aluguel.id = Convert.ToInt32(txtId.Text);
            aluguel.ValorDaEntrada = txtValorEntrada.Value;
            aluguel.ValorComDesconto = valorDoTema;
            aluguel.ValorDevido = valorDevido;

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

            txtValorEntrada.Maximum = valorDoTema;

            txtValorEntrada.Minimum = valorDoTema * 0.40m;

            txtValorEntrada.Enabled = true;

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
        }

        private void cbxPagarDivida_CheckedChanged(object sender, EventArgs e)
        {
            txtPagarDivida.Enabled = !txtPagarDivida.Enabled;
            if (cbxPagarDivida.CheckState == CheckState.Checked)
            {
                txtPagarDivida.Minimum = txtValorEntrada.Value;
                txtPagarDivida.Maximum = valorDevido;
                txtPagarDivida.Value = valorDevido;
            }
        }
    }
}
