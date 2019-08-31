using System;

namespace ClassIntTests
{
    public struct MySimpleStruct
    {
        // public MySimpleStruct()
        // {
        // Error: Structs cannot have parameterless constructors
        // }

        public MySimpleStruct(int dummy)
        {

        }
        // ~MySimpleStruct()
        // {
        //     // Err - Only classess can contain destrotors
        // }

        // Structures can have methods, fields, indexers, properties, operator methods, and events.
        // Structures can have defined constructors, but not destructors. However, you cannot define a 
        // default constructor for a structure. ... Unlike classes, structs can be instantiated without 
        // using the New operator.
    }
    public static class StaticClassTest
    {
        static StaticClassTest()
        {
            System.Console.WriteLine($"In static  constructor");
        }

        public static void Test()
        {
            System.Console.WriteLine($"In static  Test");
        }

        //  public  StaticClassTest(int i)
        // {
        // Error: in static classes you cannot have instance constructors
        //  }
    }

    public class Foo
    {
        public Foo()
        {
            System.Console.WriteLine($"In Foo constructor");
        }

        ~Foo()
        {
            System.Console.WriteLine($"In Foo destructor");
            // A Destructor is unique to its class i.e. there cannot be more than one destructor in a class.
            // A Destructor has no return type and has exactly the same name as the class name (Including the same case).
            // It is distinguished apart from a constructor because of the Tilde symbol (~) prefixed to its name.
            // A Destructor does not accept any parameters and modifiers.
            // It cannot be defined in Structures. It is only used with classes.
            // It cannot be overloaded or inherited.
            // It is called when the program exits.
            // Internally, Destructor called the Finalize method on the base class of object.
        }
    }

    public class Bar : Foo
    {
        public Bar()
        {
            System.Console.WriteLine($"In Bar constructor");
        }
        ~Bar()
        {
            System.Console.WriteLine($"In Bar destructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var bar = new Bar();
            StaticClassTest.Test();
        }
    }
}
