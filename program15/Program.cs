namespace program15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write the sentence or name");
            string input=Console.ReadLine();
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            string reversed =new string(chars);
            
            Console.WriteLine(" the sentence or the name reversed" + "  "+reversed +" ");
        }
    }
}
