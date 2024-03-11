
namespace coffeemachine
{
    interface ICoffee
    {
        public CoffeeNames name { get; }
        public int water { get; }
        public int milk { get; }
        public int beans { get; }
        public int cost { get; }
    }
}