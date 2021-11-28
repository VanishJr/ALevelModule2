using lecture4__Safari_Park_.Configs.Enum;

namespace lecture4__Safari_Park_.Model.WarmBlooded
{
    public abstract class Mammals : Warmblooded
    {
        // наличие клюва.
        public abstract bool IsHasBeak { get; }
    }
}
