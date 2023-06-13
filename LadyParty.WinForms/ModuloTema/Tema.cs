namespace LadyParty.WinForms.ModuloTema
{
    public class Tema : EntidadeBase<Tema>
    {
        public string nomeTema { get; set; }
        public List<string> listaItens { get; set; }

        public Tema(string temaNome, List<string> listaItens)
        {
            this.nomeTema = temaNome;

            if(listaItens.Count == 0)
            {
                this.listaItens = new List<string>();
            }
            else
            {
                this.listaItens = listaItens;
            }
        }

        public Tema(){ }

        public override string[] Validar()
        {
            List<string> listaErros = new List<string>();

            if (string.IsNullOrEmpty(nomeTema))
            {
                listaErros.Add("O campo do Nome é obrigatório!");
            }
            else if(listaItens.Count <= 0)
            {
                listaErros.Add("Adicione pelo menos um item da festa!");
            }

            return listaErros.ToArray();
        }

        public override void AtualizarInformacoes(Tema entidadeAtualizada)
        {
            this.nomeTema = entidadeAtualizada.nomeTema;
            this.listaItens = entidadeAtualizada.listaItens;
        }

        public Tema PegarObjTela()
        {
            TelaCadastroTema tela = new TelaCadastroTema();

            return tela.Tema;
        }
    }
}
