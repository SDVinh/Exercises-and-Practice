internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap so diem cua hoc vien: ");
        int diem = int.Parse(Console.ReadLine());

        if (0<= diem && diem <=100)
            {
                if ( 35>diem)
            {
                Console.WriteLine("Loại E");
            }
            else if ( 35<=diem && diem <45)
            {
                Console.WriteLine("Loại D");
            }
            else if ( 45<=diem && diem <60)
            {
                Console.WriteLine("Loại C");
            }
            else if ( 60<=diem && diem <75)
            {
                Console.WriteLine("Loại B");
            }
            else if ( diem >= 75)
            {
                Console.WriteLine("Loại A");
            }
        }
        else
        {
            Console.WriteLine("Nhap lai diem cua hoc vien");
        }
    }
}