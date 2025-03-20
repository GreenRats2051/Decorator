namespace Assets.Scripts
{
    public class ToppingDecorator : HotdogDecorator
    {
        private Topping topping;

        public ToppingDecorator(Hotdog hotdog, Topping topping) : base(hotdog)
        {
            this.topping = topping;
        }

        protected override string GetDecoratorDescription()
        {
            return topping.toppingName;
        }

        protected override int GetDecoratorCost()
        {
            return topping.cost;
        }
    }
}