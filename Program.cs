namespace EFIntroPD422
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AirLinesDbContext context = new AirLinesDbContext();

            

            context.SaveChanges();
         

            Console.WriteLine("All of clients : ");
            foreach (var client in context.Clients)
            {
                Console.WriteLine($"Client : {client.Name} - {client.Email} - {client.Birthdate}");
            }
        }
    }
}
