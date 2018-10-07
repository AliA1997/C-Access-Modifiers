using System;

namespace AccessModifiersTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Define your instance of your class.
            PublicClass exampleClass = new PublicClass(name1: "Name 1", name2: "Name 2", name3: "Name 3", name4: "Name 4", name5: "Name 5"); 
            //Log your private property to console.
            //It will give your error, it can only be accessed within the class.
            //Console.WriteLine(exampleClass.Name1);
            //Log your protected property to the console.
            //It will give you a error, it can only be accessed within class or another class inherited.
            //Console.WriteLine(exampleClass.Name2);
            //Log your internal property which would log into the console, since it is in the same assembly/namespace.
            Console.WriteLine(exampleClass.Name3);
            //Log your public property which would be logged into the console.
            //Since it can be accessed throughout the application.
            Console.WriteLine(exampleClass.Name4);
            //Can combine multiple access modifiers.
            //You can combine protected and internal, so it can be accessed in a class and a derived class
            //and the same assembly/namespace.
            Console.WriteLine(exampleClass.Name5);
        }
    }
}
