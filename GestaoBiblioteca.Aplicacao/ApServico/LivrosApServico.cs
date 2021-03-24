using AutoMapper;
using GestaoBiblioteca.Aplicacao.Interfaces;
using GestaoBiblioteca.Aplicacao.ViewModel;
using GestaoBiblioteca.Dominio.Entidades;
using GestaoBiblioteca.Dominio.Interfaces.Servico;

namespace GestaoBiblioteca.Aplicacao.ApServico
{
    public class LivrosApServico : ApServicoBase<Livros, LivrosViewModel>, ILivrosApServico
    {
        #region Construtor

        public LivrosApServico(IMapper iMapper, ILivrosServico servico)
            : base(iMapper, servico)
        {

        }

        #endregion

    }
}