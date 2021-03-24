using GestaoBiblioteca.Dominio.Entidades;
using GestaoBiblioteca.Dominio.Interfaces.Repositorio;
using GestaoBiblioteca.Dominio.Interfaces.Servico;

namespace GestaoBiblioteca.Dominio.Servicos
{
    public class CategoriasServico : ServicoBase<Categorias>, ICategoriasServico
    {
        public CategoriasServico(ICategoriasRepositorio repositorio)
            : base(repositorio)
        {

        }




    }
}