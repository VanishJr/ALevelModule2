using lecture4__Safari_Park_.Configs.Enum;

namespace lecture4__Safari_Park_.Model.ColdBlooded
{
    public abstract class ColdBlooded : Animal
    {
        public override BloodedType Blood => BloodedType.Cold;
        public override BodyTemperature Temperature => BodyTemperature.Unstable;
    }
}
