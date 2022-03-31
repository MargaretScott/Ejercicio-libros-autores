
using EjercicioLinkCompleto3.entidades;

namespace EjercicioLinkCompleto3.interfaces
{
    public interface IMetodoAuthor
    {
        List<AuthorExtendido> AuthorsJoin(int pagina, int registrosPagina, string? filtro);
    }
}
