using System;
using lecture4__Safari_Park_.Model;
using lecture4__Safari_Park_.Service.Abstractions;

namespace lecture4__Safari_Park_.Service
{
    public class SearchService : ISearchService
    {
        public Animal FindAnimals(Animal[] animals, string name)
        {
            Animal findanimal = null;

            for (var i = 0; i < animals.Length; i++)
            {
                if (animals[i].Name == name || animals[i].Name.ToLower() == name)
                {
                    findanimal = animals[i];
                    break;
                }
                else
                {
                    i++;
                }
            }

            return findanimal;
        }

        public Animal FindAnimalByType(Animal[] animals, Type type)
        {
            foreach (var animal in animals)
            {
                if (animal.GetType() == type)
                {
                    return animal;
                }
            }

            return null;
        }
    }
}
