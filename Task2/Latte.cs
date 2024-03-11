namespace coffeemachine
{
    class Latte : ICoffee
    {
        public CoffeeNames name { get; }
        public int water { get; }
        public int milk { get; }
        public int beans { get; }
        public int cost { get; }

                
        public Latte()
        {
            this.name = CoffeeNames.Latte;
            this.water = 350;
            this.milk = 75;
            this.beans = 20;
            this.cost = 7;
        }
    }
}