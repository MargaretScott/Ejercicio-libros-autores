using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLinkCompleto3.entidades
{
    public class AuthorExtendido 
    {
        public int AuthorId { get; set; }

        public string? Name { get; set; }

        public int Ventas { get; set; }

        public int FechaPublicacion { get; set; }

        public string? NombreLibro { get; set; }

        public int NumeroPublicaciones { get; set; }
     }
}

