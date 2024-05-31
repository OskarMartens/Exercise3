namespace Exercise3.Exercise303
{
    internal class Bird : Animal
    {
        public int Wingspan { get; set; }
        public bool Flightless { get; set; }

        public Bird(string name, int age, int weight, int wingspan, bool flightless)
            : this(name, "Aves", age, weight, wingspan, flightless) { }

        public Bird(string name, string latinName, int age, int weight, int wingspan, bool flightless)
            : base(name, latinName, age, weight, true)
        {
            Wingspan = wingspan;
            Flightless = flightless;
        }
        public override void DoSound()
        {
            Console.WriteLine("Chirp!");
        }

        public override string Stats() =>
            base.Stats() + $",\nWingspan:\t\t{Wingspan},\nFlightless:\t\t{Flightless}";

    }
}
