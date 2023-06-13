using System.Text.Json.Serialization;
using System.Text.Json;

namespace LadyParty.WinForms.Compartilhado
{
    public abstract class RepositorioArquivoBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        protected Type tipo = typeof(TEntidade);
        protected string nomeArquivo;
        protected List<TEntidade> listaRegistros;//--> descarregar na lista
        protected int contadorRegistros;

        public int Contador => contadorRegistros;

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

        public virtual List<TEntidade> SelecionarTodos() => listaRegistros.OrderByDescending(x => x.id).ToList();

        //Serializando por json 
        protected List<TEntidade> Desserializador()
        {
            nomeArquivo = $"{tipo.Name}.json";
            JsonSerializerOptions config = ConfigurarLista();

            if (File.Exists(nomeArquivo))
            {
                string conteudo = File.ReadAllText(nomeArquivo);
                RepositorioArquivoBase<TEntidade> tempRep = JsonSerializer.Deserialize<RepositorioArquivoBase<TEntidade>>(conteudo, config);
                
                this.contadorRegistros = tempRep.Contador;
                return tempRep.listaRegistros;
            }
            else
            {
                this.contadorRegistros = 0;
                return new List<TEntidade>();
            }
        }

        public void Serializador()
        {
            nomeArquivo = $"{tipo.Name}.json";

            JsonSerializerOptions config = ConfigurarLista();

            string jsonString = JsonSerializer.Serialize(this, config);

            File.WriteAllText(nomeArquivo, jsonString);//cria e escreve o arquivo File.WriteAllText(nomeArquivo, objeto);

        }

        private JsonSerializerOptions ConfigurarLista()
        {
            JsonSerializerOptions config = new JsonSerializerOptions();

            config.IncludeFields = true;
            config.WriteIndented = true;
            config.ReferenceHandler = ReferenceHandler.Preserve;

            return config;
        }
    }
}
