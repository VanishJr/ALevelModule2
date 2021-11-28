using lecture4__Safari_Park_.Configs.Enum;

namespace lecture4__Safari_Park_.Model.ColdBlooded
{
    public class Salmon : Fish
    {
        public Salmon()
        {
            Cover = CoverType.Scales;
            Region = RegionType.Asia;
        }

        public SalmonType SalmonType { get; set; }
        public override bool IsHasGills => true;
    }
}
