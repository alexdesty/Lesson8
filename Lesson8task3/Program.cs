using System.Text;

namespace Lesson8task3;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter string: ");
        var userString = new StringBuilder(Console.ReadLine());
        Console.WriteLine($"Lowercase string: {(userString.ToString()).ToLower()}");
        Console.WriteLine($"Uppercase string: {(userString.ToString()).ToUpper()}");
        Console.Write($"The first letter of each word in uppercase: {((userString[0]).ToString()).ToUpper()}");
        for (int i = 1; i < userString.Length; i++)
        {
            if (userString[i - 1] == ' ')
            {
                Console.Write(((userString[i]).ToString()).ToUpper());
            }
            else
            {
                Console.Write(userString[i]);
            }
        }
    }
}

