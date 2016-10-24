using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilljetBokning_Labb
{
    class Runtime
    {
      

        string nameInput;
        List<string> BookedEventList = new List<string>();
        public void Start()
        {
            Console.Clear();
            Console.WriteLine("tryck1 för att boka event");
            Console.WriteLine("tryck2 för att visa event");
            Console.WriteLine("tryck3 för att avsluta");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1": BookTicket(); break;
                case "2": ShowBookedTicket(); break;
                case "3": Environment.Exit(0); break;
                default: Start(); break;
            }
        }
         public void ShowBookedTicket()
        {
            for (int i = 0; i < BookedEventList.Count; i++)
            {
                Console.WriteLine(BookedEventList[i]); 
            };
            Pause();
            Start();
        }
        public void BookTicket()
        {
            {
                Console.WriteLine("vad heter personen som vill boka?");

                nameInput = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("tryck1 för att boka konsert");
                Console.WriteLine("tryck2 för att boka festival");
                Console.WriteLine("tryck3 för att boka film");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();                   
                        List<Konserter> ConcertList = new List<Konserter>()
                        {
                 new Konserter { ArtistName = "abba", EventDate = 1997, EventCatergory = "pop", EventPrice = 1000 },
                 new Konserter { ArtistName = "roling stones", EventDate = 2020, EventCatergory = "rock", EventPrice = 999 },
                 new Konserter { ArtistName = "Beatles", EventDate = 1960, EventCatergory = "rock", EventPrice = 2000 },
                 new Konserter { ArtistName = "Electric banana band", EventDate = 1997, EventCatergory = "rock", EventPrice = 340 },
                 new Konserter { ArtistName = "Joe mama", EventDate = 1996, EventCatergory = "rap", EventPrice = 50 }
                        };
                        for (int i = 0; i < ConcertList.Count; i++)
                        {
                            Console.WriteLine((i + 1) + "-" + ConcertList[i]); 
                        };

                        Console.WriteLine("Vilken konsert vill du boka?");
                        int input2 = int.Parse(Console.ReadLine());
                        BookedEventList.Add("bokat i namnet: "+nameInput+"."+" Konsert: "+ConcertList[input2-1]);
                        Start();
                        break;
                    case "2":
                        Console.Clear();

                        List<Festivaler> FestivalList = new List<Festivaler>()
                        {
                 new Festivaler { EventName = "Roskilde", EventDate = 1997, EventCatergory = "Blandat",EventLength=3, EventPrice = 1800 },
                 new Festivaler { EventName = "Hultsfred", EventDate = 2020, EventCatergory = "pop",EventLength=3, EventPrice = 1390 },
                 new Festivaler { EventName = "Emmaboda", EventDate = 1960, EventCatergory = "elektronisk",EventLength=3, EventPrice = 890 },
                 new Festivaler { EventName = "Sweden Rock", EventDate = 1997, EventCatergory = "rock",EventLength=3, EventPrice = 790 },
                 new Festivaler { EventName = "Uppsala Reggea", EventDate = 1996, EventCatergory = "reggea",EventLength=3, EventPrice = 699 }
                        };
                        for (int i = 0; i < FestivalList.Count; i++)
                        {
                            Console.WriteLine((i + 1) + "-" + FestivalList[i]);
                        };
                        Console.WriteLine("Vilken festival vill du boka?");
                        int input3 = int.Parse(Console.ReadLine());
                        BookedEventList.Add("bokat i namnet: " + nameInput +"."+ " festival: " + FestivalList[input3 - 1]);
                        Start();
                        break;
                    case "3":
                        Console.Clear();
                        List<Filmer> MovieList = new List<Filmer>()
                        {
                 new Filmer { MovieName = "James Bond", EventDate = 2016, EventCatergory = "Action", EventPrice = 120 },
                 new Filmer { MovieName = "Aladdin", EventDate = 1996, EventCatergory = "Tecknat", EventPrice = 79 },
                 new Filmer { MovieName = "Beehive77", EventDate = 1976, EventCatergory = "Skräck", EventPrice = 54 },
                 new Filmer { MovieName = "Tjong i medaljongen", EventDate = 2005, EventCatergory = "Action", EventPrice = 99 },
                 new Filmer { MovieName = "Åsa Nisse 2", EventDate = 1964, EventCatergory = "Humor", EventPrice = 15 }
                        };

                        for (int i = 0; i < MovieList.Count; i++)
                        {
                            Console.WriteLine((i + 1) + "-" + MovieList[i]);
                        };
                        Console.WriteLine("Vilken film vill du boka?");
                        int input4 = int.Parse(Console.ReadLine());
                        BookedEventList.Add("bokat i namnet: " + nameInput + "." + " film: " + MovieList[input4 - 1]);
                        Start();
                        break;
                    default: BookTicket(); break;
                }
            }
        }
        public void Pause()
        {
            Console.ReadLine();
        }
    }
}
