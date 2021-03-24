using GestaoBiblioteca.Dominio.Entidades;
using GestaoBiblioteca.Dominio.Interfaces.Repositorio;
using GestaoBiblioteca.Infra.Data.Contextos;

namespace GestaoBiblioteca.Infra.Data.Repositorio
{
    public class LivrosRepositorio : RepositorioBase<Livros>, ILivrosRepositorio
    {
        public LivrosRepositorio(Contexto contexto)
            : base(contexto)
        {

        }


    }
}