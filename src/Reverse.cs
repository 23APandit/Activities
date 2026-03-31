public static class Reverse
{
    public static void ReverseString()
    {
        Console.WriteLine(Constants.dashes);
        Console.WriteLine("Here is the Reverse String program:");
        Console.WriteLine(Constants.dashes);
        Console.Write("Enter a string : ");
        string? userstr = Console.ReadLine();
        if (!String.IsNullOrEmpty(userstr))
        {
            string reverse = string.Empty;
            for (int i = 1; i <= userstr.Length; i++)
            {
                string singleChar = userstr.Substring(userstr.Length - i, 1);
                reverse += singleChar;
            }
            Console.WriteLine($"Reversed string of {userstr} is : {reverse}.");
        }
        else
        {
            Console.WriteLine("Please enter a valid string.");
        }
    }

    public static string GetReversedString(string? userinp)
    {
        string reverse = string.Empty;
        for (int i = 1; i <= userinp?.Length; i++)
        {
            string singleChar = userinp.Substring(userinp.Length - i, 1);
            reverse += singleChar;
        }
        return reverse;
    }
}
