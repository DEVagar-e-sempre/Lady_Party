using LadyParty.Dominio.ModuloTema;
using Microsoft.Data.SqlClient;

namespace LadyParty.Infra.ModuloTema
{
    public class RepositorioTemaSQL : RepositorioSQLBase<Tema>
    {
        public override string strInserirEditar { get => ; }
        public override string strExcluir { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string strSelecionarTodos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string strConexaoBd { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public RepositorioTemaSQL(SqlConnection conexao)
        {
            base.conexao = conexao;
        }
    }
}
