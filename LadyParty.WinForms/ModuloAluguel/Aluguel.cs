namespace LadyParty.WinForms.ModuloAluguel
{
    public class Aluguel : EntidadeBase<Aluguel>
    {
        public string endereco { get; set; }

        public int idCliente { get; set; }

        public int idTema { get; set; }

        public DateTime data { get; set; }

        public TimeSpan horaInicio { get; set; }

        public TimeSpan horaTermino { get; set; }

        public Aluguel(int id = -1, string endereco = "", int idCliente = -1, int idTema = -1, DateTime data = default(DateTime), TimeSpan horaInicio = default(TimeSpan), TimeSpan horaTermino = default(TimeSpan))
        {
            this.id = id;
            this.endereco = endereco;
            this.idCliente = idCliente;
            this.idTema = idTema;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaTermino = horaTermino;
        }

        public Aluguel() { }
        public override void AtualizarInformacoes(Aluguel entidade)
        {
            this.idTema = entidade.idTema;
            this.data = entidade.data;
            this.horaInicio = entidade.horaInicio;
            this.horaTermino = entidade.horaTermino;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            if (String.IsNullOrEmpty(endereco))
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
            if (data == default(DateTime))
            {
                erros.Add("Data não selecionada");
            }
            if (horaInicio == default(TimeSpan))
            {
                erros.Add("Hora de início não selecionada");
            }
            if (horaTermino == default(TimeSpan))
            {
                erros.Add("Hora de término não selecionada");
            }
            return erros.ToArray();
        }
    }
}
