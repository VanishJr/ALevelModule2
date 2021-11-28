using lecture4__Safari_Park_.Configs.Enum;

namespace lecture4__Safari_Park_.Model.ColdBlooded
{
    public class GoldFish : Fish
    {
        public GoldFish()
        {
            Cover = CoverType.Scales;
            Region = RegionType.Africa;
        }

        public GoldFishType GoldFishType { get; set; }
        public override bool IsHasGills => true;
    }
}
