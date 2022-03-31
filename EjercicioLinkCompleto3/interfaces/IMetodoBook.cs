using EjercicioLinkCompleto3.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLinkCompleto3.interfaces
{
    public interface IMetodoBook
    {
        public List<BookExtendido> BooksJoin(int pagina,int librosPorPagina, int? fechaLanzamiento);
    }
}
