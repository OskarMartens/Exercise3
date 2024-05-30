namespace Exercise3.Exercise303
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public string LatinName { get; private set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public bool IsVertebrate { get; private set; }

        protected Animal(string name, string latinName, int age, int weight, bool isVertebrate)
        {
            Name = name;
            LatinName = latinName;
            Age = age;
            Weight = weight;
            IsVertebrate = isVertebrate;
        }

        public abstract void DoSound();
    }
}
