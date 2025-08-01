namespace PROG6212_IceTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Event e = new Event("Michele and Darryl Wedding", "Michele and Darryl Wedding filled with music and laughter", "2025-01-01", "2025-01-01");

            //output all values using int index and string index
            Console.WriteLine(e[0]);
            Console.WriteLine(e[1]);
            Console.WriteLine(e[2]);
            Console.WriteLine(e[3]);

            Console.WriteLine("Event Name: " + e["name"]);
            Console.WriteLine("Event Description: " + e["description"]);
            Console.WriteLine("Event Start Date: " + e["start"]);
            Console.WriteLine("Event End Date: " + e["end"]);
        }
    }
}
