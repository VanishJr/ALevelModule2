using lecture4__Safari_Park_.Configs.Enum;

namespace lecture4__Safari_Park_.Model.WarmBlooded
{
    public class Bear : Mammals
    {
        public Bear()
        {
            Cover = CoverType.Wool;
            Region = RegionType.Asia;
        }

        public BearType BearType { get; set; }

        public override bool IsHasBeak => false;
    }
}
