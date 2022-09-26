internal static class Program
{
    static void Main(string[] args)
    {
        User user = new User("SergGol2004", "Serg", "Gol", DateTime.Now.Year - 2004);
        
        Console.WriteLine(user);
    }
}