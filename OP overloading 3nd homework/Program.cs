


using Country;
using System.Reflection.Metadata.Ecma335;

namespace Country
{
    public class City
    {
        public City(string? cityName, long? population)
        {
            CityName = cityName;
            Population = population;
        }
        public string? CityName { get; set; }
        public long? Population { get; set; }
        public static bool operator >(City c1, City c2)
       => c1.Population > c2.Population;
        public static bool operator <(City c1, City c2)
      => c1.Population < c2.Population;
    }

}


class Program
{
    static void Main(string[] args)
    {
        City city1 = new City("Baki", 3147000);
        City city2 = new City("Tebriz", 2147000);

        if (city1>city2)
        {
            Console.WriteLine("Bakinin ehalisi choxdu");
        }
        else Console.WriteLine("Tebrizin ehalisi choxdu");

    }
}