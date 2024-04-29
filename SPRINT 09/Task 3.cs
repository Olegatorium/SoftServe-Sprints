using System;
using System.Threading.Tasks;


public class CalcAsync2
{
    public static async Task<int> SeqAsync(int n)
    {
        return await Task.Run(() => Calc.Seq(n));
    }

    public static async void PrintSeqElementsConsequentlyAsync(int quant)
    {
        for (int i = 1; i <= quant; i++)
        {
            int result = await SeqAsync(i);
            Console.WriteLine($"Seq[{i}] = {result}");
        }
    }

    public static async void PrintSeqElementsInParallelAsync(int quant)
    {
        Task<int>[] tasks = GetSeqAsyncTasks(quant);
        await Task.WhenAll(tasks);

        for (int i = 0; i < tasks.Length; i++)
        {
            Console.WriteLine($"Seq[{i + 1}] = {tasks[i].Result}");
        }
    }

    public static Task<int>[] GetSeqAsyncTasks(int quant)
    {
        Task<int>[] tasks = new Task<int>[quant];

        for (int i = 0; i < quant; i++)
        {
            tasks[i] = SeqAsync(i + 1);
        }

        return tasks;
    }

    // one-more option:

    public class CalcAsync
    {
        public static async Task<int> SeqAsync(int n)
        {
            return Calc.Seq(n);
        }

        public static async Task PrintSeqElementsConsequentlyAsync(int quant)
        {
            for (int i = 1; i <= quant; i++)
            {
                int result = await SeqAsync(i);
                Console.WriteLine($"Seq[{i}] = {result}");
            }
        }

        public static async Task PrintSeqElementsInParallelAsync(int quant)
        {
            Task<int>[] tasks = GetSeqAsyncTasks(quant);
            await Task.WhenAll(tasks);

            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine($"Seq[{i + 1}] = {tasks[i].Result}");
            }
        }

        public static Task<int>[] GetSeqAsyncTasks(int quant)
        {
            Task<int>[] tasks = new Task<int>[quant];

            for (int i = 0; i < quant; i++)
            {
                tasks[i] = SeqAsync(i + 1);
            }

            return tasks;
        }
    }
}