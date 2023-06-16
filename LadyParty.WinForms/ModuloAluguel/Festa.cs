using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyParty.WinForms.ModuloAluguel
{
    public class Festa
    {
        public String endereco;

        public DateTime data;

        public TimeSpan horaInicio;

        public TimeSpan horaTermino;

        public Festa(string endereco, DateTime data, TimeSpan horaInicio, TimeSpan horaTermino)
        {
            this.endereco = endereco;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaTermino = horaTermino;
        }
        public Festa()
        {
            
        }

        public override bool Equals(object? obj)
        {
            Festa festa = (Festa)obj;

            return this.endereco.Equals(festa.endereco) && this.data.Equals(festa.data);
        }
    }
}
