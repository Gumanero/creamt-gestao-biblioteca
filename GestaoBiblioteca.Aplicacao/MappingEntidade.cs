using AutoMapper;
using GestaoBiblioteca.Aplicacao.ViewModel;
using GestaoBiblioteca.Dominio.Entidades;

namespace GestaoBiblioteca.Aplicacao
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade()
        {
            #region Conversão Entidade para ViewModel

            CreateMap<Categorias, CategoriasViewModel>();
            CreateMap<Livros, LivrosViewModel>();
            CreateMap<Movimentacao, MovimentacaoViewModel>();
            CreateMap<Pessoas, PessoasViewModel>();

            #endregion

            #region Conversão ViewModel para Entidade

            CreateMap<CategoriasViewModel, Categorias>();
            CreateMap<LivrosViewModel, Livros>();
            CreateMap<MovimentacaoViewModel, Movimentacao>();
            CreateMap<PessoasViewModel, Pessoas>();

            #endregion
        }
    }
}