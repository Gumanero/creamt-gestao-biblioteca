using GestaoBiblioteca.Dominio.Entidades;
using System.Collections.Generic;

namespace GestaoBiblioteca.Dominio.Interfaces.Servico
{
    public interface IServicoBase<TEntidade>
        where TEntidade : EntidadeBase
    {
        #region Métodos
        int Adicionar(TEntidade entidade);
        void Alterar(TEntidade entidade);
        void Excluir(int id);
        void Excluir(TEntidade entidade);

        #region Consultas

        TEntidade ObterPorId(int id);
        IEnumerable<TEntidade> ObterTodos();

        #endregion

        #endregion
    }
}