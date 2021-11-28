using lecture4__Safari_Park_.Model;

namespace lecture4__Safari_Park_.Service.Abstractions
{
    public interface ISectionService
    {
        public void AddAnimalToSection();
        public void SortAnimalByName();
        public void SortAnimalByWeight();
    }
}
