namespace ClassPractise
{
    public class Case
    {
        public static void CheckCase()
        {
            try
            {
                Console.Write("\nEnter a string : "); var input = Console.ReadLine();

                var upper = "";
                var lower = "";

                foreach (var alphabet in input)
                {
                    if (alphabet == char.ToUpper(alphabet))
                        upper += alphabet;
                    else
                        lower += alphabet;
                }
                Console.WriteLine("\n >>>> Upper case characters : {0}, Lower case characters : {1} \n", upper, lower);
            }
            catch (Exception)
            {
                Console.WriteLine("\n !!Try Again !! \n");
                CheckCase();
            }
        }
    }
}