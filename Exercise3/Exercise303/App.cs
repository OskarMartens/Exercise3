namespace Exercise3.Exercise303
{
    internal class App
    {
        public void Run()
        {
            Horse horse = new Horse("Pronto", 12, 150, true);
            Console.WriteLine(horse.LatinName);
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
 */