namespace Exercise3.Exercise303
{
    internal class Flamingo : Bird
    {
        public string Color { get; set; }
        public Flamingo(string name, int age, int weight, int wingspan, string color)
            : this(name, "Phoenicopteridae", age, weight, wingspan, color)
        { }

        public Flamingo(string name, string latinName, int age, int weight, int wingspan, string color)
            : base(name, latinName, age, weight, wingspan, false)
        {
            Color = color;
        }
    }
}
