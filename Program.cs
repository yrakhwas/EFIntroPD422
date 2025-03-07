namespace EFIntroPD422
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AirLinesDbContext context = new AirLinesDbContext();

            var filteredClients = context.Clients.Where(c => c.Name == "Petro").OrderBy(c => c.Birthdate);

            //var firstClient = context.Clients.FirstOrDefault();
            var firstClient = context.Clients.Find(2);

            context.Clients.Remove(firstClient);

            Console.WriteLine("First client : " + firstClient.Name);

            context.SaveChanges();
            Console.WriteLine("Filtered clients : ");
            foreach (var client in filteredClients)
            {
                Console.WriteLine($"Client : {client.Name} - {client.Email} - {client.Birthdate}");
            }

            Console.WriteLine("All of clients : ");
            foreach (var client in context.Clients)
            {
                Console.WriteLine($"Client : {client.Name} - {client.Email} - {client.Birthdate}");
            }
        }
    }
}
