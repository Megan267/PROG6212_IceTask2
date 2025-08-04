using PROG6212_IceTask2;

namespace PROG6212_IceTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Event e1 = new Event("Framers Market", "Market that helps Developers figure out which framework they would be interested in",
                "04-08-2025", "08-08-2025");//Object 1 Using int to display information

            Console.WriteLine("First Object using Integers:");

            for (int i = 0; i < 4; i++)//For loop used to output information
            {
                Console.WriteLine(e1[i]);//Output for the int object
            }

            Console.WriteLine();

            Event e2 = new Event("UX & UI Discovery Network", "A campaign that has scouts and has different experienced UI developers to see the next talented UI Devloper",
                "11-08-2025", "14-08-2025");//Output using String

            Console.WriteLine("Second Object using the String Attribute: ");
            Console.WriteLine("Event Name: " + e2["name"]);
            Console.WriteLine("Event Description: " + e2["description"]);
            Console.WriteLine("Starting Event Date: " + e2["start"]);
            Console.WriteLine("End Date for Event: "+ e2["end"]);

            Console.ReadKey();
        }
    }
}
