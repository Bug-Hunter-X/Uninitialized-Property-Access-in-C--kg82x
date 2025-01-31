public class MyClass
{
    public int MyProperty { get; set; } = 0; // Initialize in the declaration

    public MyClass() { MyProperty = 0; } // Alternatively, initialize in the constructor

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now this is safe
    }
}