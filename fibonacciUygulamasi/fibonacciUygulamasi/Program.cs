internal class Program
{
    private static void Main(string[] args)
    {
        int[] fib = new int[10];
        fib[0] = 0;
        fib[1] = 1; 
        for(int i=2; i<fib.Length; i++)
        {
            fib[i] = fib[i-1] + fib[i-2];
            
        }
        foreach (int i in fib)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
        Console.WriteLine("------------------------");


        Console.WriteLine(fibo(5));

        Console.ReadKey();
    }
    static int fibo(int x)
    {
        if (x <= 0 || x==1) { return 1; }
        else
        {
            return fibo(x - 1) + fibo(x - 2);
        }
    }


}