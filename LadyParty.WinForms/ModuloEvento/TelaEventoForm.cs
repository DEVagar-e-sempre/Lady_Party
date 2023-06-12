using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LadyParty.WinForms.ModuloEvento
{
    public partial class TelaEventoForm : Form
    {
        public TelaEventoForm()
        {
            InitializeComponent();
            this.ConfigurarTelas();
        }

        public void DefinirID(int id = 0)
        {
            txtId.Text = id.ToString();
        }

        public void ConfigurarTela(Evento evento)
        {
            this.Text = "Editar Evento";
            txtId.Text = evento.id.ToString();
            txtEndereco.Text = evento.endereco;
            //cbnClientes.SelectedItem = repCliente.SelecionarPorId(evento.idCliente);
            //cbnTemas.SelectedItem = repTema.SelecionarPorId(evento.idTema);
            txtData.Value = evento.data;
            txtHoraInicio.Value = DateTime.Now.Date.Add(evento.horaInicio);
            txtHoraTermino.Value = DateTime.Now.Date.Add(evento.horaTermino);

        }
        public Evento ObterEvento()
        {
            Evento evento = new Evento();
            evento.id = Convert.ToInt32(txtId.Text);
            evento.endereco = txtEndereco.Text;
            //evento.idCliente = ((Cliente)cbnClientes.SelectedItem).id;
            //evento.idTema = ((Tema)cbnTemas.SelectedItem).id;
            evento.data = txtData.Value;
            evento.horaInicio = txtHoraInicio.Value.TimeOfDay;
            evento.horaTermino = txtHoraTermino.Value.TimeOfDay;

            return evento;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Evento evento = ObterEvento();
            string[] erros = evento.Validar();
            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
