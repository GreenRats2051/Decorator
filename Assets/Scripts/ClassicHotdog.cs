namespace Assets.Scripts
{
    public class ClassicHotdog : Hotdog
    {
        public ClassicHotdog() : base("���-��� ������������") { }

        public override string GetName()
        {
            return name;
        }

        public override int GetCost()
        {
            return 210;
        }
    }
}