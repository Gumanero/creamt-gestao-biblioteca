namespace GestaoBiblioteca.Dominio.Entidades
{
    public class Pessoas : EntidadeBase
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
        public Pessoas(int matriculaId, 
                       string nome, 
                       string dadosPessoais, 
                       string endereco, 
                       string contato, 
                       short tipo, 
                       bool situacao)
        {
            MatriculaId = matriculaId;
            Nome = nome;
            DadosPessoais = dadosPessoais;
            Endereco = endereco;
            Contato = contato;
            Tipo = tipo;
            Situacao = situacao;
        }

        #endregion
    }
}