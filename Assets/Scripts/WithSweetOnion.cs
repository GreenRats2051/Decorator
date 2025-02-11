namespace Assets.Scripts
{
    public class WithSweetOnion : HotdogDecorator
    {
        public WithSweetOnion(Hotdog hotdog) : base(hotdog) { }

        public override string GetName()
        {
            return decoratedHotdog.GetName() + " с сладким луком";
        }

        public override int GetCost()
        {
            return 260 + decoratedHotdog.GetCost();
        }
    }
}