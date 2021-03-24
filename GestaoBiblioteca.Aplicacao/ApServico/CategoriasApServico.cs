using AutoMapper;
using GestaoBiblioteca.Aplicacao.Interfaces;
using GestaoBiblioteca.Aplicacao.ViewModel;
using GestaoBiblioteca.Dominio.Entidades;
using GestaoBiblioteca.Dominio.Interfaces.Servico;

namespace GestaoBiblioteca.Aplicacao.ApServico
{
    public class CategoriasApServico : ApServicoBase<Categorias, CategoriasViewModel>, ICategoriasApServico
    {
        #region Construtor

        public CategoriasApServico(IMapper iMapper, ICategoriasServico servico)
            : base(iMapper, servico)
        {

        }

        #endregion

    }
}