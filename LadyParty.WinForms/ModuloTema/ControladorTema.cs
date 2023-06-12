namespace LadyParty.WinForms.ModuloTema
{
    public class ControladorTema : ControladorBase<Tema>
    {
        public ControladorTema(RepositorioArquivoTema repTema)
        {
            base.telaGeral = new TelaCadastroTema();
            base.repEntidade = repTema;
        }

        //Carregar itens

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
