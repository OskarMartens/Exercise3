namespace Exercise3.Exercise303
{
    internal class App
    {
        public void Run()
        {
            List<Animal> animals = GetManyAnimals();
            List<Dog> dogs = GetDogList();
            Horse horse = new Horse("Pronto", 12, 12, true);


            foreach (var animal in animals)
            {
                if (animal is IPerson person)
                {
                    Console.WriteLine(animal.GetType().Name);
                    Console.WriteLine(animal.Stats());
                    person.Talk();
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine(animal.GetType().Name);
                    Console.WriteLine(animal.Stats());
                    animal.DoSound();
                    Console.WriteLine("");
                }
            }
            //3.4.14 & 3.4.18
            foreach (var animal in animals)
            {
                if (animal is Dog dog)
                {
                    //3.4.14
                    Console.WriteLine(animal.Stats());
                    //3.4.18
                    Console.WriteLine(dog.Fetch());
                }
            }
        }
        public List<Dog> GetDogList()
        {
            List<Dog> dogs = new List<Dog>();
            Dog dog0 = new Dog("Tor", 21, 21, true);
            Dog dog1 = new Dog("Rex", 21, 21, true);
            Dog dog2 = new Dog("Kato", 21, 21, false);
            Dog dog3 = new Dog("Belle", 21, 21, true);
            return dogs;
        }

        public List<Animal> GetManyAnimals()
        {
            List<Animal> animals = new List<Animal>();
            Flamingo flamingo = new Flamingo("Steve", 21, 121, 12, "Pink");
            Dog dog = new Dog("Jens", 21, 21, true);
            Hedgehog hedgehog = new Hedgehog("Sonic", 21, 21, 21);
            Bird bird = new Bird("Peter", 12, 12, 12, true);
            Horse horse = new Horse("Pronto", 12, 150, true);
            Wolfman wolfman = new Wolfman("Hugh Jackman", 40, 90, "Grey");
            Worm worm = new Worm("John", 1, 1, true);
            Pelican pelican = new Pelican("Pelle", 20, 30, 40, 50);
            Swan swan = new Swan("Sven", 20, 30, 40, true);
            Wolf wolf = new Wolf("Bert-Åke", 2, 40, "Grey");
            animals.Add(flamingo);
            animals.Add(dog);
            animals.Add(hedgehog);
            animals.Add(bird);
            animals.Add(horse);
            animals.Add(worm);
            animals.Add(pelican);
            animals.Add(wolf);
            animals.Add(swan);
            animals.Add(wolfman);
            return animals;
        }
    }
}
/* Todo Fråga 3.3.13
 * "Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt
    attribut, i vilken klass bör vi lägga det?"
 * 
 * Jag skulle säga att det ska läggas i Bird.
 * 
 * 
 * Todo Fråga 3.3.14
 * "Om alla djur behöver det nya attributet, vart skulle man lägga det då?"
 * 
 * Jag skulle säga i Animal.
 * 
 * 
 * Todo Fråga 3.4.9
 * "Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?"
 * 
 * Det går inte eftersom listan med hundar är begränsat till att bara innehålla objekt av hundklassen.
 * 
 * 
 * Todo Fråga 3.4.10
 * "Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?"
 * 
 * 
 * Todo Fråga 3.4.13
 * "Skriv ut samtliga Animals Stats() genom en foreach loop."
 * "Förklara vad det är som händer."
 * 
 * Eftersom vi har användt arv så skriver programmet ut stats för respektive del i arvskedjan.
 * Ta till exempel klassen Flamingo.
 * Först skriver den ut stats från Animal, sedan från Bird och till sist från sin egen klass Flamingo.
 * 
 * Då måste listan vara av typ Animal.
 * 
 * 
 * Todo Fråga 3.4.15-17
 * "Skapa en ny metod med valfritt namn i klassen Dog som endast returnerar en valfri
    sträng."
 * Kommer du åt den metoden från Animals listan?
 * Varför inte?
 * 
 * Det gör jag inte för även om i loopen det kommer till en Dog så är referensen bara animal.
 * Då kan jag bara komma åt metoderna och värdena som Animal har.
 * Animal känner inte till någon klass som ärver utav dem.
 */