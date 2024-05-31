namespace Exercise3.Exercise303
{
    internal class Dog : Animal
    {
        public bool IsKind { get; set; }

        public Dog(string name, int age, int weight, bool isKind)
            : base(name, "Canis familiaris", age, weight, true)
        {
            IsKind = isKind;
        }

        public override void DoSound()
        {
            Console.WriteLine("Woof!");
        }

        public String Fetch() => $"{Name} brought you a stick!";

        public override string Stats() =>
            base.Stats() + $",\nIsKind:\t\t\t{IsKind}";
    }
}
