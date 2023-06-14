namespace LadyParty.WinForms.ModuloCliente
{
    public class Cliente : EntidadeBase<Cliente>
    {
        public string nomeCliente { get; set; }
        public string telefoneCliente { get; set; }
        public bool temFestaMarcada { get; set; }
        public DateTime dataDeCadastro { get; set; }

        private int contadorDeAlugueis;


        public Cliente(string nomeCliente, string telefoneCliente)
        {
            this.nomeCliente = nomeCliente;
            this.telefoneCliente = telefoneCliente;
            this.dataDeCadastro = DateTime.Now.Date;
            contadorDeAlugueis = 0;
        }

        public Cliente()
        {
            contadorDeAlugueis = 0;
        }
        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            this.nomeCliente = registroAtualizado.nomeCliente;
            this.telefoneCliente = registroAtualizado.telefoneCliente;
            this.contadorDeAlugueis = registroAtualizado.contadorDeAlugueis;
        }

        public void IncrementarContadorDeAlugueis()
        {
            contadorDeAlugueis++;
        }
        public void DecrementarContadorDeAlugueis()
        {
            if (contadorDeAlugueis > 0)
            {
                contadorDeAlugueis--;
            }
        }
        public int ObterContadorDeAlugueis()
        {
            return contadorDeAlugueis;
        }
        public bool VerificarSeClienteEhEspecial()
        {
            if (contadorDeAlugueis >= 3)
            {
                return true;
            }
            else
                return false;
        }
        public override string[] Validar() //precisa retornar uma string pelo base
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nomeCliente))
                erros.Add($"O campo 'nome cliente' é obrigatório.");

            if (string.IsNullOrEmpty(telefoneCliente))
                erros.Add($"O campo 'numero de celular' é obrigatório.");

            return erros.ToArray();
        }
        public override string ToString()
        {
            return nomeCliente;
        }
    }
}
