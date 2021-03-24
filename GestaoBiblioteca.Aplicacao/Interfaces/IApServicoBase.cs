using GestaoBiblioteca.Aplicacao.ViewModel;
using GestaoBiblioteca.Dominio.Entidades;
using System.Collections.Generic;

namespace GestaoBiblioteca.Aplicacao.Interfaces
{
    public interface IApServicoBase<TEntidade, TBaseViewModel>
        where TEntidade : EntidadeBase
        where TBaseViewModel : ViewModelBase
    {
        #region Métodos

        int Adicionar(TBaseViewModel viewmodel);
        void Alterar(TBaseViewModel viewModel);
        void Excluir(int id);
        void Excluir(TBaseViewModel viewModel);

        #region Consultas

        TBaseViewModel ObterPorId(int id);
        IEnumerable<TBaseViewModel> ObterTodos();

        #endregion

        #endregion
    }
}