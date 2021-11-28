using Microsoft.Extensions.DependencyInjection;
using lecture4__Safari_Park_.Provider;
using lecture4__Safari_Park_.Provider.Abstractions;
using lecture4__Safari_Park_.Service;
using lecture4__Safari_Park_.Service.Abstractions;

namespace lecture4__Safari_Park_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                  .AddTransient<ISearchService, SearchService>()
                  .AddSingleton<ISectionProvider, SectionProvider>()
                  .AddSingleton<IAnimalProvider, AnimalProvider>()
                  .AddTransient<ISectionService, SectionService>()
                  .AddTransient<ICountService, CountService>()
                  .AddTransient<Startup>()
                  .BuildServiceProvider();

            var start = serviceProvider.GetService<Startup>();
            start.Run();
        }
    }
}
