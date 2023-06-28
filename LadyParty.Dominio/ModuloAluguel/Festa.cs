using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyParty.Dominio.ModuloAluguel
{
    public class Festa : EntidadeBase<Aluguel>
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

            return this.endereco == festa.endereco && this.data == festa.data;
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }

        public override void AtualizarInformacoes(Aluguel entidade)
        {
            throw new NotImplementedException();
        }

        public override bool VerificarRepeticao(Aluguel entidade)
        {
            throw new NotImplementedException();
        }

        public override string ObterCampoSQL(bool ehParametro = false)
        {
            throw new NotImplementedException();
        }

        public override SqlParameter[] ObterParametroSQL()
        {
            throw new NotImplementedException();
        }
    }
}
