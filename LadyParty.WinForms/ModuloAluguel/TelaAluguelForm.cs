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

        public TelaAluguelForm(List<Cliente> clientes, List<Tema> temas)
        {
            InitializeComponent();
            this.clientes = clientes;
            this.temas = temas;
            CarregarClientes();
            CarregarTemas();
            this.ConfigurarTelas();
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

        }
        public Aluguel ObterAluguel()
        {
            Aluguel aluguel = new Aluguel();
            aluguel.id = Convert.ToInt32(txtId.Text);
            aluguel.festa.endereco = txtEndereco.Text;
            aluguel.idCliente = ((Cliente)cbnClientes.SelectedItem).id;
            aluguel.idTema = ((Tema)cbnTemas.SelectedItem).id;
            aluguel.festa.data = txtData.Value;
            aluguel.festa.horaInicio = txtHoraInicio.Value.TimeOfDay;
            aluguel.festa.horaTermino = txtHoraTermino.Value.TimeOfDay;

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
            Tema tema = (Tema)cbnTemas.SelectedItem;
            if (tema != null)
            {
                txtValor.Text = $"R$ {tema.CalcularValorTotal}";
                txtValorEntrada.Minimum = (int)(tema.CalcularValorTotal() * 0.40m);
                txtValorEntrada.Maximum = (int)(tema.CalcularValorTotal());
                txtValorEntrada.Enabled = true;
                return;
            }
            txtValorEntrada.Enabled = false;
        }
    }
}
