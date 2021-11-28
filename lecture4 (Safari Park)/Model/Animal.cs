using lecture4__Safari_Park_.Configs.Enum;

namespace lecture4__Safari_Park_.Model
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public abstract BloodedType Blood { get; }
        public abstract BodyTemperature Temperature { get; }
        public CoverType Cover { get; set; }
        public RegionType Region { get; set; }
    }
}
