using System.Text.Json.Serialization;
using System.Text.Json;

namespace LadyParty.WinForms.Compartilhado
{
    public  class RepositorioArquivoBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        protected Type tipo = typeof(TEntidade);
        protected string nomeArquivo;
        protected List<TEntidade> listaRegistros;//--> descarregar na lista
        public int contadorRegistros;

        public int Contador => contadorRegistros;

        public RepositorioArquivoBase()
        {
        }

        public virtual bool Inserir(TEntidade registro)
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

        public virtual bool Editar(int id, TEntidade registroAtualizado)
        {
            if (EhRepetido(registroAtualizado))
            {
                return false;
            }
            TEntidade registroSelecionado = SelecionarPorId(id);

            registroSelecionado.AtualizarInformacoes(registroAtualizado);

            return true;
        }

        public virtual void Excluir(TEntidade registroSelecionado)
        {
            listaRegistros.Remove(registroSelecionado);
        }

        public virtual TEntidade SelecionarPorId(int id) => listaRegistros.FirstOrDefault(x => x.id == id);

        public virtual List<TEntidade> SelecionarTodos() => listaRegistros;

        public virtual void AdicionarRegistroEContador(List<TEntidade> listaRegistros, int contador)
        {
            this.listaRegistros = listaRegistros;
            this.contadorRegistros = contador;
        }
        public virtual bool EhRepetido(TEntidade entidade)
        {
            int quantidade = listaRegistros.Count(x => x.Equals(entidade));

            return quantidade > 1;
        }
    }
}
