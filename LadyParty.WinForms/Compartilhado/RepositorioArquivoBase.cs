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

        public virtual void Inserir(TEntidade registro)
        {
            registro.id = contadorRegistros;

            listaRegistros.Add(registro);

            contadorRegistros++;
        }

        public virtual void Editar(int id, TEntidade registroAtualizado)
        {
            TEntidade registroSelecionado = SelecionarPorId(id);

            registroSelecionado.AtualizarInformacoes(registroAtualizado);
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
    }
}
