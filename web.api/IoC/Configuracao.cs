namespace Alterdata.Bimer.WebAPI.IoC
{
    using Alterdata.Bimer.Core.Repositorio;
    using Alterdata.Bimer.Core.Repositorio.Impl;
    using Alterdata.Bimer.Core.Servico;
    using Alterdata.Bimer.Core.Servico.Impl;
    using Alterdata.Bimer.WebAPI.ServicoAplicacao;
    using Alterdata.Bimer.WebAPI.ServicoAplicacao.Impl;
    using Microsoft.Extensions.DependencyInjection;

    public static class Configuracao
    {
        public static void InjetarDependenciasCore(this IServiceCollection services)
        {
            //services.AddScoped<IServicoAplicacaoEmpresa, ServicoAplicacaoEmpresa>();
            services.AddScoped<IServicoAplicacaoCliente, ServicoAplicacaoCliente>();
            //services.AddScoped<IServicoDominioEmpresa, ServicoDominioEmpresa>();
            services.AddScoped<IServicoDominioCliente, ServicoDominioCliente>();
            //services.AddScoped<IRepositorioEmpresa, RepositorioEmpresa>();
            services.AddScoped<IRepositorioCliente, RepositorioCliente>();
        }
    }
}