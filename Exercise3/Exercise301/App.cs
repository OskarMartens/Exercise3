namespace Exercise3.Exercise301
{
    internal class App
    {
        public void Run()
        {

            try
            {
                var pHandler = new PersonHandler();
                Person person1 = pHandler.CreatePerson(age: 36, "Ronald", "McDonald", height: 180, weight: 80);
                Person person2 = pHandler.CreatePerson(age: 36, "Dennis", "Reynolds", height: 180, weight: 80);
                Person person3 = pHandler.CreatePerson(age: 36, "Charlie", "Kelly", height: 180, weight: 80);
                Person person4 = pHandler.CreatePerson(age: 36, "Frank", "Reynolds", height: 180, weight: 80);
                Console.WriteLine(person1.FName);
                Console.WriteLine(person2.FName);
                Console.WriteLine(person3.FName);
                Console.WriteLine(person4.FName);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
