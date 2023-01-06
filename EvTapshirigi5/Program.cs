namespace EvTapshirigi5
{
    internal class Program
    {
        static void Main(string[] args)
        {   //tek yerde olan cut elementlerin cemi ve sayi
            Console.Write("Massivin uzunlugunu daxil edin: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}]= ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0 && arr[i] % 2 == 0)
                {
                    count++;
                    sum += arr[i];
                }
            }
            Console.WriteLine($"cem: {sum} say: {count}");
        }
    }
}
