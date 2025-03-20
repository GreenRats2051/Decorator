namespace Assets.Scripts
{
    public class WithSweetOnion : HotdogDecorator
    {
        public WithSweetOnion(Hotdog hotdog) : base(hotdog) { }

        protected override string GetDecoratorDescription()
        {
            return "с сладким луком";
        }

        protected override int GetDecoratorCost()
        {
            return 30;
        }
    }
}