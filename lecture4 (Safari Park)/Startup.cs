using lecture4__Safari_Park_.Model.WarmBlooded;
using lecture4__Safari_Park_.Provider.Abstractions;
using lecture4__Safari_Park_.Service.Abstractions;

namespace lecture4__Safari_Park_
{
    public class Startup
    {
        private readonly ISectionProvider _sectionProvider;
        private readonly ISectionService _sectionService;
        private readonly ISearchService _searchService;
        private readonly ICountService _countService;

        public Startup(ISectionProvider sectionProvider, ISectionService sectionService, ISearchService searchService, ICountService countService)
        {
            _sectionProvider = sectionProvider;
            _sectionService = sectionService;
            _searchService = searchService;
            _countService = countService;
        }

        public void Run()
        {
            _sectionService.AddAnimalToSection();
            _sectionService.SortAnimalByName();
            _sectionService.SortAnimalByWeight();
            var sectionAnimals = _sectionProvider.AnimalInSection;
            _searchService.FindAnimals(sectionAnimals, "Misha");
            _searchService.FindAnimalByType(sectionAnimals, typeof(Bear));
            _countService.TypesCount(typeof(Eagle));
        }
    }
}
