using System.Collections.Generic;
using lecture4__Safari_Park_.Model;

namespace lecture4__Safari_Park_.Helpers
{
    public class AninalComparer : IComparer<Animal>
    {
        public int Compare(Animal first, Animal second)
        {
            if (first.Name.Length > second.Name.Length)
            {
                return 1;
            }
            else if (first.Name.Length < second.Name.Length)
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
