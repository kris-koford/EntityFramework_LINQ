using System;
using System.Linq;
using System.Collections.Generic;

namespace EntityFramework_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TripContext()) {
                Console.WriteLine("Initializing database");
                db.Add(new Trip{ Name = "Spokan"});
                db.Add(new Trip {Name="Squim"});
                db.Add(new Trip{Name="Sela"});
                db.SaveChangesAsync();

                var trips = db.trips.OrderBy(t => t.id);

                
            }
        }
    }
}
