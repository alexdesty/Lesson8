using System.Text;

namespace Lesson8task2;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter string: ");
        var userString = new StringBuilder(Console.ReadLine());
        Console.WriteLine("String without spaces:");
        for (int i = 0;i < userString.Length;i++)
        {
            if (userString[i] != ' ')
            {
                Console.Write(userString[i]);
            }
        }
    }
}
