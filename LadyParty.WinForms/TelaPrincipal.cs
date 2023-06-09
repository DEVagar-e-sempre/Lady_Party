using LadyParty.WinForms.Compartilhado;
using LadyParty.WinForms.ModuloTema;

namespace LadyParty.WinForms
{
    public partial class TelaPrincipal : Form
    {
        private ControladorBase ctrlBase;
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btn_temas_Click(object sender, EventArgs e)
        {
            ctrlBase = new ControladorTema();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {

        }

        private void btn_loja_Click(object sender, EventArgs e)
        {

        }

        private void btn_festas_Click(object sender, EventArgs e)
        {

        }
    }
}