using Microsoft.Azure.Documents;

namespace agent.details
{
    public class Details
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class Appointment
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
    public class InMemoryDatabase
    {
        public static List<User> Users = new List<User>();
        public static List<Appointment> Appointments = new List<Appointment>();
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                var choice = Console.ReadLine();

            }
        }
