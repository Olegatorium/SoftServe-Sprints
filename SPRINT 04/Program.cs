interface A
{
    void Hello();
}

interface B
{
    void Hello();
}

class Test : A, B
{
    void A.Hello()
    {
        Console.WriteLine("Hello from A");
    }

    void B.Hello()
    {
        Console.WriteLine("Hello from B");
    }
}

class Program
{
    static void Main()
    {
        Test myTest = new Test();
        ((A)myTest).Hello();
    }
}
