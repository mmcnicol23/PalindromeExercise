using System.Linq;

namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string myString)
    {
        var reversedString = myString.Reverse();
        if (myString == string.Concat(reversedString))
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}