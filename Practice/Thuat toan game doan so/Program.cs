internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap mot so tu 0 den 9: ");
        int N = Convert.ToInt32(Console.ReadLine());
        Random random= new Random();
        int M = random.Next(0,9);

        if (0<= N && N<=9)
        {
            if (N==M)
            {
                Console.WriteLine("Dự đoán đúng");
            }
            else
            {
                Console.WriteLine("Dự đoán sai");
            }
        }
        else
        {
            Console.WriteLine("Vui long nhap lai so tu 0 den 9");
        }
    }
}