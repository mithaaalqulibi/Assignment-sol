namespace program18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" enter the sentence :");
            string sentence= Console.ReadLine();
            int numvowels = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {

                    numvowels++;
                }
            }
            
            Console.WriteLine(" number of characters without spaces" +"" +numvowels);
        }
    }
}
