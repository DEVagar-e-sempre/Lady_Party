using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyParty.WinForms.ModuloCliente
{
    public class RepositorioArquivoCliente : RepositorioArquivoBase<Cliente>
    {
        public RepositorioArquivoCliente()
        {
            base.listaRegistros = Desserializador();
        }
    }
}
