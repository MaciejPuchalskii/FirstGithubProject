namespace GithubProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi, welcome to our program.");
            Console.Write("Input any number!:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b;
            if(a%2 == 0)
            {
                b = 2;
            }
            else if(a%3 ==0)
            {
                b = 3;
            }
            else if(a%7 ==0)
            {
                b = 3;
            }
            else
            {
                b = 0;
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Your number is " + a);
            Console.WriteLine(a + " can be divided by " +b);
        }
    }
}