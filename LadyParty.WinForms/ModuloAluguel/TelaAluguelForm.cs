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
        public TelaAluguelForm()
        {
            InitializeComponent();
            this.ConfigurarTelas();
        }

        public void DefinirID(int id = 0)
        {
            txtId.Text = id.ToString();
        }

        public void ConfigurarTela(Aluguel evento, Cliente cliente, Tema tema)
        {
            this.Text = "Editar Evento";
            txtId.Text = evento.id.ToString();
            txtEndereco.Text = evento.endereco;
            cbnClientes.SelectedItem = cliente;
            cbnTemas.SelectedItem = tema;
            txtData.Value = evento.data;
            txtHoraInicio.Value = DateTime.Now.Date.Add(evento.horaInicio);
            txtHoraTermino.Value = DateTime.Now.Date.Add(evento.horaTermino);

        }
        public Aluguel ObterEvento()
        {
            Aluguel evento = new Aluguel();
            evento.id = Convert.ToInt32(txtId.Text);
            evento.endereco = txtEndereco.Text;
            evento.idCliente = ((Cliente)cbnClientes.SelectedItem).id;
            evento.idTema = ((Tema)cbnTemas.SelectedItem).id;
            evento.data = txtData.Value;
            evento.horaInicio = txtHoraInicio.Value.TimeOfDay;
            evento.horaTermino = txtHoraTermino.Value.TimeOfDay;

            return evento;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Aluguel evento = ObterEvento();
            string[] erros = evento.Validar();
            if (erros.Length > 0)
            {
                TelaPrincipalForm.TelaPrincipal.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        public void CarregarClientes(List<Cliente> clientes)
        {
            foreach (Cliente cliente in clientes)
            {
                cbnClientes.Items.Add(cliente);
            }
        }

        public void CarregarTemas(List<Tema> temas)
        {
            foreach (Tema tema in temas)
            {
                cbnTemas.Items.Add(tema);
            }
        }
    }
}
