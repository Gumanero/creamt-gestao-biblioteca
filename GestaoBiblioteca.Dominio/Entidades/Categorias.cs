namespace GestaoBiblioteca.Dominio.Entidades
{
    public class Categorias : EntidadeBase
    {
        #region Propriedades

        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public bool Situacao { get; set; }

        #endregion

        #region Construtor
        public Categorias(int categoriaId,
                          string nome, 
                          bool situacao)
        {
            CategoriaId = categoriaId;
            Nome = nome;
            Situacao = situacao;
        }

        #endregion
    }
}