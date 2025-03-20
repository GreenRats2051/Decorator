namespace Assets.Scripts
{
    public class WithPickles : HotdogDecorator
    {
        public WithPickles(Hotdog hotdog) : base(hotdog) { }

        protected override string GetDecoratorDescription()
        {
            return "с маринованными огурцами";
        }

        protected override int GetDecoratorCost()
        {
            return 30;
        }
    }
}