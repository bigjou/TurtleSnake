using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Select
{
    class Program
    {
        //listy
        private static List<string> komedie = new List<string> 
        { 
            "Click", "MIB" ,"Mr. Bean",   "Kosmiczny kosz"     };
        private static List<string> horrory = new List<string>{ 
            "Baba Jaga", "Life" ,"RE",   "Silent Hill"     };
        private static List<string> akcje = new List<string>{ 
            "XXX", "John Wick" ,"Szybce i wciekli",   "James Bond"     };
        private static List<string> erotyki = new List<string>{ 
            "pornHub", "głebokie gardło" ,"emanuel",   "lolita"     };

        static void Main(string[] args)
        {
            Console.WriteLine("Ten program pomaga wybierać filmiki różnych gatónków.");            
            Console.WriteLine("Jak masz na imię?");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj {0}", name);
            Console.WriteLine("Jaki gatunek chciałbyś obejrzeć?");
            Console.WriteLine("Proszę wpisać: komedia, horror, akcja albo erotyka");
            string genre = Console.ReadLine();
            IfElse(genre);
            Console.ReadLine();

        }

            static void WriteMovies(List<string> movies, bool adultsOnly = false)
            {
                if (adultsOnly)
                {
                    Console.WriteLine("Ile masz lat?");
                    string yearsString = Console.ReadLine();
                    int years = Int32.Parse(yearsString);

                    if (years < 18)
                    {
                        Console.WriteLine("Ten gatunek tylko dla 18+\n poczekaj jeszcze {0} lat", 18 - years);
                    }
                    else
                    {
                        foreach (string movie in movies)
                        {
                            Console.WriteLine(movie);
                        }
                    }
                }
                else
                {
                    foreach (string movie in movies)
                    {
                        Console.WriteLine(movie);
                    }
                }
            }
            static void IfElse(string genre)
            {
                Console.WriteLine("Dzisiaj możesz zobaczyć:");
                switch (genre)
                {
                    case "komedia":
                        WriteMovies(komedie);
                        break;
                    case "horror":
                        WriteMovies(horrory);
                        break;
                    case "akcja":
                        WriteMovies(akcje);
                        break;
                    case "erotyka":
                        WriteMovies(erotyki, true);
                        break;
                    default: 
                        Console.WriteLine("Nie ma takiego gatunku.\n Spróbuj ponownie.");
                        string genre2 = Console.ReadLine();
                        IfElse(genre2);
                        break;
                }
            }
    }
}
