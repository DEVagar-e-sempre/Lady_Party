using LadyParty.WinForms.Compartilhado;
using LadyParty.WinForms.ModuloTema;

namespace LadyParty.WinForms
{
    public partial class TelaPrincipal : Form
    {
        
        
        public TelaPrincipal()
        {
            InitializeComponent();

            this.ConfigurarTelas();
        }

        private void btn_temas_Click(object sender, EventArgs e)
        {
            ControladorBase<Tema> ctrlTema = new ControladorTema();

            ConfigurarListagem(ctrlTema);
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

        private void ConfigurarListagem<T>(ControladorBase<T> ctrlBase)
        {
            UserControl listagem = ctrlBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            pnl_principal.Controls.Clear();//precisa disso para limpar o painel principal e poder
                                           //colocar outro painel por cima, sem que haja conflito

            pnl_principal.Controls.Add(listagem);

        }
    }
}