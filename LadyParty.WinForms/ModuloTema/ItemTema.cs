namespace LadyParty.WinForms.ModuloTema
{
    public class ItemTema : EntidadeBase<ItemTema>
    {
        public string nome { get; set; }
        public decimal preco { get; set; }

        public ItemTema(string nome, decimal preco)
        {
            this.preco = preco;
            this.nome = nome;
        }

        public override void AtualizarInformacoes(ItemTema entidade) { }

        public override string[] Validar()
        {
            List<string> listaErros = new List<string>();

            if (string.IsNullOrEmpty(nome))
            {
                listaErros.Add("O campo do Nome é obrigatório!");
            }
            else if (preco is string || preco == null)
            {
                listaErros.Add("Adicione um valor ao preço!");
            }

            return listaErros.ToArray();
        }

        public override string ToString()
        {
            return $"ID: {id} | Nome: {nome} | Preço: {preco}";
        }
    }
}
