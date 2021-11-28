using lecture4__Safari_Park_.Configs.Enum;

namespace lecture4__Safari_Park_.Model.WarmBlooded
{
    public class Eagle : Birds
    {
        public Eagle()
        {
            Cover = CoverType.Feather;
            Region = RegionType.East;
        }

        public EagleType EagleType { get; set; }

        public override bool IsHasBeak => true;
    }
}
