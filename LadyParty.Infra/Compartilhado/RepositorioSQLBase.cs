using LadyParty.Dominio.Compartilhado;
using LadyParty.Dominio.ModuloTema;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace LadyParty.Infra.Compartilhado
{
    public abstract class RepositorioSQLBase<TEntidade> : IRepositorio<TEntidade>
        where TEntidade : EntidadeBase<TEntidade>
    {
        protected SqlConnection conexao;
        public abstract string strInserirEditar { get; }
        public abstract string strExcluir { get; }
        public abstract string strSelecionarTodos { get; }
        public abstract string strConexaoBd { get; }

        public bool Inserir(TEntidade registro)
        {
        }
        public bool Editar(int id, TEntidade registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public void Excluir(TEntidade registroSelecionado)
        {
            throw new NotImplementedException();
        }

        public void AdicionarRegistroEContador(List<TEntidade> listaRegistros, int contador)
        {
            throw new NotImplementedException();
        }

        public bool EhRepetido(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        public TEntidade SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<TEntidade> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
