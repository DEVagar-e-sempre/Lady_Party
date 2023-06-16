namespace LadyParty.WinForms.ModuloAluguel
{
    public class Aluguel : EntidadeBase<Aluguel>
    {

        public int idCliente;

        public int idTema;

        public Festa festa;

        public decimal ValorDaEntrada;

        public decimal ValorComDesconto;

        public decimal ValorDevido;

        public decimal RestanteAPagar;

        

        public Aluguel(int id, int idCliente, int idTema, Festa festa, decimal valorDaEntrada, decimal valorComDesconto, decimal valorDevido)
        {
            this.id = id;
            this.idCliente = idCliente;
            this.idTema = idTema;
            this.festa = festa;
            this.ValorDaEntrada = valorDaEntrada;
            this.ValorComDesconto = valorComDesconto;
            this.ValorDevido = valorDevido;
            this.RestanteAPagar = valorDevido;
        }

        public Aluguel()
        {
            this.id = -1;
            this.idCliente = -1;
            this.idTema = -1;
            this.festa = new Festa();
            this.ValorDaEntrada = -1;
            this.ValorComDesconto = -1;
            this.ValorDevido = -1;
            this.RestanteAPagar = -1;

        }
        public override void AtualizarInformacoes(Aluguel entidade)
        {
            this.idTema = entidade.idTema;
            this.festa = entidade.festa;
            this.ValorDaEntrada = entidade.ValorDaEntrada;
            this.ValorComDesconto = entidade.ValorComDesconto;
            this.ValorDevido = entidade.ValorDevido;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            if (idCliente < 0 )
            {
                erros.Add("Cliente não selecionado");
            }
            if (idTema < 0)
            {
                erros.Add("Tema não selecionado");
            }
            if(ValorComDesconto == -1)
            {
                erros.Add("Valor com desconto não informado");
            }
            if (ValorDaEntrada == -1)
            {
                erros.Add("Valor da entrada não informado");
            }
            if (ValorDevido == -1)
            {
                erros.Add("Valor devido não informado");
            }
            if (String.IsNullOrEmpty(festa.endereco))
            {
                erros.Add("Endereço não informado");
            }
            if (festa.data == default(DateTime))
            {
                erros.Add("Data não selecionada");
            }
            if (festa.horaInicio == default(TimeSpan))
            {
                erros.Add("Hora de início não selecionada");
            }
            if (festa.horaTermino == default(TimeSpan))
            {
                erros.Add("Hora de término não selecionada");
            }
            return erros.ToArray();
        }

        public override bool Equals(object? obj)
        {
            Aluguel aluguel = (Aluguel) obj;

            return idCliente == aluguel.idCliente && idTema == aluguel.idTema && festa.Equals(aluguel.festa);
        }
    }
}
