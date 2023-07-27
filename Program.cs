namespace project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                for(int j=n; j >=1; j--)
                {
                    if ((i>=j))
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}