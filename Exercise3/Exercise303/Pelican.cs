namespace Exercise3.Exercise303
{
    internal class Pelican : Bird
    {
        public int FishEatCount { get; set; }

        public Pelican(string name, int age, int weight, int wingspan, int fishEatCount)
            : this(name, "Pelecanus", age, weight, wingspan, fishEatCount) { }

        public Pelican(string name, string latinName, int age, int weight, int wingspan, int fishEatCount)
            : base(name, latinName, age, weight, wingspan, false)
        {
            FishEatCount = fishEatCount;
        }

        public override void DoSound()
        {
            Console.WriteLine("Squack!");
        }

        public override string Stats() =>
            base.Stats() + $",\nFishEatCount:\t\t{FishEatCount}";
    }
}
