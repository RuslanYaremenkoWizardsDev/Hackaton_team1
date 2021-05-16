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
        private static string[] _maleNames = new string[100] { "James", "John", "Robert", "Michael", "William", "David", "Richard", "Joseph", "Thomas", "Charles", "Christopher", "Daniel", "Matthew", "Anthony", "Donald", "Mark", "Paul", "Steven", "Andrew", "Kenneth", "Joshua", "Kevin", "Brian", "George", "Edward", "Ronald", "Timothy", "Jason", "Jeffrey", "Ryan", "Jacob", "Gary", "Nicholas", "Eric", "Jonathan", "Stephen", "Larry", "Justin", "Scott", "Brandon", "Benjamin", "Samuel", "Frank", "Gregory", "Raymond", "Alexander", "Patrick", "Jack", "Dennis", "Jerry", "Tyler", "Aaron", "Jose", "Henry", "Adam", "Douglas", "Nathan", "Peter", "Zachary", "Kyle", "Walter", "Harold", "Jeremy", "Ethan", "Carl", "Keith", "Roger", "Gerald", "Christian", "Terry", "Sean", "Arthur", "Austin", "Noah", "Lawrence", "Jesse", "Joe", "Bryan", "Billy", "Jordan", "Albert", "Dylan", "Bruce", "Willie", "Gabriel", "Alan", "Juan", "Logan", "Wayne", "Ralph", "Roy", "Eugene", "Randy", "Vincent", "Russell", "Louis", "Philip", "Bobby", "Johnny", "Bradley" };
        private static int[] _maleNamesRate = new int[100] { 4735694, 4502387, 4499901, 4330025, 3601719, 3563170, 2467544, 2352889, 2160330, 2106078, 2032843, 1889640, 1600285, 1403920, 1348220, 1346509, 1286846, 1281302, 1252016, 1226558, 1214872, 1172372, 1166797, 1159331, 1097742, 1073062, 1069165, 1035285, 975104, 937629, 925412, 899858, 891818, 877492, 844121, 840005, 802430, 777285, 769663, 759155, 730425, 710086, 707244, 706987, 679913, 666982, 663725, 637347, 611319, 602696, 589687, 579578, 559823, 553392, 551342, 549324, 544555, 540603, 537934, 480276, 476581, 448640, 437552, 435390, 431805, 431764, 429723, 428208, 425034, 422106, 418691, 415722, 411665, 409039, 407197, 388484, 388230, 381581, 379560, 378141, 377227, 377049, 375986, 367775, 352072, 348591, 345375, 341413, 339139, 338689, 338079, 330306, 327821, 322824, 321274, 320157, 315423, 313302, 308243, 306339 };
        private static string[] _femaleNames = new string[100] { "Mary", "Patricia", "Jennifer", "Linda", "Elizabeth", "Barbara", "Susan", "Jessica", "Sarah", "Karen", "Nancy", "Lisa", "Margaret", "Betty", "Sandra", "Ashley", "Dorothy", "Kimberly", "Emily", "Donna", "Michelle", "Carol", "Amanda", "Melissa", "Deborah", "Stephanie", "Rebecca", "Laura", "Sharon", "Cynthia", "Kathleen", "Amy", "Shirley", "Angela", "Helen", "Anna", "Brenda", "Pamela", "Nicole", "Samantha", "Katherine", "Emma", "Ruth", "Christine", "Catherine", "Debra", "Rachel", "Carolyn", "Janet", "Virginia", "Maria", "Heather", "Diane", "Julie", "Joyce", "Victoria", "Kelly", "Christina", "Lauren", "Joan", "Evelyn", "Olivia", "Judith", "Megan", "Cheryl", "Martha", "Andrea", "Frances", "Hannah", "Jacqueline", "Ann", "Gloria", "Jean", "Kathryn", "Alice", "Teresa", "Sara", "Janice", "Doris", "Madison", "Julia", "Grace", "Judy", "Abigail", "Marie", "Denise", "Beverly", "Amber", "Theresa", "Marilyn", "Danielle", "Diana", "Brittany", "Natalie", "Sophia", "Rose", "Isabella", "Alexis", "Kayla", "Charlotte" };
        private static int[] _femaleNamesRate = new int[100] { 3265105, 1560897, 1467664, 1448309, 1428981, 1402428, 1104407, 1045519, 993847, 985728, 969544, 965003, 944344, 938638, 873609, 847504, 847468, 838235, 826262, 823285, 811401, 807303, 772882, 753157, 739809, 738123, 729683, 721299, 720816, 705685, 689366, 680682, 668154, 658437, 652923, 629400, 606286, 592694, 588265, 576029, 574858, 570150, 563391, 563333, 550466, 548279, 546309, 542250, 541277, 531894, 528760, 524161, 515256, 506315, 500601, 481786, 471257, 471012, 469625, 469101, 466314, 464246, 449885, 437186, 436878, 434595, 434410, 429429, 426616, 420348, 412411, 409072, 407127, 406120, 404664, 404603, 401653, 400210, 395048, 387071, 383225, 379239, 378014, 373862, 373633, 371019, 370608, 369981, 369848, 369847, 367791, 358617, 358579, 352644, 351883, 351296, 342345, 339548, 339169, 338315 };
        private static string[] _lastNames = new string[100] { "Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis", "Garcia", "Rodriguez", "Wilson", "Martinez", "Anderson", "Taylor", "Thomas", "Hernandez", "Moore", "Martin", "Jackson", "Thompson", "White", "Lopez", "Lee", "Gonzalez", "Harris", "Clark", "Lewis", "Robinson", "Walker", "Perez", "Hall", "Young", "Allen", "Sanchez", "Wright", "King", "Scott", "Green", "Baker", "Adams", "Nelson", "Hill", "Ramirez", "Campbell", "Mitchell", "Roberts", "Carter", "Phillips", "Evans", "Turner", "Torres", "Parker", "Collins", "Edwards", "Stewart", "Flores", "Morris", "Nguyen", "Murphy", "Rivera", "Cook", "Rogers", "Morgan", "Peterson", "Cooper", "Reed", "Bailey", "Bell", "Gomez", "Kelly", "Howard", "Ward", "Cox", "Diaz", "Richardson", "Wood", "Watson", "Brooks", "Bennett", "Gray", "James", "Reyes", "Cruz", "Hughes", "Price", "Myers", "Long", "Foster", "Sanders", "Ross", "Morales", "Powell", "Sullivan", "Russell", "Ortiz", "Jenkins", "Gutierrez", "Perry", "Butler", "Barnes", "Fisher" };
        private static int[] _lastNamesRate = new int[100] { 2376207, 1857160, 1534042, 1380145, 1362755, 1127803, 1072335, 858289, 804240, 783051, 775072, 762394, 720370, 710696, 706372, 698671, 672711, 666125, 644368, 639515, 621536, 605860, 597718, 593542, 548369, 509930, 503028, 501307, 488521, 473568, 465948, 463368, 441242, 440367, 438986, 420091, 413477, 413351, 413086, 412236, 411770, 388987, 371953, 367433, 366215, 362548, 351848, 342237, 335663, 325169, 324246, 317848, 317070, 312899, 312615, 311754, 310125, 300501, 299463, 294795, 294403, 276400, 275041, 270097, 267443, 265916, 264752, 263590, 260385, 254779, 254121, 253771, 251772, 249533, 247299, 242432, 240751, 239055, 236713, 233224, 232511, 231065, 229390, 228756, 224824, 223494, 221040, 220902, 219961, 217642, 216553, 215640, 215432, 214683, 213737, 212905, 212644, 210879, 210426, 210279 };
        private static string[] _citiesNames = new string[] { "Berlin", "Madrid", "Rome", "Bucharest", "Paris", "Vienna", "Hamburg", "Warsaw", "Budapest", "Barcelona", "Munich", "Milan", "Prague", "Sofia", "Cologne", "Stockholm", "Naples", "Turin", "Amsterdam", "Marseille", "Zagreb", "Copenhagen", "Valencia", "Krakow", "Frankfurt", "Seville", "Todz", "Zaragoza", "Athens", "Palermo", "Helsinki", "Rotterdam", "Wrocław", "Stuttgart", "Riga", "Dusseldorf", "Vilnius", "Leipzig", "Dortmund", "Essen", "Gothenburg", "Genoa", "Malaga", "Bremen", "Dresden", "Dublin", "The", "Hague", "Hanover", "Poznan", "Antwerpen", "Nuremberg", "Lyon", "Lisbon", "Duisburg", "Toulouse", "Gdansk", "Murcia", "Tallinn", "Bratislava", "Palma de Mallorca", "Szczecin", "Bologna", "BrnoIași", "Florence", "Las", "Palmas", "Bochum", "Utrecht", "Wuppertal", "Aarhus", "Bydgoszcz", "Plovdiv", "Bilbao", "Malmö", "Nice", "Lublin", "Varna", "Bielefeld", "Alicante", "Timișoara", "Bonn", "Córdoba", "Thessaloniki", "Cluj-Napoca", "Bari", "Constanța", "Münster", "Karlsruhe", "Catania", "Mannheim", "Nantes", "Craiova", "Galați" };
        private static int[] _citiesNamesRate = new int[] { 3669495, 3348536, 2856133, 2155240, 2140526, 1921153, 1899160, 1793579, 1752286, 1620343, 1558395, 1404239, 1324277, 1241675, 1085664, 974073, 959188, 875698, 873289, 868277, 804049, 794128, 791413, 780981, 753056, 688711, 677286, 666880, 664046, 663401, 657674, 651870, 643782, 635911, 627487, 619294, 590123, 587857, 587010, 583393, 579281, 578000, 571026, 569352, 554649, 554554, 545273, 538068, 533830, 525935, 518365, 515695, 506654, 498590, 479638, 471525, 447182, 441101, 432864, 409661, 400990, 390636, 381346, 378954, 378839, 378517, 364628, 357676, 354382, 349977, 346739, 346893, 345821, 344166, 342637, 339547, 336505, 333786, 331577, 328186, 327258, 325708, 325182, 324960, 320862, 317832, 314319, 313092, 311584, 309370, 306694, 305386, 304050 };
        private static string[] _toutnamentAjectives = new string[] { "Inter-city", "International", "Open International", "Local Open", "Pre-season", "Athletic", "Great", "Open", "Grand", "Classic", "Local", "Spring", "Summer", "Autumn", "Winter" };

        //Generation Methods
        public static string GenerateCityName()
        {
            return RandomChooser(_citiesNames, _citiesNamesRate);
        }
        public static string GenerateFullMaleName()
        {
            string firstName = GenerateMaleName();
            string middleName = GenerateMaleName(firstName);
            string lastName = GenerateLastName();
            return firstName + " " + middleName + " " + lastName;
        }
        public static string GenerateFullFemaleName()
        {
            string firstName = GenerateFemaleName();
            string middleName = GenerateFemaleName(firstName);
            string lastName = GenerateLastName();
            return firstName + " " + middleName + " " + lastName;
        }
        public static string GenerateCupName()
        {
            string cityName = GenerateCityName();
            string ajective = RandomChooser(_toutnamentAjectives);
            return cityName + " " + ajective + " Cup";
        }
        public static string GenerateChampionshipName()
        {
            string cityName = GenerateCityName();
            string ajective = RandomChooser(_toutnamentAjectives);
            return cityName + " " + ajective + " Championship";
        }
        private static string GenerateMaleName()
        {
            return RandomChooser(_maleNames, _maleNamesRate);
        }
        private static string GenerateMaleName(string forbiddenName)
        {
            string name;
            do
            {
                name = GenerateMaleName();
            } while (name == forbiddenName);
            return name;
        }
        private static string GenerateFemaleName()
        {
            return RandomChooser(_femaleNames, _femaleNamesRate);
        }
        private static string GenerateFemaleName(string forbiddenName)
        {
            string name;
            do
            {
                name = GenerateFemaleName();
            } while (name == forbiddenName);
            return name;
        }
        private static string GenerateLastName()
        {
            return RandomChooser(_lastNames, _lastNamesRate);
        }
        
        //Random Methods
        private static string RandomChooser(string[] data)
        {
            Random random = new Random();
            int itemPosition = random.Next(0, data.Length);
            return data[itemPosition];
        }
        private static string RandomChooser(string[] data, bool isRanked)
        {
            if (!isRanked)
            {
                return RandomChooser(data);
            }
            else
            {
                double rankSum = 0.0;
                for (int i = 0; i < data.Length; i++)
                {
                    rankSum += 1.0 / (double)i;
                }
                Random random = new Random();
                double rank = rankSum * random.NextDouble();
                double currentSum = 0.0;
                for (int i = 0; i < data.Length; i++)
                {
                    currentSum += 1.0 / (double)i;
                    if (rank <= currentSum)
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
