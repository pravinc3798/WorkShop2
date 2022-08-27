namespace ClassPractise
{
    public class Swap
    {
        public static void GetSwapedNumber()
        {
            try
            {
                Console.Write("\nEnter First Number : "); var first = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Second Number : "); var second = Convert.ToInt32(Console.ReadLine());

                first = first * second;
                second = first / second;
                first = first / second;

                Console.WriteLine("\n >>>> First Number : {0}, Second Number : {1} \n", first, second);
            }
            catch (Exception)
            {
                Console.WriteLine("\n !!! Try Again !!!");
                GetSwapedNumber();
            }
            
        }
    }
}