using Microsoft.EntityFrameworkCore;

namespace data_access
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AirLinesDbContext context = new AirLinesDbContext();

            var flights = context.Flights.Include(f=>f.Airplane)
                .Where(f=>f.ArrivalCity == "Kyiv").OrderBy(f => f.DepartureTime).ToList();

            foreach(var f in flights)
            {
                Console.WriteLine($"Flight: #{f.Id}, From {f.ArrivalCity} to {f.DepartureCity} at {f.ArrivalTime.ToShortDateString()} airplane: {f.Airplane?.Model}");
            }

            //fixBugs
            context.SaveChanges();
         

            Console.WriteLine("All of clients : ");
            foreach (var client in context.Clients)
            {
                Console.WriteLine($"Client : {client.Name} - {client.Email} - {client.Birthdate}");
            }


            var clientF = context.Clients.Find(1);
            context?.Entry(clientF).Collection(c => c.Flights).Load();

            Console.WriteLine($"Client : {clientF?.Name} has {clientF?.Flights?.Count} flights");

            var flightsC = context.Flights
                .Include(f=>f.Airplane)
                .Include(f => f.Clients)
                .OrderBy(f => f.DepartureTime).ToList();


            foreach (var f in flightsC)
            {
                Console.WriteLine(
                   $"Flight: #{f.Id}, From {f.ArrivalCity} to {f.DepartureCity} at {f.ArrivalTime.ToShortDateString() }airplane: {f.Airplane?.Model} - with {f.Clients?.Count}");
            }


        }
    }
}
