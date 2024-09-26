namespace F24W4IntroToLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 3, 5, 6, 7, 4, 2, 3, 5, 6, 3, 5 };

            var greaterThan4 = from n in array
                               where n > 4
                               orderby n
                               select n;

            foreach (var i in greaterThan4)
                Console.Write(i + " ");
            Console.WriteLine("\n\n");



        }
    }
}
