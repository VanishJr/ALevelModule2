using System.Collections.Generic;
using lecture4__Safari_Park_.Model;

namespace lecture4__Safari_Park_.Helpers
{
    public class AnimalWeightComparer : IComparer<Animal>
    {
        public int Compare(Animal first, Animal second)
        {
            if (first.Weight > second.Weight)
            {
                return 1;
            }
            else if (first.Weight < second.Weight)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
