namespace LadyParty.WinForms.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private TelaCadastroTema telaTema;
        private RepositorioArquivoTema repTema;
        private TemaUserControl tabelaTema;

        public override string ObterTipoCadastro => "Tema";

        public override string ToolTipInserir => "Inserir Tema";

        public override string ToolTipEditar => "Editar Tema existente";

        public override string ToolTipExcluir => "Excluir Tema existente";

        public ControladorTema(RepositorioArquivoTema repTema)
        {
            this.repTema = repTema;
        }

        //Carregar itens

        public override void Inserir()
        {
            telaTema = new TelaCadastroTema();

            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)//clicou em gravar
            {
                Tema contato = telaTema.Tema;

                repTema.Inserir(contato);//vai mandar pro repositorio

                MessageBox.Show("Tema Gravado com sucesso!");

                CarregarTemas();

                repTema.Serializador();
            }
        }

        public override void Editar()
        {
            Tema temaSelec = ObterTemaSelecionado();

            if (temaSelec == null)
            {
                MessageBox.Show($"Selecione um Tema primeiro!",
                    "Edição de Temas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                telaTema = new TelaCadastroTema();
                telaTema.Tema = temaSelec;

                DialogResult opcao = telaTema.ShowDialog();

                if (opcao == DialogResult.OK)
                {
                    repTema.Editar(telaTema.Tema.id, telaTema.Tema);

                    CarregarTemas();

                    repTema.Serializador();
                }
            }
        }

        public override void Excluir()
        {
            Tema temaSelec = ObterTemaSelecionado();

            if(temaSelec == null)
            {
                MessageBox.Show($"Selecione um Tema primeiro!",
                    "Edição de Temas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o Tema {temaSelec.nomeTema}?", 
                    "Exclusão de Tema",
                    MessageBoxButtons.OKCancel, 
                    MessageBoxIcon.Question);

                if(opcaoEscolhida == DialogResult.OK)
                {
                    repTema.Excluir(temaSelec);

                    CarregarTemas();

                    repTema.Serializador();
                }
            }
        }

        private Tema ObterTemaSelecionado()
        {
            int id = tabelaTema.ObterIdSelecionado();

            return repTema.SelecionarPorId(id);
        }

        private void CarregarTemas()
        {

            List<Tema> listaTemas = repTema.SelecionarTodos();//esta pegando a lista de Contatos e jogando para o contatos

            tabelaTema.AtualizarRegistros(listaTemas);//vai passar a lista para o listBox por meio desse metodo 
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTema == null)
            {
                tabelaTema = new TemaUserControl();
            }

            CarregarTemas();

            return tabelaTema;
        }
    }
}
