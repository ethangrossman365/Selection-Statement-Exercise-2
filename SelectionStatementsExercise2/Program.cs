namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            var subject = Console.ReadLine(); 

            switch (subject)
            {
                case "Math":
                Console.WriteLine("Awesome. Help me with my math homework.");
                break;

                case "Biology":
                Console.WriteLine("Great. Maybe you can teach me something");
                break;

                case "Reading":
                Console.WriteLine("Cool. What is your favorite book?");
                break;

                case "History":
                Console.WriteLine("Nice. I love hearing about stories from the past.");
                break;

                case "Physical Education":
                Console.WriteLine("Yes. I love that class too. It's easy.");
                break;

                default: Console.WriteLine("Interesting. Haven't heard of that subject.");
                break;




            }
        }
    }
}