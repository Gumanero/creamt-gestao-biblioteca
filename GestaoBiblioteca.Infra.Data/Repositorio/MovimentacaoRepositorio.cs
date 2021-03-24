using GestaoBiblioteca.Dominio.Entidades;
using GestaoBiblioteca.Dominio.Interfaces.Repositorio;
using GestaoBiblioteca.Infra.Data.Contextos;

namespace GestaoBiblioteca.Infra.Data.Repositorio
{
    public class MovimentacaoRepositorio : RepositorioBase<Movimentacao>, IMovimentacaoRepositorio
    {
        public MovimentacaoRepositorio(Contexto contexto)
            : base(contexto)
        {

        }


    }
}