namespace EFIntroPD422
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AirLinesDbContext context = new AirLinesDbContext();
            context.Clients.Add(new Client
            {
                Name = "Ivan",
                Email = "ivan@gmail.com",
                Birthdate = new DateTime(1990, 1, 1),
            });
            context.SaveChanges();


            foreach (var client in context.Clients)
            {
                Console.WriteLine($"Client : {client.Name} - {client.Email} - {client.Birthdate.ToShortDateString()}");
            }
        }
    }
}
