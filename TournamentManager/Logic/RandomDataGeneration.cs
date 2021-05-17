using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentManager.Logic
{
    public static class RandomDataGeneration
    {
        // Class initial data
        private static string[] _citiesNames = new string[] { "Berlin", "Madrid", "Rome", "Bucharest", "Paris", "Vienna", "Hamburg", "Warsaw", "Budapest", "Barcelona", "Munich", "Milan", "Prague", "Sofia", "Cologne", "Stockholm", "Naples", "Turin", "Amsterdam", "Marseille", "Zagreb", "Copenhagen", "Valencia", "Krakow", "Frankfurt", "Seville", "Todz", "Zaragoza", "Athens", "Palermo", "Helsinki", "Rotterdam", "Wrocław", "Stuttgart", "Riga", "Dusseldorf", "Vilnius", "Leipzig", "Dortmund", "Essen", "Gothenburg", "Genoa", "Malaga", "Bremen", "Dresden", "Dublin", "The", "Hague", "Hanover", "Poznan", "Antwerpen", "Nuremberg", "Lyon", "Lisbon", "Duisburg", "Toulouse", "Gdansk", "Murcia", "Tallinn", "Bratislava", "Palma de Mallorca", "Szczecin", "Bologna", "BrnoIași", "Florence", "Las", "Palmas", "Bochum", "Utrecht", "Wuppertal", "Aarhus", "Bydgoszcz", "Plovdiv", "Bilbao", "Malmö", "Nice", "Lublin", "Varna", "Bielefeld", "Alicante", "Timișoara", "Bonn", "Córdoba", "Thessaloniki", "Cluj-Napoca", "Bari", "Constanța", "Münster", "Karlsruhe", "Catania", "Mannheim", "Nantes", "Craiova", "Galați" };
        private static int[] _citiesNamesRate = new int[] { 3669495, 3348536, 2856133, 2155240, 2140526, 1921153, 1899160, 1793579, 1752286, 1620343, 1558395, 1404239, 1324277, 1241675, 1085664, 974073, 959188, 875698, 873289, 868277, 804049, 794128, 791413, 780981, 753056, 688711, 677286, 666880, 664046, 663401, 657674, 651870, 643782, 635911, 627487, 619294, 590123, 587857, 587010, 583393, 579281, 578000, 571026, 569352, 554649, 554554, 545273, 538068, 533830, 525935, 518365, 515695, 506654, 498590, 479638, 471525, 447182, 441101, 432864, 409661, 400990, 390636, 381346, 378954, 378839, 378517, 364628, 357676, 354382, 349977, 346739, 346893, 345821, 344166, 342637, 339547, 336505, 333786, 331577, 328186, 327258, 325708, 325182, 324960, 320862, 317832, 314319, 313092, 311584, 309370, 306694, 305386, 304050 };
        private static string[] _toutnamentAjectives = new string[] { "Inter-city", "International", "Open International", "Local Open", "Pre-season", "Athletic", "Great", "Open", "Grand", "Classic", "Local", "Spring", "Summer", "Autumn", "Winter" };
        private static string[] _adjectives = new string[15] { "Red", "Blue", "Green", "Orange", "Yellow", "Pink", "Purple", "Violet", "Gold", "Lime", "Aqua", "Coral", "Brown", "White", "Black"};
        private static int[] _adjectivesRate = new int[15] { 4735694, 4502387, 4499901, 4330025, 3601719, 3563170, 2467544, 2352889, 2160330, 2106078, 2032843, 1889640, 1600285, 1403920, 1348220 };
        private static string[] _nouns = new string[15] { "Monkeys", "Dogs", "Cats", "Horses", "Birds", "Mouses", "Tigers", "Lions", "Sharks", "Panda", "Racoons", "Foxes", "Wolves", "Elephants", "Sheeps" };
        private static int[] _nounsRate = new int[15] { 3265105, 1560897, 1467664, 1448309, 1428981, 1402428, 1104407, 1045519, 993847, 985728, 969544, 965003, 944344, 938638, 873609 };
        //Generation Methods
        public static string GenerateCityName()
        {
            return RandomChooser(_citiesNames, _citiesNamesRate);
        }
        public static string GenerateTeamName()
        {
            string adjective = GenerateAdjective();
            string noun = GenerateNoun();
            return adjective + " " + noun;
        }
        
        public static string GenerateCupName()
        {
            string cityName = GenerateCityName();
            string ajective = RandomChooser(_toutnamentAjectives);
            return cityName + " " + ajective + " Cup";
        }
        private static string GenerateAdjective()
        {
            return RandomChooser(_adjectives, _adjectivesRate);
        }
        private static string GenerateNoun()
        {
            return RandomChooser(_nouns, _nounsRate);
        }
        //Random Methods
        private static string RandomChooser(string[] data)
        {
            Random random = new Random();
            int itemPosition = random.Next(0, data.Length);
            return data[itemPosition];
        }
        private static string RandomChooser(string[] data, int[] rate)
        {
            int rateSum = rate.Sum();
            Random random = new Random();
            int rating = random.Next(0, rateSum);
            int currentSum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                currentSum += rate[i];
                if (rating <= currentSum)
                {
                    return data[i];
                }
                else
                {
                    continue;
                }
            }
            return data[data.Length - 1];
        }
        public static int GenerateInt(int minValue, int maxValue)
        {
            Random random = new Random();
            return random.Next(minValue, maxValue);
        }
    }
}
