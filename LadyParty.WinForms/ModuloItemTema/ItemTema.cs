namespace LadyParty.WinForms.ModuloItemTema
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
        public override bool Equals(object? obj)
        {
            if (obj == null || obj == DBNull.Value)
            {
                return false;
            }

            if (obj is ItemTema auxItemTema)
            {
                return id != auxItemTema.id && descricao == auxItemTema.descricao;
            }
            return false;
        }
    }
}
