# C# Primitive Data Types

In Java, there are two categories of data types:

1. **Built-in value types** for storing simple values like numbers, strings and booleans.
2. **Built-in reference types** more advanced types for storing collections and objects.

## Learning Objectives

- Explain what primitive data types are
- Build a simple C# program using primitive data types
- Build a simple C# program using strings

## Primitive Types

| Data Type | Examples                                                  | Purpose                                                                                       |
| --------- | --------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| Built-in types             | ---------------------------------------- | --------------------------------------------------------------------------------------------- |
| boolean (System.Boolean)   | `true`, `false`                          | Answer yes or no questions                                                                    |
| byte (System.Byte)         | `0`, `20`, `127`                         | Store whole numbers from 0 to 256                                                             |
| short (System.Int16)       | `-32768`, `0`, `20`, `32767`             | Store whole numbers from -32768 to 32767                                                      |
| int (System.Int32)         | `-2Billion`, `0`, `20`, `2Billion`       | Store whole numbers from -2147483648 to 2147483647                                            |
| long (System.Int64)        | `-2L`, `0L`, `20L`, `2L`                 | Store whole numbers from -9223372036854775808 to 9223372036854775808                          |
| float (System.Single)      | `-5.91f`, `0.29f`, `2.19f`, `5.67f`      | Store fractional numbers from +-1.5e−45 to +-3.7e+038                                         |
| double (System.Double)     | `-19.99d`, `0.29d`, `2.19d`, `5.67d`     | Store fractional numbers from +-5e−324 to +-1.7e+308. They have double the precision of floats|
| char (System.Char)         | `'A', 'B', 'C'`                          | Store a single character                                                                      |
| Built-in  Reference types  | ---------------------------------------- | --------------------------------------------------------------------------------------------- |
| string (System.String)     | `'This is a string', 'Hello o/', 'Ae'`   | Store a string that is a collection of characters                                             |

```c#
bool myBool = true;
byte myByte = 23;
short myShort = 5000;
int myInt = 100000;
long myLong = 15000000000;
float myFloat = 5.12f; // Floats must have an f at the end
double myDouble = 19.99;
char myChar = 'F'; // Chars must use single quotes
```

As well as the above primitive types, there is also a reference type that we'll need to get comfortable with early on: `String`. Don't worry about what a reference type is right now, we can use strings in the same way we use the primitive types above but the first letter of the data type is capitalised. E.g.

```c#
String myString = "Hello, world!"; // Strings must use double quotes
// Strings are used to store a collection of characters
```

There are a number of useful functions we use often with strings, for example:

```c#
String name = "Nathan";
int length = name.Length; // 6
String upper = name.ToUpper(); // "NATHAN"
```

Here's a useful reference guide for Strings: https://www.w3schools.com/cs/cs_strings.php

## Set up instructions

- Fork this repository and clone the forked version to your machine
- Open the solution `csharp-fundamentals-primitive-types.sln` of the project in Visual Studio 2022
- Wait for Visual Studio to open
- Implement the requirements listed as comments in the `Core.cs` file implement the questions by reading the comments ![](./assets/open_core_code.png)
- When ready to test your solution, click from the top left menu the Test button and then Run All Tests ![](./assets/run_tests.png)
- You can run specific tests from the Tests Explorer Section -> Right click the test you want to run -> click Run ![](./assets/run_test_single.png)

**Note:** Some of the requirements in this exercise may require you to use documentation to figure out the correct solution. When that is the case, links have been provided. Get used to this! A big part of our process is reading documentation to try and find useful information.

## Extensions

Create some classes that could represent any real world object. Start with the sample list below which gets increasingly more difficult, and then think of some of your own.

1. Book (example)

```c#
public class Book {
    public String title = "A Game of Thrones";
    public int publishYear = 1996;
    public float price = 11.99f;
    public String isbn = "0-00-224584-1";
    public String author = "George R. R. Martin";
}
```

2. Car

   - Make, model, transmission type, number of doors, engine litres, engine type, colour, registration

3. Movie

4. Computer

5. Social media post

6. User

7. E-commerce product

8. E-commerce order

## Test Output

When you run a test, it's either going to pass or fail. When it fails, you'll be presented with a big red X next to the test. It is very important to learn to recognize those errors and be able to debug them. 

We can see in the screenshot below that we are failing all of the tests. To check why a test is failing I can click the test that interests me and then at the bottom left we can see that I have a message and a Stack Trace.

The stack trace details in which classes & files the failure happened, and gives you a line number at the end. Most of the lines in the stack trace are irrelevant most of the time, you want to try and identify the files that you're actually working with.






stream of text. This is called a stack trace and, though intimidating, does contain some useful information.

One of the core skills of a developer is debugging stack traces like this. The stack trace details in which classes & files the failure happened, and gives you a line number at the end. Most of the lines in the stack trace are irrelevant most of the time, you want to try and identify the files that you're actually working with.

In the sample screenshot below, we've tried to complete the first step of the exercise but provided an invalid value. Then we run the test associated with it and we see a big red stack trace, a test failure.

At the top, we see `expected: 512 but was: 0`. This means the test expected the value to be 512, but the value the student provided was 0.

In the stack trace itself, we see this line: `1.  at csharp_fundamentals_primitive_types.Test.CoreTests.twoShouldBe512() in C:\Dev\boolean\csharp\fundamentals\csharp-fundamentals-primitive-types\src\csharp-fundamentals-primitive-types.Test\CoreTests.cs:line 17`. This is helpful! This tells us the exact line in the `CoreTests.cs` file (line 17) where the failure happened, as well as the method name (twoShouldBe512), helping us to identify where the issue began. This is the kind of thing you need to look for; a relevant file name, method name, class name and line number to give you a good starting point for debugging.

![](./assets/test-failure.png)
