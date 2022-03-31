using EjercicioLinkCompleto3.entidades;
using EjercicioLinkCompleto3.interfaces;


namespace EjercicioLinkCompleto3.clases
{
    public class MetodoBook : IMetodoBook
    {
        public List<BookExtendido> BooksJoin(int pagina,int librosPorPagina, int? fechaLanzamiento)
        {
            //recuperar una lista de libros
            List<Book> listaLibros = Book.Books();

            //recuperar lista de autores
            List<Author> listaAutores = Author.Books();

            var queryLibros = from libros in listaLibros
                              where libros.PublicationDate <= fechaLanzamiento || fechaLanzamiento == null
                              orderby libros.Sales ascending
                              select new BookExtendido()
                              {
                                  AuthorId = libros.AuthorId,
                                  PublicationDate = libros.PublicationDate,
                                  Sales = libros.Sales,
                                  Title =libros.Title,
                                                                   
                              };

            int skip = (pagina - 1) * librosPorPagina;

            return queryLibros.Skip(skip).Take(librosPorPagina).ToList();
        }
    }
}
