namespace LadyParty.WinForms.ModuloTema
{
    public class RepositorioArquivoTema : RepositorioArquivoBase<Tema>
    {
        public RepositorioArquivoTema()
        {
            this.listaRegistros = Desserializador();
        }
    }
}
