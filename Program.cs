namespace EFIntroPD422
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AirLinesDbContext context = new AirLinesDbContext();

            var flights = context.Flights.Where(f=>f.ArrivalCity == "Kyiv").OrderBy(f => f.DepartureTime).ToList();

            foreach(var f in flights)
            {
                Console.WriteLine($"Flight: #{f.Id}, From {f.ArrivalCity} to {f.DepartureCity} at {f.ArrivalTime.ToShortDateString()}");
            }


            context.SaveChanges();
         

            Console.WriteLine("All of clients : ");
            foreach (var client in context.Clients)
            {
                Console.WriteLine($"Client : {client.Name} - {client.Email} - {client.Birthdate}");
            }
        }
    }
}
