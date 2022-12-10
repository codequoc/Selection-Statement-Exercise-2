namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            string subject = Console.ReadLine();

            switch(subject)
            {
                case "math":
                    Console.WriteLine("You must like problem solving with numbers");
                    break;
                case "reading":
                    Console.WriteLine("You're such a bookworm");
                    break;
                case "writing":
                    Console.WriteLine("You must be creative");
                    break;
                case "science":
                    Console.WriteLine("You must like conducting experiments");
                    break;
                case "history":
                    Console.WriteLine("You must like knowing the past");
                    break;
                default:
                    Console.WriteLine("This is not a subject");
                    break;
            }
        }
    }
}