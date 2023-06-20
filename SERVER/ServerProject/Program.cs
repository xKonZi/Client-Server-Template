namespace ServerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Server";

            Server.Start(50, 40050);

            Console.ReadKey();
        }
    }
}