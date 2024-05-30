namespace Exercise3.Exercise301
{
    internal class App
    {
        public void Run()
        {
            var userData = new Dictionary<int, (int age, String FName, String LName, int height, int weight)>()
            {
                [0] = (36, "Ronald", "McDonald", 180, 80),
                [1] = (36, "R", "McDonald", 180, 80),
                [2] = (36, "Ronald", "McDonald", 180, 80)

            };

            var pHandler = new PersonHandler();

            foreach (var user in userData.Values)
            {
                try
                {
                    Person person = pHandler.CreatePerson(user.age, user.FName, user.LName, user.height, user.weight);
                    Console.WriteLine(person.Age);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            try
            {
                //var pHandler = new PersonHandler();
                //Person person1 = pHandler.CreatePerson(age: 36, "Ronald", "McDonald", height: 180, weight: 80);
                //Person person2 = pHandler.CreatePerson(age: 0, "Dennis", "Reynolds", height: 180, weight: 80);
                //Person person3 = pHandler.CreatePerson(age: 36, "Charlie", "Kelly", height: 180, weight: 80);
                //Person person4 = pHandler.CreatePerson(age: 36, "Frank", "Reynolds", height: 180, weight: 80);
                //Console.WriteLine(person1.Age);
                //Console.WriteLine(person2.Age);
                //Console.WriteLine(person3.Age);
                //Console.WriteLine(person4.Age);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
