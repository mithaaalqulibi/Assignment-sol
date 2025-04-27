using System.ComponentModel.DataAnnotations;

namespace program4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arraynum = { 10, 46, 70, 30, 22, 19, 14, 1, 6 };
            int maxenum = 0;
            for (int i = arraynum.Length - 1; i >= 0; i--)
            {
                if (arraynum[i] > maxenum)
                {
                    maxenum = arraynum[i];
                }

            }
                Console.WriteLine("The larg num in arreynum is" + maxenum);
             
        }
    }
}
