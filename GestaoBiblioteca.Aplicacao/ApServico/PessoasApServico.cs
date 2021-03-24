using AutoMapper;
using GestaoBiblioteca.Aplicacao.Interfaces;
using GestaoBiblioteca.Aplicacao.ViewModel;
using GestaoBiblioteca.Dominio.Entidades;
using GestaoBiblioteca.Dominio.Interfaces.Servico;

namespace GestaoBiblioteca.Aplicacao.ApServico
{
    public class PessoasApServico : ApServicoBase<Pessoas, PessoasViewModel>, IPessoasApServico
    {
        #region Construtor

        public PessoasApServico(IMapper iMapper, IPessoasServico servico)
            : base(iMapper, servico)
        {

        }

        #endregion

    }
}