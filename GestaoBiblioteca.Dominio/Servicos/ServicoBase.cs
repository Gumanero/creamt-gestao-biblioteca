using GestaoBiblioteca.Dominio.Entidades;
using GestaoBiblioteca.Dominio.Interfaces.Repositorio;
using GestaoBiblioteca.Dominio.Interfaces.Servico;
using System.Collections.Generic;

namespace GestaoBiblioteca.Dominio.Servicos
{
    public class ServicoBase<TEntidade> : IServicoBase<TEntidade> where TEntidade : EntidadeBase
    {
        #region Instâncias

        protected readonly IRepositorioBase<TEntidade> _repositorio;

        #endregion

        #region Construtor

        public ServicoBase(IRepositorioBase<TEntidade> repositorio)
        {
            _repositorio = repositorio;
        }

        #endregion

        #region Métodos

        public int Adicionar(TEntidade entidade)
        {
            return _repositorio.Adicionar(entidade);
        }

        public void Alterar(TEntidade entidade)
        {
            _repositorio.Alterar(entidade);
        }

        public void Excluir(int id)
        {
            _repositorio.Excluir(id);
        }

        public void Excluir(TEntidade entidade)
        {
            _repositorio.Excluir(entidade);
        }

        #region Consultas

        public TEntidade ObterPorId(int id)
        {
            return _repositorio.ObterPorId(id);
        }

        public IEnumerable<TEntidade> ObterTodos()
        {
            return _repositorio.ObterTodos();
        }

        #endregion

        #endregion
    }
}