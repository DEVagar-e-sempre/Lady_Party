using LadyParty.Dominio.Compartilhado;
using LadyParty.Dominio.ModuloTema;
using System.Collections.Generic;

namespace LadyParty.Infra.Compartilhado
{
    public abstract class RepositorioSQLBase<TEntidade> : IRepositorio<TEntidade>
        where TEntidade : EntidadeBase<TEntidade>
    {
        private const string strInserirEditar = @"INSERT INTO[LADYPARTYDB]
                                            (
                                                [NOME],
		                                        [TELEFONE]
	                                        )
	                                        VALUES
                                            (
		                                        @NOME,
		                                        @TELEFONE
	                                        )";
                                            
        private string strExcluir;
        private string strSelecionarTodos;
        private string strConexaoBd;

        public bool Inserir(TEntidade registro)
        {
            throw new NotImplementedException();
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
