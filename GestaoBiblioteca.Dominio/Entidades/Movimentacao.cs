using System;

namespace GestaoBiblioteca.Dominio.Entidades
{
    public class Movimentacao : EntidadeBase
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
        public Movimentacao(int movimentacaoId, 
                            string livro, 
                            string cliente, 
                            string profissional, 
                            DateTime dataEmprestimo, 
                            DateTime dataMaximaDevolucao, 
                            DateTime dataDevolucao,
                            short situacaoEmprestimo)
        {
            MovimentacaoId = movimentacaoId;
            Livro = livro;
            Cliente = cliente;
            Profissional = profissional;
            DataEmprestimo = dataEmprestimo;
            DataMaximaDevolucao = dataMaximaDevolucao;
            DataDevolucao = dataDevolucao;
            SituacaoEmprestimo = situacaoEmprestimo;
        }

        #endregion

    }
}
