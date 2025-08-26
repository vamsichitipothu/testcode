I've received the below code from HR 

using System.Text;

namespace PointsBet_Backend_Online_Code_Test
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public class StringFormatter
    {

        //Code to improve
        public static string ToCommaSepatatedList(string[] items, string quote)
        {
            StringBuilder qry = new StringBuilder(string.Format("{0}{1}{0}", quote, items[0]));

            if (items.Length > 1)
            {
                for (int i = 1; i < items.Length; i++)
                {
                    qry.Append(string.Format(", {0}{1}{0}", quote, items[i]));
                }
            }

            return qry.ToString();
        }
    }
}
From the above code i've found few issues 
1. Misspelled method name
2. No null/empty check for items
3. Inefficient string concatenation inside loop
4. Overly complicated logic for joining items
5. Could be simplified using string.Join or we can write some basic version of the code

Here's a more basic version of that code, designed to be easier for beginners to understand. It avoids advanced features like arrays and var, and includes simple comments:

1. It first checks if the list is empty or null, and if so, returns an empty string.
2. It then goes through each item in the list.
3. For each item, it adds quotes around it.
4. It adds a comma and space after each item, except the last one.
5. It returns the complete string with all items formatted nicely.

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
