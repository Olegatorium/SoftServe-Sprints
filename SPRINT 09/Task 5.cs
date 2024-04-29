using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class CalcAsync3
{
    public static async Task PrintSpecificSeqElementsAsync(int[] numbers)
    {
        List<Exception> exceptions = new List<Exception>();

        // Iterate over each number in the input array
        foreach (int num in numbers)
        {
            // Create a task for each calculation
            Task task = Task.Run(async () =>
            {
                try
                {
                    int result = await Task.Run(() => Calc.Seq(num));
                    Console.WriteLine($"Seq[{num}] = {result}");
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                }
            });


            await task;
        }

        // Print out exceptions
        if (exceptions.Count > 0)
        {
            foreach (var ex in exceptions)
            {
                Console.WriteLine($"Inner exception: {ex.Message}");
            }
        }
    }
}



// second various

public class CalcAsync4
{
    public static async Task PrintSpecificSeqElementsAsync(int[] numbers)
    {
        List<Exception> exceptions = new List<Exception>();
        List<Task> tasks = new List<Task>();

        foreach (int num in numbers)
        {
            Task task = Task.Run(() =>
            {
                try
                {
                    int result = Calc.Seq(num);
                    Console.WriteLine($"Seq[{num}] = {result}");
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                }
            });

            tasks.Add(task);
        }

        Task allTasks = Task.WhenAll(tasks);
        await allTasks;

        if (exceptions.Count > 0)
        {
            foreach (var ex in exceptions)
            {
                Console.WriteLine($"Inner exception: {ex.Message}");
            }
        }
    }
}

// the most correct variant:

public class CalcAsync5
{
    public static async Task PrintSpecificSeqElementsAsync(int[] numbers)
    {
        List<Exception> exceptions = new List<Exception>();

        foreach (int num in numbers)
        {
            Task task = Task.Run(() =>
            {
                try
                {
                    int result = Calc.Seq(num);
                    Console.WriteLine($"Seq[{num}] = {result}");
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                }
            });

            await task;
        }

        if (exceptions.Count > 0)
        {
            foreach (var ex in exceptions)
            {
                Console.WriteLine($"Inner exception: {ex.Message}");
            }
        }
    }
}