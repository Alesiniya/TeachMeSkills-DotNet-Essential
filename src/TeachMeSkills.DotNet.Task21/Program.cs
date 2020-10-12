using System;

namespace TeachMeSkills.DotNet.Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            myClass MyClass = new myClass();
            myStruct MyStruct = new myStruct();
            Console.WriteLine("-------");
            MyClass.change = "source";
            MyStruct.change = "source";
            ClassTaker(MyClass);
            StructTaker(MyStruct);
            Console.WriteLine(MyClass.change);
            Console.WriteLine(MyStruct.change);
        }
        static void ClassTaker(myClass MyClass)
        {
            MyClass.change = "changed";
        }
        static void StructTaker(myStruct MyStruct)
        {
            MyStruct.change = "changed";
        }
    }
}
