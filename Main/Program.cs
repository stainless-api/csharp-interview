namespace Main;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Random number: " + Random());
    }

    public static int Random() {
        // Chosen by fair dice roll. Guaranteed to be random.
        return 4;
    }
}