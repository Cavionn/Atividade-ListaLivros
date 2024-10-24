using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_lista_objeto
{
    internal class Livros
    {
        public int id { get; set; } // get = permite criar regras p/ leitura do atributo || set = regras p/ atribuição de valores ao atributo.

        public string titulo { get; set; }

        public string autor { get; set; }

        public string editora { get; set; }

        public string edicao { get; set; }
        public string idioma { get; set; }

        public int ano { get; set; }

        public int paginas { get; set; }


    }
}
