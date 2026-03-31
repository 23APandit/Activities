internal class Program
{
    private static void Main(string[] args)
    {
        string? option = string.Empty;
        while (option != "0")
        {
            Console.WriteLine("\n" + Constants.dashes);
            Console.WriteLine("Welcome to the Amazing Options!");
            Console.WriteLine(Constants.dashes);
            Console.WriteLine("These are your options :");
            Console.WriteLine("0 : Exit");
            Console.WriteLine("1 : Reverse a string");
            Console.WriteLine("2 : Max of 3 numbers");
            Console.WriteLine("3 : Check Palindrome");
            Console.WriteLine("4 : Check Anagram");
            Console.WriteLine("5 : Games");
            Console.WriteLine(Constants.dashes);
            Console.Write("Enter your choice : ");
            option = Console.ReadLine();
            if (!String.IsNullOrEmpty(option))
            {
                switch (option)
                {
                    case "0":
                        Console.WriteLine("as requested - exiting...");
                        break;
                    case "1":
                        Reverse.ReverseString();
                        break;
                    case "2":
                        Console.WriteLine("WIP 2");
                        break;
                    case "3":
                        Palindrome p = new Palindrome();
                        p.CheckPalindrome();
                        break;
                    case "4":
                        Console.WriteLine("WIP 4");
                        break;
                    case "5":
                        Console.WriteLine("WIP 5");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
