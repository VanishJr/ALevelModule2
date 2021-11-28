using lecture4__Safari_Park_.Model;
using lecture4__Safari_Park_.Provider.Abstractions;

namespace lecture4__Safari_Park_.Provider
{
    public class SectionProvider : ISectionProvider
    {
        public Animal[] AnimalInSection { get; set; }
    }
}
