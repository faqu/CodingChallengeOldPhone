
namespace OldPhoneApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digit The numbers");
            string Numb = Console.ReadLine();
            Console.WriteLine(OldPhonePad(Numb));
        }
        public static String OldPhonePad(string input)
        {
            var Dict = new Dictionary<string, List<string>>()
            {
                { "1", new List<string> { "&", "'", "(" } },
                { "2", new List<string> { "A", "B", "C" } },
                { "3", new List<string> { "D", "E", "F" } },
                { "4", new List<string> { "G", "H", "I" } },
                { "5", new List<string> { "J", "K", "L" } },
                { "6", new List<string> { "M", "N", "O" } },
                { "7", new List<string> { "P", "Q", "R","S" } },
                { "8", new List<string> { "T", "U", "V" } },
                { "9", new List<string> { "W", "X", "Y","Z" } },
                { "*", new List<string> { "DEL"} },
                { "0", new List<string> { "ESP"} },
                { ">", new List<string> { "#"} },
            };

            string Tester = "Tester"; 
            return Tester;
            
        }
    }
}
