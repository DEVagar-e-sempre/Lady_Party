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
    public partial class TelaFiltroEventoForm : Form
    {
        private DateTime dataInicial;
        private DateTime dataFinal;

        public TelaFiltroEventoForm()
        {
            InitializeComponent();
        }

        public void ObterDatas(out DateTime dataInicial, out DateTime dataFinal)
        {
            dataInicial = this.dataInicial;
            dataFinal = this.dataFinal;
        }

        private void rbnVisualizarTodos_CheckedChanged(object sender, EventArgs e)
        {
            this.dataInicial = default(DateTime);
            this.dataFinal = default(DateTime);
        }

        private void rbnEventosHoje_CheckedChanged(object sender, EventArgs e)
        {
            this.dataInicial = DateTime.Now;
            this.dataFinal = DateTime.Now;
        }

        private void rbnEventosAtuais_CheckedChanged(object sender, EventArgs e)
        {
            this.dataInicial = DateTime.Now;
            this.dataFinal = default(DateTime);
        }

        private void rbnEventosAnteriores_CheckedChanged(object sender, EventArgs e)
        {
            this.dataInicial = default(DateTime);
            this.dataFinal = DateTime.Now.AddDays(-1);
        }

        private void rbnIntervaloCustomizado_CheckedChanged(object sender, EventArgs e)
        {
            txtDataInicial.Enabled = !txtDataInicial.Enabled;
            txtDataFinal.Enabled = !txtDataFinal.Enabled;
        }

        private void txtDataInicial_ValueChanged(object sender, EventArgs e)
        {
            this.dataInicial = txtDataInicial.Value;
        }

        private void txtDataFinal_ValueChanged(object sender, EventArgs e)
        {
            this.dataFinal = txtDataFinal.Value;
        }
    }
}
