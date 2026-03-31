public class Palindrome
{
    public void CheckPalindrome()
    {
        Console.WriteLine(Constants.dashes);
        Console.WriteLine("Here is the Palindrome check program:");
        Console.WriteLine(Constants.dashes);
        Console.Write("Enter a string : ");
        string? userstr = Console.ReadLine();
        userstr = userstr?.Trim().ToLower();
        if (userstr == Reverse.GetReversedString(userstr))
        {
            Console.WriteLine("It's a Palindrome.");
        }
        else
        {
            Console.WriteLine("Not a Palindrome.");
        }
    }
}
