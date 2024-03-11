namespace coffeemachine
{
    class Cappucino : ICoffee
    {
        public CoffeeNames name { get; }
        public int water { get; }
        public int milk { get; }
        public int beans { get; }
        public int cost { get; }

        public Cappucino()
        {
            this.name = CoffeeNames.Cappucino;
            this.water = 200;
            this.milk = 100;
            this.beans = 12;
            this.cost = 6;
        }
        
        
   
   
   
   
   
   
    }

}