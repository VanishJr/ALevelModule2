using lecture4__Safari_Park_.Configs.Enum;

namespace lecture4__Safari_Park_.Model.WarmBlooded
{
    public class Tyger : Mammals
    {
        public Tyger()
        {
            Cover = CoverType.Wool;
            Region = RegionType.Asia;
        }

        public TigerType TigerType { get; set; }

        public override bool IsHasBeak => false;
    }
}
