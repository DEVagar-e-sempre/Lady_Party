namespace LadyParty.WinForms.ModuloAluguel
{
    public partial class TelaFiltroAluguelForm : Form
    {
        private DateTime dataInicial;
        private DateTime dataFinal;

        public TelaFiltroAluguelForm()
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
            this.dataInicial = DateTime.Now.Date;
            this.dataFinal = DateTime.Now.Date;
        }

        private void rbnEventosAtuais_CheckedChanged(object sender, EventArgs e)
        {
            this.dataInicial = DateTime.Now.Date;
            this.dataFinal = default(DateTime);
        }

        private void rbnEventosAnteriores_CheckedChanged(object sender, EventArgs e)
        {
            this.dataInicial = default(DateTime);
            this.dataFinal = DateTime.Now.Date;
        }

        private void rbnIntervaloCustomizado_CheckedChanged(object sender, EventArgs e)
        {
            txtDataInicial.Enabled = !txtDataInicial.Enabled;
            txtDataFinal.Enabled = !txtDataFinal.Enabled;
        }

        private void txtDataInicial_ValueChanged(object sender, EventArgs e)
        {
            this.dataInicial = txtDataInicial.Value.Date;
        }

        private void txtDataFinal_ValueChanged(object sender, EventArgs e)
        {
            this.dataFinal = txtDataFinal.Value.Date;
        }
    }
}
