using System;

namespace GestaoBiblioteca.Aplicacao.ViewModel
{
    public class MovimentacaoViewModel : ViewModelBase
    {
        #region Propriedades

        public int MovimentacaoId { get; set; }
        public string Livro { get; set; }
        public string Cliente { get; set; }
        public string Profissional { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataMaximaDevolucao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public short SituacaoEmprestimo { get; set; }

        #endregion

        #region Construtor

        public MovimentacaoViewModel()
        { }

        #endregion
    }
}