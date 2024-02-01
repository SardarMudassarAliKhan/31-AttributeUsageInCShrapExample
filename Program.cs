using System;
using System.Diagnostics;

// Define a custom attribute with AttributeUsage
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
class CustomAttribute : Attribute
{
    public CustomAttribute()
    {
        Console.WriteLine("CustomAttribute constructor called.");
    }
}

// Define a class with a method marked with Conditional attribute
class ConditionalClass
{
    [Conditional("DEBUG")]
    public void DebugMethod()
    {
        Console.WriteLine("This method will only be called in DEBUG mode.");
    }
}

class Program
{
    // Mark a method with Obsolete attribute
    [Obsolete("This method is obsolete. Use NewMethod instead.")]
    public static void OldMethod()
    {
        Console.WriteLine("This is the old method.");
    }

    public static void NewMethod()
    {
        Console.WriteLine("This is the new method.");
    }

    [Custom]
    public static void MethodWithCustomAttribute()
    {
        Console.WriteLine("This method has a custom attribute.");
    }

    public static void Main(string[] args)
    {
        // Call the method marked with Conditional attribute
        ConditionalClass conditionalClass = new ConditionalClass();
        conditionalClass.DebugMethod();

        // Call the method marked with Obsolete attribute
        OldMethod(); // Produces a warning in IDE due to Obsolete attribute

        // Call the method marked with Custom attribute
        MethodWithCustomAttribute(); // Outputs message from CustomAttribute constructor

        Console.ReadLine();
    }
}
