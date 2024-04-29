using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Calc
{
    // sample
    public static int Seq(int n)
    {
        // Define your sequence generation logic here
        // For example, let's use the Fibonacci sequence
        if (n <= 2)
            return 1;

        int a = 1, b = 1, c = 0;
        for (int i = 3; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }
}

public class CalcAsync
{
    public static async IAsyncEnumerable<(int, int)> SeqStreamAsync(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            int result = await Task.Run(() => Calc.Seq(i));
            yield return (i, result);
        }
    }

    public static async Task PrintStream(IAsyncEnumerable<(int, int)> stream)
    {
        await foreach (var tuple in stream)
        {
            Console.WriteLine($"Seq[{tuple.Item1}] = {tuple.Item2}");
        }
    }
}