namespace LadyParty.WinForms.Compartilhado
{
    public class RepositorioArquivoBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        protected List<TEntidade> listaRegistros;
        
        public int contadorRegistros;

        public List<TEntidade> ListaRegistros { get => listaRegistros; }

        public RepositorioArquivoBase()
        {
            listaRegistros = new List<TEntidade>();
            contadorRegistros = 0;
        }

        public virtual void Inserir(TEntidade entidade)
        {
            entidade.id = contadorRegistros;
            listaRegistros.Add(entidade);
            contadorRegistros++;
        }

        public virtual void Editar(TEntidade novoRegistro)
        {
            TEntidade registroAntigo = SelecionarPorId(novoRegistro.id);
            registroAntigo.AtualizarInformacoes(novoRegistro);
        }

        public virtual void MesclarRepositorio(RepositorioArquivoBase<TEntidade> repositorio)
        {
            this.listaRegistros.AddRange(repositorio.SelecionarTodos());
            this.contadorRegistros = repositorio.contadorRegistros;
        }

        public virtual void Excluir(int id) => listaRegistros.Remove(SelecionarPorId(id));

        public virtual bool Excluir(TEntidade registro) => listaRegistros.Remove(registro);

        public virtual List<TEntidade> SelecionarTodos() => listaRegistros;

        public virtual TEntidade SelecionarPorId(int id) => listaRegistros.FirstOrDefault(x => x.id == id);
    }
}
