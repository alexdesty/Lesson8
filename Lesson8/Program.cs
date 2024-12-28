using System.Text;

namespace Lesson8task1;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter string: ");
        var userString = new StringBuilder(Console.ReadLine().ToLower());
        var reversedString = new StringBuilder(userString.ToString());
        var index = 0;
        for (var i = userString.Length - 1;i >= 0;i--)
        {
            reversedString[index] = userString[i];
            index++;
        }
        var isEquals = String.Compare(userString.ToString(), reversedString.ToString());
        if (isEquals != 0)
        {
            Console.WriteLine("The string isn't a palindrome");
        }
        else
        {
            Console.WriteLine("The string is a palindrome");
        }
    }
}
