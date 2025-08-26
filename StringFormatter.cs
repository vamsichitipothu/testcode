using System.Text;

namespace PointsBet_Backend_Online_Code_Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string[] items = { "apple", "banana", "orange" };
            string result = StringFormatter.ToCommaSeparatedList(items, "\"");
            Console.WriteLine(result);
        }
    }
    public class StringFormatter
    {

        public static string ToCommaSeparatedList(string[] items, string quote)
        {

            if (items == null || items.length == 0)
            {
                return "";
            }
            string result = "";
            {
                for (int i = 0; i < items.Length; i++)
                {
                    result += quote + items[i] + quote;

                    if(i != items.Length - 1)
                    {
                        result += ", ";
                    }
                }
            }

            return result;
        }
    }
}
