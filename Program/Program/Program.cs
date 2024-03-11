// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm");
    }

    public static double Avg(int[] arr)
    {
        double sum = 0;
        foreach (int k in arr)
        {
            sum += k;
        }

        return sum / arr.Length;
    }
}