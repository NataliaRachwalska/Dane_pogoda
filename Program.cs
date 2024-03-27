namespace Dane_pogoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            API api = new API();
            api.GetData().Wait();
        }
    }
}
