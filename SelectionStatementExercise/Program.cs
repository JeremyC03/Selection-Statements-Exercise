namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            var r = new Random();
            var favNumber = r.Next(1, 5);

            Console.WriteLine("Try to guess my favorie number");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("too low.");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("too high.");
            }
            else
            {
                Console.WriteLine("You guessed it!!!");
            }

            //Exercise 2

            Console.WriteLine("What is your favorite school subject?");
            var favSubject = Console.ReadLine();

            switch(favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is your favorite school subject.");
                    break;
                case "english":
                    Console.WriteLine("English is your favorite school subject.");
                    break;
                case "science":
                    Console.WriteLine("Science is your favorite school subject.");
                    break;
                case "social Studies":
                    Console.WriteLine("Social Studies is your favorite school subject.");
                    break;
                case "spanish":
                    Console.WriteLine("Spanish is your favorite school subject.");
                    break;
                default:
                    Console.WriteLine("You have no favorite school subject.");
                    break;
            }
        }
    }
}
