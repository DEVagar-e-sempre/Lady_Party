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

        public override void AtualizarInformacoes(Evento entidade)
        {
            this.idTema = entidade.idTema;
            this.dataFesta = entidade.dataFesta;
            this.horaInicio = entidade.horaInicio;
            this.horaTermino = entidade.horaTermino;
        }

        public override void Validar()
        {
            throw new NotImplementedException();
        }
    }
}
