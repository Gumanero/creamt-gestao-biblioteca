using AutoMapper;
using GestaoBiblioteca.Aplicacao.Interfaces;
using GestaoBiblioteca.Aplicacao.ViewModel;
using GestaoBiblioteca.Dominio.Entidades;
using GestaoBiblioteca.Dominio.Interfaces.Servico;

namespace GestaoBiblioteca.Aplicacao.ApServico
{
    public class MovimentacaoApServico : ApServicoBase<Movimentacao, MovimentacaoViewModel>, IMovimentacaoApServico
    {
        #region Construtor

        public MovimentacaoApServico(IMapper iMapper, IMovimentacaoServico servico)
            : base(iMapper, servico)
        {

        }

        #endregion

    }
}