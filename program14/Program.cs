using System.ComponentModel.Design;

namespace program14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("write a sentence");
            string sentence = Console.ReadLine();
            Console.Write("Type the letter you want to search for");
            char character = Console.ReadLine();
           
            int count = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] ==  character)
                {

                    count++;
                }
            }


            Console.WriteLine(" thes is " + count);




        }
    }
}
