using GestaoBiblioteca.Dominio.Entidades;
using System.Collections.Generic;

namespace GestaoBiblioteca.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioBase<TEntidade>
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