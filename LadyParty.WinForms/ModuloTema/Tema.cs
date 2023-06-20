﻿using LadyParty.WinForms.ModuloCliente;
using LadyParty.WinForms.ModuloItemTema;

namespace LadyParty.WinForms.ModuloTema
{
    public class Tema : EntidadeBase<Tema>
    {
        public string nomeTema { get; set; }
        public List<ItemTema> listaItens { get; set; }
        public decimal preco { get; set; }

        public Tema(string temaNome, decimal preco)
        {
            this.nomeTema = temaNome;
            this.preco = preco;

            listaItens = new List<ItemTema>();
          
        }

        public Tema(){ }

        public decimal CalcularValorTotal()
        {
            decimal valorItens = 0;

            foreach(ItemTema item in listaItens)
            {
                valorItens = valorItens + item.preco;
            }

            return preco + valorItens;
        }

        public override string[] Validar()
        {
            List<string> listaErros = new List<string>();

            if (string.IsNullOrEmpty(nomeTema))
            {
                listaErros.Add("O campo do Nome é obrigatório!");
            }
            if(preco == 0)
            {
                listaErros.Add("Adicione um valor ao preço!");
            }

            return listaErros.ToArray();
        }

        public override void AtualizarInformacoes(Tema entidadeAtualizada)
        {
            this.nomeTema = entidadeAtualizada.nomeTema;
            this.preco = entidadeAtualizada.preco;
        }

        internal void AdicionarItens(ItemTema item)
        {
            listaItens.Add(item);
        }

        public override string ToString()
        {
            return nomeTema;
        }
        public override bool VerificarRepeticao(Tema obj)
        {
            return this.id != obj.id && this.nomeTema == obj.nomeTema;
        }
    }
}
