using GestaoBiblioteca.Aplicacao.ApServico;
using GestaoBiblioteca.Aplicacao.Interfaces;
using GestaoBiblioteca.Dominio.Interfaces.Repositorio;
using GestaoBiblioteca.Dominio.Interfaces.Servico;
using GestaoBiblioteca.Dominio.Servicos;
using GestaoBiblioteca.Infra.Data.Repositorio;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoBiblioteca.Infra.IoC
{
    public class InjetorDependencias
    {
        public static void Registrar(IServiceCollection svcCollection)
        {
            //Aplicação
            svcCollection.AddScoped(typeof(IApServicoBase<,>), typeof(ApServicoBase<,>));
            svcCollection.AddScoped<ICategoriasApServico, CategoriasApServico>();
            svcCollection.AddScoped<ILivrosApServico, LivrosApServico>();
            svcCollection.AddScoped<IMovimentacaoApServico, MovimentacaoApServico>();
            svcCollection.AddScoped<IPessoasApServico, PessoasApServico>();

            //Domínio
            svcCollection.AddScoped(typeof(IServicoBase<>), typeof(ServicoBase<>));
            svcCollection.AddScoped<ICategoriasServico, CategoriasServico>();
            svcCollection.AddScoped<ILivrosServico, LivrosServico>();
            svcCollection.AddScoped<IMovimentacaoServico, MovimentacaoServico>();
            svcCollection.AddScoped<IPessoasServico, PessoasServico>();

            //Repositorio
            svcCollection.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
            svcCollection.AddScoped<ICategoriasRepositorio, CategoriasRepositorio>();
            svcCollection.AddScoped<ILivrosRepositorio, LivrosRepositorio>();
            svcCollection.AddScoped<IMovimentacaoRepositorio, MovimentacaoRepositorio>();
            svcCollection.AddScoped<IPessoasRepositorio, PessoasRepositorio>();
        }
    }
}