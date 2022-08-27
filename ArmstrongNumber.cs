namespace ClassPractise
{
    public class ArmstrongNumber
    {
        public static void CheckNumber()
        {
            try
            {
                Console.Write("\n Input a number : "); var input = Console.ReadLine();
                
                var sum = 0;
                for(int i = 0; i < input.Length; i++)   
                {
                    var number = (int) Char.GetNumericValue(input[i]);
                    sum += number * number * number;
                }

                if (Convert.ToInt32(input) == sum)
                    Console.WriteLine("\n >>>> {0} is a ArmStrong Number", input);
                else
                    Console.WriteLine("\n >>>> {0} is NOT a ArmStrong Number", input);
            }
            catch (Exception)
            {
                Console.WriteLine("\n !!Try Again!!");
                CheckNumber();
            }
        }
    }
}