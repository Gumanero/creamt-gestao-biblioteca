namespace GestaoBiblioteca.Aplicacao.ViewModel
{
    public class PessoasViewModel : ViewModelBase
    {
        #region Propriedades

        public int MatriculaId { get; set; }
        public string Nome { get; set; }
        public string DadosPessoais { get; set; }
        public string Endereco { get; set; }
        public string Contato { get; set; }
        public short Tipo { get; set; }
        public bool Situacao { get; set; }

        #endregion

        #region Construtor

        public PessoasViewModel()
        { }

        #endregion

    }
}