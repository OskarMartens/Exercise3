namespace Exercise3.Exercise303
{
    internal class Swan : Bird
    {
        public bool IsMigrated { get; set; }

        public Swan(string name, int age, int weight, int wingspan, bool isMigrated)
            : this(name, "", age, weight, wingspan, isMigrated) { }

        public Swan(string name, string latinName, int age, int weight, int wingspan, bool isMigrated)
            : base(name, latinName, age, weight, wingspan, false)
        {
            IsMigrated = isMigrated;
        }

    }
}
