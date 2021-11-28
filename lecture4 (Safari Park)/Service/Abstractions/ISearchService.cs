using System;
using lecture4__Safari_Park_.Model;

namespace lecture4__Safari_Park_.Service.Abstractions
{
    public interface ISearchService
    {
        public Animal FindAnimals(Animal[] animals, string name);
        public Animal FindAnimalByType(Animal[] animals, Type type);
    }
}
