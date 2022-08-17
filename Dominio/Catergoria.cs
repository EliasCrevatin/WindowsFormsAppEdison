using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class catergoria
    {
        public int ID { get; set; }

        public string Categoria { get; set; }

        public string Tipo { get; set; }

        public override string ToString()
        {
            return Tipo;
        }
    }
}
