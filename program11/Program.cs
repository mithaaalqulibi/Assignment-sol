namespace program11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraynum = {  3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            int min = arraynum [0];
            for (int i = 0; i < arraynum.Length - 1; i++)
            {
                if (arraynum[i] < min)
                {
                    min = arraynum[i];
                }

            }
                Console.WriteLine( " the smallest number in an array of integers " + min );
            
            
        }
    }
}
