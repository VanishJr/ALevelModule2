using System;
using lecture4__Safari_Park_.Model;
using lecture4__Safari_Park_.Provider.Abstractions;
using lecture4__Safari_Park_.Service.Abstractions;

namespace lecture4__Safari_Park_.Service
{
    public class CountService : ICountService
    {
        private readonly ISectionProvider _sectionProvider;

        public CountService(ISectionProvider sectionProvider)
        {
            _sectionProvider = sectionProvider;
        }

        public int TypesCount(Type type)
        {
            int count = 0;
            var animalsLengh = _sectionProvider.AnimalInSection.Length;
            Animal[] name = new Animal[animalsLengh];
            for (var i = 0; i < animalsLengh; i++)
            {
                name[i] = _sectionProvider.AnimalInSection[i];
            }

            for (var j = 0; j < animalsLengh; j++)
            {
                if (name[j].GetType() == type)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
