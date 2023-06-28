using LadyParty.Dominio.ModuloTema;
using Microsoft.Data.SqlClient;

namespace LadyParty.Infra.ModuloItemTema
{
    public class RepositorioItemTemaSQL : RepositorioSQLBase<Tema>
    {
        public override string strInserirEditar { get => 
                @"INSERT INTO [TBITEMTEMA]
                (
                    [DESCRICAO]
                    [VALOR]
                )
                VALUES
                (
                    @DECRICAO
                    @VALOR
                )"; }// colocar o SELECT SCOPE_IDENTITY();
        public override string strExcluir { get => throw new NotImplementedException(); }
        public override string strSelecionarTodos { get => throw new NotImplementedException(); }
        public override string strConexaoBd { get => throw new NotImplementedException(); }

        public RepositorioItemTemaSQL(SqlConnection conexao)
        {
            base.conexao = conexao;
        }
    }
}
