namespace LadyParty.WinForms.ModuloAluguel
{
    public class RepositorioArquivoAluguel : RepositorioArquivoBase<Aluguel>
    {
        public RepositorioArquivoAluguel()
        {
            base.listaRegistros = Desserializador();
        }
    }
}
