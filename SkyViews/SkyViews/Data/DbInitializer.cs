using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SkyViews.Models;

namespace SkyViews.Data
{
    public class DbInitializer
    {
        public static void Initialize(SkyViewsContext context)
        {
            context.Database.EnsureCreated();

            if (context.Customer.Any())
            {
                return;
            }

            var customers = new Customer[]
            {
                new Customer{Name="Brandon",EmailAddress="test@test.com",TelephoneNo=1234123,Password="password"},
                new Customer{Name="Suraj",EmailAddress="surajtest@test.com",TelephoneNo=1234123,Password="password"}
            };

            foreach (Customer c in customers)
            {
                context.Customer.Add(c);
            }
            context.SaveChanges();

            var films = new Film[]
            {
                new Film{Title="Avengers - Infinity War",Synopsis="Earth's mightiest heroes must team up once again to fight their most fiercest foe yet. Will they stop Thanos before it’s too late…",ReleaseDate=DateTime.Parse("26/04/2018"),RunningTime="160 minutes",Director="Anthony Russo, Joe Russo",Cast="Robert Downey Jr., Chris Hemsworth, Mark Ruffalo...",ImagePath="/imgs/avengers.jpg"},
                new Film{Title="Venom",Synopsis="Venom is out on the loose again. Trying to be the bad guy but ends up being a hero. Probably the worst film of 2018.",ReleaseDate=DateTime.Parse("03/08/2018"),RunningTime="112 minutes",Director="Ruben Fleischer",Cast="Tom Hardy, Michelle Williams...",ImagePath="/imgs/venom.png"}
            };

            foreach (Film f in films)
            {
                context.Film.Add(f);
            }
            context.SaveChanges();

            var rooms = new Room[]
            {
                new Room{NoOfSeats=200},
                new Room{NoOfSeats=50}
            };

            foreach (Room r in rooms)
            {
                context.Room.Add(r);
            }
            context.SaveChanges();

            var showings = new Showing[]
            {
                new Showing{RoomID=1,FilmID=1,ShowingTime=DateTime.Parse("10/1/2018 18:00:00")}
            };

            foreach (Showing s in showings)
            {
                context.Showing.Add(s);
            }
            context.SaveChanges();

            var bookings = new Booking[]
{
                new Booking{CustomerID=1,ShowingID=1,SeatNo=1},
                new Booking{CustomerID=2,ShowingID=1,SeatNo=2}
};

            foreach (Booking b in bookings)
            {
                context.Booking.Add(b);
            }
            context.SaveChanges();
        }
    }
}
