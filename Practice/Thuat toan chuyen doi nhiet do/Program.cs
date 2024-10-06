internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap nhiet do C: ");
        float C = float.Parse(Console.ReadLine());
        float F = (9*C)/5+32;
        Console.WriteLine(F);
    }
}