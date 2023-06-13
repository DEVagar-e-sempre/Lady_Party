using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyParty.WinForms.ModuloEvento
{
    public class Festa
    {
        public string endereco;

        public DateTime data;

        public TimeSpan horaInicio;

        public TimeSpan horaTermino;

        public Festa(string endereco = "", DateTime data = default(DateTime), TimeSpan horaInicio = default(TimeSpan), TimeSpan horaTermino = default(TimeSpan))
        {
            this.endereco = endereco;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaTermino = horaTermino;
        }
    }
}
