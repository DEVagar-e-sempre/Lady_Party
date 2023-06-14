using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LadyParty.WinForms.ModuloAluguel;
using LadyParty.WinForms.ModuloTema;
using System.Xml.Linq;

namespace LadyParty.WinForms.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        private Cliente cliente;

        public TelaClienteForm()
        {
            InitializeComponent();

            this.ConfigurarTelas();
            txt_id.ReadOnly = true;
        }
        public Cliente Cliente
        {
            set
            {
                txt_nomeCliente.Text = value.nomeCliente;
            }
            get
            {
                return cliente;
            }
        }

        public void DefinirID(int id = 0)
        {
            txt_id.Text = id.ToString();
        }
        private void btn_gravar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm tlPrinc = TelaPrincipalForm.TelaPrincipal;

            string nome = txt_nomeCliente.Text;

            string telefone = txt_telefone.Text;

            bool ehEspecial = false;
<<<<<<< Updated upstream

            if (rdb_clienteConvencional.Checked)
            {
                ehEspecial = false;
            }
            else if (rdb_clienteEspecial.Checked)
            {
                ehEspecial = true;
            }
=======
>>>>>>> Stashed changes

            cliente = new Cliente(nome, telefone, ehEspecial);


            string[] erros = cliente.Validar();

            if (erros.Length > 0)
            {
                tlPrinc.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
            else
            {
                tlPrinc.AtualizarRodape("");

            }
        }
    }
}
