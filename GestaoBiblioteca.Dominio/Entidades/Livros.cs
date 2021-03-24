namespace GestaoBiblioteca.Dominio.Entidades
{
    public class Livros : EntidadeBase
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
        public Livros(int livrosId,
                      int iSBN, 
                      string titulo,
                      int autor,
                      string editora, 
                      string edicao, 
                      string ano, 
                      int categoria,
                      short situacao)
        {
            LivrosId = livrosId;
            ISBN = iSBN;
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            Edicao = edicao;
            Ano = ano;
            Categoria = categoria;
            Situacao = situacao;
        }

        #endregion
    }
}