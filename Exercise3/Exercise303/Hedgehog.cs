namespace Exercise3.Exercise303
{
    internal class Hedgehog : Animal
    {
        public int NumberOfSpikes { get; set; }
        public Hedgehog(string name, int age, int weight, int numberOfSpikes)
        : this(name, "Erinaceinae", age, weight, numberOfSpikes) { }

        public Hedgehog(string name, string latinName, int age, int weight, int numberOfSpikes)
            : base(name, latinName, age, weight, true)
        {
            NumberOfSpikes = numberOfSpikes;
        }
        public override void DoSound()
        {
            Console.WriteLine("Squeak squeak.");
        }

        public override string Stats() =>
            base.Stats() + $",\nNumberOfSpikes:\t\t{NumberOfSpikes}";
    }
}
