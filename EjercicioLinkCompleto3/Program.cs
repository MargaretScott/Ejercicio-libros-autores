using EjercicioLinkCompleto3.clases;
using EjercicioLinkCompleto3.entidades;

namespace EjerciciolinkCompleto3
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("-----------Autores----------");
            MetodoAuthor metodoAuthor = new MetodoAuthor();
            List<AuthorExtendido> autoresExtendidos = metodoAuthor.AuthorsJoin(1, 1, null);

            foreach(var autores in autoresExtendidos)
            {
                Console.WriteLine($"{autores.Name} ha escrito ''{autores.NombreLibro}'' " +
                    $"y ha conseguido {autores.Ventas} millones de ventas");
            }
            
            MetodoBook metodoBook = new MetodoBook();
            List<BookExtendido> libros = metodoBook.BooksJoin(1, 10, null);
            Console.WriteLine();
            Console.WriteLine("---------------Libros-----------");
            foreach(var lib  in libros)
            {
              Console.WriteLine($"{lib.Title} se ha vendido {lib.Sales} millones de veces. " +
                  $"Se publico en {lib.PublicationDate}");

            }
        }
    }
}