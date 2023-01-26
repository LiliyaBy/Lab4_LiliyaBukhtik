namespace Lab4_LiliyaBukhtik
{
    internal class Program
    {
        static void Main()
        {
            string str1 = "3490-abc-4971-dxy-1a2b";

            PlayingWithStrings p = new PlayingWithStrings();
            p.Write1(str1);
            p.Write2(str1);
            p.Write3(str1);
            Console.WriteLine(p.Write4(str1));
            Console.WriteLine(p.Write5(str1));
            Console.WriteLine(p.Write6(str1));
            Console.WriteLine(p.Write7(str1));
        }
    }
}