namespace program19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter the year");
            int year=int.Parse(Console.ReadLine());
            if ((year % 100 != 0 && year % 4 == 0) || (year % 400 ==0))
            {

                Console.WriteLine(" thes year " +year+ "leap year ");
            }

            else
            {
                Console.WriteLine("thes year"+year+" not leap year ");
            }

        }
    }
}
