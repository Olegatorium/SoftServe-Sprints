using Sprint_11.Task_1;
using Sprint_11.Task_2;
using Sprint_11.Task_3;
using Sprint_11.Task_4;
using Sprint_11.Task_5;
using static Sprint_11.Task_2.ReflectMethod;
using static Sprint_11.Task_3.ReflectProperties;

class Program
{
    private static void Main(string[] args)
    {

        // Task1

        //ReflectFields.MeasureX = 500;
        //ReflectFields.MeasureY = 100;
        //ReflectFields.MeasureZ = 300;
        //ReflectFields.Name = "Hello, Reflection!";
        //ReflectFields.OutputFields();

        // task2

        //string[] parameters = { "Jhon", "Elly" };
        //ReflectMethod.InvokeMethod(parameters);

        // task3
        //ReflectProperties.WriteProperties();

        //task 4
        //ReflectorAssembly.WriteAssemblies();

        //task 5
        ReflectFullClass.WriteAllInClass(typeof(ReflectorAssembly));
    }
}