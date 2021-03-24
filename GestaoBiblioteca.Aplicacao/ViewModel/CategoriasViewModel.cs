namespace GestaoBiblioteca.Aplicacao.ViewModel
{
    public class CategoriasViewModel : ViewModelBase
    {
        #region Propriedades

        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public bool Situacao { get; set; }

        #endregion

        #region Construtor

        public CategoriasViewModel()
        { }

        #endregion

    }
}