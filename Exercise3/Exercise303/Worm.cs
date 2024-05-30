namespace Exercise3.Exercise303
{
    internal class Worm : Animal
    {
        public bool IsPoisonous { get; set; }
        public Worm(string name, int age, int weight, bool isPoisonous)
            : this(name, "Annelid", age, weight, isPoisonous) { }

        public Worm(string name, string latinName, int age, int weight, bool isPoisonous)
            : base(name, latinName, age, weight, false)
        {
            IsPoisonous = isPoisonous;
        }
        public override void DoSound()
        {
            Console.WriteLine("???");
        }
    }
}
