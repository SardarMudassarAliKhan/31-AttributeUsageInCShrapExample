C# program demonstrating the usage of the `AttributeUsage`, `Conditional`, and `Obsolete` attributes:

```csharp
using System;

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
```

This program demonstrates:

1. `AttributeUsage`: The `CustomAttribute` is defined with the `AttributeUsage` attribute to specify that it can only be applied to methods (`AttributeTargets.Method`).

2. `Conditional`: The `DebugMethod` in `ConditionalClass` is marked with the `Conditional` attribute, so it will only be called if the "DEBUG" symbol is defined at compile time.

3. `Obsolete`: The `OldMethod` is marked as obsolete, and a warning will be generated when it's called, suggesting developers use `NewMethod` instead.

4. A custom method `MethodWithCustomAttribute` marked with a custom attribute `CustomAttribute`, which simply outputs a message when called.

When you run this program, you'll see the respective messages printed based on the method calls.
