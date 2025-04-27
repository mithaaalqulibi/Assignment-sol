namespace program10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2,90, 4, 44, 6, 7, 8, 9, 10, 11, 65, 13, 14, 15, 16, 17, 23, 19, 20, 21, 22 };
             Array.Sort(arr);
            Console.WriteLine( "the arr after sort");
            foreach (int i in arr ) Console.WriteLine( i );
        }
    }
}
