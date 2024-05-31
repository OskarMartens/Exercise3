namespace Exercise3.Exercise303
{
    internal class Wolf : Animal
    {
        public string Color { get; set; }
        public Wolf(string name, int age, int weight, string color)
            : this(name, "Canis lupus", age, weight, color) { }

        public Wolf(string name, string latinName, int age, int weight, string color)
            : base(name, latinName, age, weight, true)
        {
            Color = color;
        }

        public override void DoSound()
        {
            Console.WriteLine("Aaah-ooooooooooooooh!");
        }

        public override string Stats() =>
            base.Stats() + $"\nColor:\t\t\t{Color}";
    }
}
