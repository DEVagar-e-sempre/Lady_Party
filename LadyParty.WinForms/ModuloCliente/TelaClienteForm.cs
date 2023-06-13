using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LadyParty.WinForms.ModuloEvento;
using LadyParty.WinForms.ModuloTema;
using System.Xml.Linq;

namespace LadyParty.WinForms.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        public TelaClienteForm()
        {
            InitializeComponent();
        }
        public Cliente ObterCliente()
        {
            Cliente cliente = new Cliente();
            cliente.id = Convert.ToInt32(txt_id.Text);
            cliente.nomeCliente = txt_nomeCliente.Text;

            return cliente;
        }
        public void DefinirID(int id = 0)
        {
            txt_id.Text = id.ToString();
        }
        private void btn_gravar_Click(object sender, EventArgs e)
        {

        }
    }
}
