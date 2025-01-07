# Uninitialized Property Access in C#

This repository demonstrates a subtle bug in C# related to accessing class properties that haven't been explicitly initialized.  While C# provides default values (0 for ints, null for references, etc.), relying on these defaults can sometimes lead to unexpected behavior or hidden bugs.

The `bug.cs` file shows the problematic code. The `bugSolution.cs` file demonstrates the proper way to initialize the property.

## How to Reproduce
1. Clone the repository.
2. Compile and run `bug.cs`.
3. Observe the output.  While a 0 may be printed, this is not always guaranteed and depends on the specific context and CLR initialization, which can be unpredictable.
4. Compile and run `bugSolution.cs` which addresses the problem.

## Solution
Always explicitly initialize properties, especially those that are critical to the class's functionality or have external dependencies.  This improves code readability, prevents unexpected behavior, and makes debugging easier.