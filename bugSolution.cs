public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize to 0

    public ExampleClass(int initialValue)
    {
        MyProperty = initialValue;
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now it is guaranteed to have a value.
    }
}