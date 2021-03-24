using AutoMapper;
using GestaoBiblioteca.Aplicacao.Interfaces;
using GestaoBiblioteca.Aplicacao.ViewModel;
using GestaoBiblioteca.Dominio.Entidades;
using GestaoBiblioteca.Dominio.Interfaces.Servico;
using System.Collections.Generic;

namespace GestaoBiblioteca.Aplicacao.ApServico
{
    public class ApServicoBase<TEntidade, TBaseViewModel> : IApServicoBase<TEntidade, TBaseViewModel>
        where TEntidade : EntidadeBase
        where TBaseViewModel : ViewModelBase
    {

        #region Instâncias

        protected readonly IServicoBase<TEntidade> _servico;
        protected readonly IMapper _iMapper;

        #endregion

        #region Construtor

        public ApServicoBase(IMapper iMapper, IServicoBase<TEntidade> servico)
             : base()
        {
            _iMapper = iMapper;
            _servico = servico;
        }

        #endregion

        #region Métodos

        public int Adicionar(TBaseViewModel viewModel)
        {
            return _servico.Adicionar(_iMapper.Map<TEntidade>(viewModel));
        }

        public void Alterar(TBaseViewModel viewModel)
        {
            _servico.Alterar(_iMapper.Map<TEntidade>(viewModel));
        }

        public void Excluir(int id)
        {
            _servico.Excluir(id);
        }

        public void Excluir(TBaseViewModel viewModel)
        {
            _servico.Excluir(_iMapper.Map<TEntidade>(viewModel));
        }

        #region Consultas

        public TBaseViewModel ObterPorId(int id)
        {
            return _iMapper.Map<TBaseViewModel>(_servico.ObterPorId(id));
        }

        public IEnumerable<TBaseViewModel> ObterTodos()
        {
            return _iMapper.Map<IEnumerable<TBaseViewModel>>(_servico.ObterTodos());
        }

        #endregion

        #endregion
    }
}