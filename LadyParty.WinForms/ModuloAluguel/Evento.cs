namespace LadyParty.WinForms.ModuloEvento
{
    public class Evento : EntidadeBase<Evento>
    {
        public int idCliente;

        public int idTema;

        public decimal valorTotal;

        public decimal entrada;

        public decimal desconto;

        public Festa festa;

        public Evento(int id = -1, int idCliente = -1, int idTema = -1, Festa festa = null)
        {
            this.id = id;
            this.idCliente = idCliente;
            this.idTema = idTema;
            this.festa = festa;
        }
        public override void AtualizarInformacoes(Evento entidade)
        {
            this.idTema = entidade.idTema;
            this.festa = entidade.festa;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            if (String.IsNullOrEmpty(festa.endereco))
            {
                erros.Add("Endereço não informado");
            }
            if (idCliente == -1)
            {
                erros.Add("Cliente não selecionado");
            }
            if (idTema == -1)
            {
                erros.Add("Tema não selecionado");
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
    }
}
