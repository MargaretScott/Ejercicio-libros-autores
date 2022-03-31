using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLinkCompleto3.entidades
{
    public class BookExtendido
    {
        public string? Title { get; set; }

        public int AuthorId { get; set; }

        public int PublicationDate { get; set; } // Year

        public int Sales { get; set; } //Millions

        public string? authorName { get; set; }

    }
}
