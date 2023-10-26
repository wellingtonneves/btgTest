using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace btgTest
{
    class Program
    {        
        static void Main(string[] args)
        {
            var services = ConfigureServices();

            var serviceProvider = services.BuildServiceProvider();

            var lista = new Lista();
            lista.Nome = "BTG Test";

            lista.Atividade = new List<Atividade>();
            lista.Atividade.Add(new Atividade { Id = 1, Nome = "Atividade 1", EstaConcluida = false });

            var atividade = new Atividade();
            atividade.Id = 2;
            atividade.Nome = "Atividadde 2";
            atividade.EstaConcluida = false;

            serviceProvider.GetService<IGerenciadorAtividades>().AdicionarAtividade(lista, atividade);
            serviceProvider.GetService<IGerenciadorAtividades>().ConcluirAtividade(lista, 2);            
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddScoped<IGerenciadorAtividades, GerenciadorAtividades>();
            return services;
        }
    }
}
