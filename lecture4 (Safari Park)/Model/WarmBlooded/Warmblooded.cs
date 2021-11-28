using lecture4__Safari_Park_.Configs.Enum;

namespace lecture4__Safari_Park_.Model.WarmBlooded
{
    public abstract class Warmblooded : Animal
    {
        public override BloodedType Blood => BloodedType.Warm;
        public override BodyTemperature Temperature => BodyTemperature.Stable;
    }
}
