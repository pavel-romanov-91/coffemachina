namespace coffeemachine
{
    class Espresso : ICoffee
    {
        public CoffeeNames name { get; }
        public int water { get; }
        public int milk { get; }
        public int beans { get; }
        public int cost { get; }

        
        public Espresso()
        {
            this.name = CoffeeNames.Espresso;
            this.water = 250; 
            this.beans = 16;
            this.cost = 4;
        }

    }
}