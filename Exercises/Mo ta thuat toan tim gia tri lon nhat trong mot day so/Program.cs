internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap so luong phan tu trong day so:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Nhap phan tu thu {0}:",(i+1));
            arr[i] = int.Parse(Console.ReadLine());
        }

        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        Console.WriteLine("Gia tri lon nhat trong day so la: {0}",max);
        
    }
}