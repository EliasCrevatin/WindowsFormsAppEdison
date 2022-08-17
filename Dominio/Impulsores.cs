using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio
{
    public class Impulsor
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public int DiametroExterior { get; set; }
        public int Eje { get; set; }
        public string Anclaje { get; set; }
        public int ID_Categoria { get; set; }
        public string UrlImagen { get; set; }
        public  catergoria Tipo { get; set; }

        
    }
}
