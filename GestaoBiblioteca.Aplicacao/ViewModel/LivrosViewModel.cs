namespace GestaoBiblioteca.Aplicacao.ViewModel
{
    public class LivrosViewModel : ViewModelBase
    {
        #region Propriedades

        public int LivrosId { get; set; }
        public int ISBN { get; set; }
        public string Titulo { get; set; }
        public int Autor { get; set; }
        public string Editora { get; set; }
        public string Edicao { get; set; }
        public string Ano { get; set; }
        public int Categoria { get; set; }
        public short Situacao { get; set; }

        #endregion

        #region Construtor

        public LivrosViewModel() 
        { }

        #endregion
    }
}