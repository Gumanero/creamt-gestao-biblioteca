using GestaoBiblioteca.Dominio.Entidades;
using GestaoBiblioteca.Dominio.Interfaces.Repositorio;
using GestaoBiblioteca.Dominio.Interfaces.Servico;

namespace GestaoBiblioteca.Dominio.Servicos
{
    public class LivrosServico : ServicoBase<Livros>, ILivrosServico
    {
        public LivrosServico(ILivrosRepositorio repositorio)
            : base(repositorio)
        {

        }




    }
}