using LadyParty.WinForms.ModuloEvento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyParty.WinForms.ModuloAluguel
{
    public class RepositorioArquivoAluguel : RepositorioArquivoBase<Evento>
    {
        public RepositorioArquivoAluguel()
        {
            base.listaRegistros = Desserializador();
        }
    }
}
