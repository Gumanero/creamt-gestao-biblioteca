using GestaoBiblioteca.Dominio.Entidades;
using GestaoBiblioteca.Dominio.Interfaces.Repositorio;
using GestaoBiblioteca.Dominio.Interfaces.Servico;

namespace GestaoBiblioteca.Dominio.Servicos
{
    public class PessoasServico : ServicoBase<Pessoas>, IPessoasServico
    {
        public PessoasServico(IPessoasRepositorio repositorio)
            : base(repositorio)
        {

        }




    }
}
