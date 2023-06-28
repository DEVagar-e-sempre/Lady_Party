using Microsoft.Data.SqlClient;

namespace LadyParty.Dominio.ModuloItemTema
{
    public class ItemTema : EntidadeBase<ItemTema>
    {
        public string descricao { get; set; }
        public decimal preco { get; set; }

        public ItemTema(string descricao, decimal preco)
        {
            this.preco = preco;
            this.descricao = descricao;
        }

        public override void AtualizarInformacoes(ItemTema entidade) { }

        public override string[] Validar()
        {
            List<string> listaErros = new List<string>();

            if (string.IsNullOrEmpty(descricao))
            {
                listaErros.Add("O campo da Descrição é obrigatório!");
            }
            else if (preco is string || preco == null)
            {
                listaErros.Add("Adicione um valor ao preço!");
            }

            return listaErros.ToArray();
        }

        public override string ToString()
        {
            return $"ID: {id} | Nome: {descricao} | Preço: {preco}";
        }
        public override bool VerificarRepeticao(ItemTema obj)
        {

            return id != obj.id && descricao == obj.descricao;

        }

        public override string ObterCampoSQL(bool ehParametro = false)
        {
            String sufixo = "[";
            String prefixo = "]";
            String campo = "";

            if (ehParametro)
            {
                sufixo = "@";
                prefixo = "";
            }
            campo += $"{sufixo}descricao{prefixo},";
            campo += $"{sufixo}preco{prefixo}";
            return campo;
        }

        public override SqlParameter[] ObterParametroSQL()
        {
            return new SqlParameter[]
            {
                new SqlParameter("@descricao", descricao),
                new SqlParameter("@preco", preco)
            }; 
        }
    }
}
