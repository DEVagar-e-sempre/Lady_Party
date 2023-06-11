using LadyParty.WinForms.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyParty.WinForms.ModuloEvento
{
    public class Evento : EntidadeBase<Evento>
    {
        public String enderecoFesta;

        public int idCliente;

        public int idTema;

        public DateTime dataFesta;

        public TimeSpan horaInicio;

        public TimeSpan horaTermino;

        public Evento(int id = -1, string enderecoFesta = "", int idCliente = -1, int idTema = -1, DateTime dataFesta = default(DateTime), TimeSpan horaInicio = default(TimeSpan), TimeSpan horaTermino = default(TimeSpan))
        {
            this.id = id;
            this.enderecoFesta = enderecoFesta;
            this.idCliente = idCliente;
            this.idTema = idTema;
            this.dataFesta = dataFesta;
            this.horaInicio = horaInicio;
            this.horaTermino = horaTermino;
        }
        public override void AtualizarInformacoes(Evento entidade)
        {
            this.idTema = entidade.idTema;
            this.dataFesta = entidade.dataFesta;
            this.horaInicio = entidade.horaInicio;
            this.horaTermino = entidade.horaTermino;
        }

        public override void Validar()
        {
            List<string> erros = new List<string>();
            if (String.IsNullOrEmpty(enderecoFesta))
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
            if (dataFesta == default(DateTime))
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
        }
    }
}
