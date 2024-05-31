namespace Exercise3.Exercise303
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int age, int weight, string color)
            : base(name, "Versipellis", age, weight, color) { }

        public void Talk()
        {
            Console.WriteLine("Hello, I am a wolf man");
        }
    }
}
