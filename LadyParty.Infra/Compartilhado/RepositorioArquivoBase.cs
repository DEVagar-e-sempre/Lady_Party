using LadyParty.Dominio.Compartilhado;

namespace LadyParty.Infra.Compartilhado
{
    public  class RepositorioArquivoBase<TEntidade> : IRepositorio<TEntidade>
        where TEntidade : EntidadeBase<TEntidade>
    {
        protected Type tipo = typeof(TEntidade);
        protected string nomeArquivo;
        protected List<TEntidade> listaRegistros;//--> descarregar na lista
        public int contadorRegistros;

        public int Contador => contadorRegistros;

        public RepositorioArquivoBase()
        {
        }

        public bool Inserir(TEntidade registro)
        {
            if (EhRepetido(registro))
            {
                return false;
            }
            registro.id = contadorRegistros;

            listaRegistros.Add(registro);

            contadorRegistros++;

            return true;
        }

        public bool Editar(int id, TEntidade registroAtualizado)
        {
            if (EhRepetido(registroAtualizado))
            {
                return false;
            }
            TEntidade registroSelecionado = SelecionarPorId(id);

            registroSelecionado.AtualizarInformacoes(registroAtualizado);

            return true;
        }

        public void Excluir(TEntidade registroSelecionado)
        {
            listaRegistros.Remove(registroSelecionado);
        }

        public TEntidade SelecionarPorId(int id) => listaRegistros.Find(x => x.id == id);

        public List<TEntidade> SelecionarTodos() => listaRegistros;

        //public void AdicionarRegistroEContador(List<TEntidade> listaRegistros, int contador)
        //{
        //    this.listaRegistros = listaRegistros;
        //    this.contadorRegistros = contador;
        //}

        public bool EhRepetido(TEntidade entidade)
        {
            int quantidade = listaRegistros.Count(x => x.VerificarRepeticao(entidade));

            return quantidade > 0;
        }
    }
}
