

using EjercicioLinkCompleto3.entidades;
using EjercicioLinkCompleto3.interfaces;

namespace EjercicioLinkCompleto3.clases
{
    public class MetodoAuthor : IMetodoAuthor
    {
        public List<AuthorExtendido> AuthorsJoin(int pagina, int registrosPagina, string? filtro)
        {
            //recuperar lista de autores
            List<Author> authors = Author.Books();

            //recuperar una lista de libros
            List<Book> books = Book.Books();


            //hacer un join de autores y libros
            var autoresJoin = from author in authors

                              join libros in books on author.AuthorId equals libros.AuthorId
                             
                              where filtro == null || libros.Title.StartsWith(filtro)

                              orderby libros.Sales descending 

                              select new AuthorExtendido()
                              {
                                  AuthorId = libros.AuthorId,
                                  FechaPublicacion = libros.PublicationDate,
                                  Ventas = libros.Sales,
                                  NombreLibro = libros.Title,
                                  Name = author.Name
                              };

            int skip = (pagina - 1) * registrosPagina;
            int take = registrosPagina;
            return autoresJoin.Skip(skip).Take(take).ToList();

        }
    }
}
