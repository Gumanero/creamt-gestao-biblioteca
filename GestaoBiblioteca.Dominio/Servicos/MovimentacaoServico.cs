using GestaoBiblioteca.Dominio.Entidades;
using GestaoBiblioteca.Dominio.Interfaces.Repositorio;
using GestaoBiblioteca.Dominio.Interfaces.Servico;

namespace GestaoBiblioteca.Dominio.Servicos
{
    public class MovimentacaoServico : ServicoBase<Movimentacao>, IMovimentacaoServico
    {
        public MovimentacaoServico(IMovimentacaoRepositorio repositorio)
            : base(repositorio)
        {

        }




    }
}