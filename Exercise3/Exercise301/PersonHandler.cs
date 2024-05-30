namespace Exercise3.Exercise301
{
    public class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            if (age < 1)
                throw new ArgumentException("Age cannot be under one", nameof(age));

            pers.Age = age;
        }
        public void SetFName(Person pers, string fname)
        {
            ArgumentException.ThrowIfNullOrEmpty($"'{nameof(fname)}' cannot be null or empty.", nameof(fname));

            pers.FName = fname;
        }

        public void setLName(Person pers, string lname)
        {
            ArgumentNullException.ThrowIfNullOrEmpty($"'{nameof(lname)}' cannot be null or empty.", nameof(lname));

            pers.LName = lname;
        }

        public void SetHeight(Person pers, int height)
        {
            pers.Height = height;
        }

        public void SetWeight(Person pers, int weight)
        {
            pers.Weight = weight;
        }

        public Person CreatePerson(int age, string fname, string lname, int height, int weight)
        {
            if (age < 1)
                throw new ArgumentException("Age cannot be under one", nameof(age));

            if (string.IsNullOrEmpty(fname))
                throw new ArgumentException($"'{nameof(fname)}' cannot be null or empty.", nameof(fname));

            if (string.IsNullOrEmpty(lname))
                throw new ArgumentException($"'{nameof(lname)}' cannot be null or empty.", nameof(lname));

            Person person = new Person(age, fname, lname, height, weight);
            return person;
        }
    }
}
