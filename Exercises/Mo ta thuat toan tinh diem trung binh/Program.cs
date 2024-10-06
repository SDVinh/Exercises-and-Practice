internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhap diem toan:");
        float toan = float.Parse(Console.ReadLine());
        Console.Write("Nhap diem ly:");
        float ly = float.Parse(Console.ReadLine());
        Console.Write("Nhap diem hoa:");
        float hoa = float.Parse(Console.ReadLine());

        float average = (toan+ly+hoa)/3;
        Console.WriteLine("Diem trung binh 3 mon: Toan, Ly, Hoa: {0:0.0}", average);
    }
}