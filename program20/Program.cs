namespace program20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraynum = { 11, 2, 33, 4, 5,46, 7, 8, 55, 10, 11, 12, 10, 14, 15, 86, 17, 28, 19, 20, 21, 22, 23, 24 };
            int largest  = arraynum[0];
            int  secondlargest = arraynum[0];
            for (int i = 1; i < arraynum.Length; i++)
            {
                if (largest < arraynum[i])
                {
                    largest = arraynum[i];
                }
            }
            secondlargest = arraynum[0];
            for (int i = 0; i < arraynum.Length; i++)
            {
                if (arraynum[i] > secondlargest && arraynum[i] < largest)
                {
                    secondlargest = arraynum[i];
                }
            }

            
            Console.WriteLine(" second lagest number is:" + secondlargest);
        }
    }
}
