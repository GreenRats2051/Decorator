namespace Assets.Scripts
{
    public abstract class HotdogDecorator : Hotdog
    {
        protected Hotdog decoratedHotdog;

        public HotdogDecorator(Hotdog hotdog) : base(hotdog.GetName())
        {
            this.decoratedHotdog = hotdog;
        }

        public override string GetName()
        {
            return $"{decoratedHotdog.GetName()} ({GetDecoratorDescription()})";
        }

        public override int GetCost()
        {
            return decoratedHotdog.GetCost() + GetDecoratorCost();
        }

        protected abstract string GetDecoratorDescription();
        protected abstract int GetDecoratorCost();
    }
}