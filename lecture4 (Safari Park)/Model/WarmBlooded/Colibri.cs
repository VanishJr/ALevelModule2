using lecture4__Safari_Park_.Configs.Enum;

namespace lecture4__Safari_Park_.Model.WarmBlooded
{
    public class Colibri : Birds
    {
        public Colibri()
        {
            Cover = CoverType.Feather;
            Region = RegionType.America;
        }

        public ColibriType ColibriType { get; set; }

        public override bool IsHasBeak => true;
    }
}
