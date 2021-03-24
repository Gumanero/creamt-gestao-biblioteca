using GestaoBiblioteca.Dominio.Entidades;
using GestaoBiblioteca.Dominio.Interfaces.Repositorio;
using GestaoBiblioteca.Infra.Data.Contextos;

namespace GestaoBiblioteca.Infra.Data.Repositorio
{
    public class CategoriasRepositorio : RepositorioBase<Categorias>, ICategoriasRepositorio
    {
        public CategoriasRepositorio(Contexto contexto)
            : base(contexto)
        {

        }


    }
}