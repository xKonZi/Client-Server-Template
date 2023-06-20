namespace ClientProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Client";

            Console.ReadKey();
            if (Client.instance == null)
            {
                Client.instance = new Client();
                Client.instance.Start();
            }
            Client.instance.ConnectToServer();
            Console.ReadKey();
        }
    }
}