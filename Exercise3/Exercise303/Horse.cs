namespace Exercise3.Exercise303
{
    internal class Horse : Animal
    {

        public bool WearingHorseShoes { get; set; }

        public Horse(string name, int age, int weight, bool wearingHorseShoes)
            : base(name, "Equus ferus caballus", age, weight, true)
        {
            WearingHorseShoes = wearingHorseShoes;
        }

        public override void DoSound()
        {
            Console.WriteLine("Neigh!");
        }

        public override string Stats() =>
            base.Stats() + $",\nWearingHorseShoes:\t{WearingHorseShoes}";
    }
}
