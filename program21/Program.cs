namespace program21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("write a sentence");
            string sentence = Console.ReadLine();

            int count = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i]=='a'||
                    sentence[i] =='i'||
                    sentence[i] =='u'||
                    sentence[i] =='o'||
                    sentence[i] =='e' )
                {

                    count++;
                }
            }


            Console.WriteLine(" thes is " + count);





           
        }
    }
}
