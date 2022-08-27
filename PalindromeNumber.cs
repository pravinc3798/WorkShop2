namespace ClassPractise
{
    public class PalindromeNumber
    {
        public static void CheckNumber()
        {
            try
            {
                Console.Write("\n Input a number : "); var input = Console.ReadLine();
                var reversed = "";

                for (var i = 1; i <= input.Length; i++)
                {
                    reversed += input[input.Length - i];
                }

                if (input == reversed)
                    Console.WriteLine("\n >>>> {0} is a Palindrome", input);
                else
                    Console.WriteLine("\n >>>> {0} is NOT a Palindrome", input);
            }
            catch (Exception)
            {
                Console.WriteLine("\n !!Try Again!!");
                CheckNumber();
            }
        }
    }
}