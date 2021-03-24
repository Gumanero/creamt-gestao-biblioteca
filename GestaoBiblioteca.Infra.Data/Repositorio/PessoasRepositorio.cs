using GestaoBiblioteca.Dominio.Entidades;
using GestaoBiblioteca.Dominio.Interfaces.Repositorio;
using GestaoBiblioteca.Infra.Data.Contextos;

namespace GestaoBiblioteca.Infra.Data.Repositorio
{
    public class PessoasRepositorio : RepositorioBase<Pessoas>, IPessoasRepositorio
    {
        public PessoasRepositorio(Contexto contexto)
            : base(contexto)
        {

        }


    }
}