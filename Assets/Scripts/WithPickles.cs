namespace Assets.Scripts
{
    public class WithPickles : HotdogDecorator
    {
        public WithPickles(Hotdog hotdog) : base(hotdog) { }

        public override string GetName()
        {
            return decoratedHotdog.GetName() + " с маринованными огурцами";
        }

        public override int GetCost()
        {
            return 260 + decoratedHotdog.GetCost();
        }
    }
}