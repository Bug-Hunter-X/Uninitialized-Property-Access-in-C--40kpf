public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized
        Console.WriteLine(MyProperty); //This may output 0, but it's better to initialize it.
    }
}