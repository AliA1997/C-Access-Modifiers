using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiersTutorial
{
    class PublicClass
    {
        //Define constructor method
        public PublicClass(string name1, string name2, string name3, string name4, string name5)
        {
            Name1 = name1;
            Name2 = name2;
            Name3 = name3;
            Name4 = name4;
            Name5 = name5;
        }
        //Define your members of your class here.
        //Private is the access level that provides the least accesss, only you can accesss the value within the class.
        private string Name1 { get; set; }
        //Protected is the access level that provides the second least access
        //only you can access the value within a class or a inherited class.
        protected string Name2 { get; set; }
        //internal means it can be accessed in it's current assembly/namespace
        //BUT NOT in a inherited assembly/namespace.
        internal string Name3 { get; set; }
        //public means it can be accessed throughout the application
        //It has the most access. 
        public string Name4 { get; set; }
        //Can combine multiple access modifiers.
        //You can combine protected and internal, so it can be accessed in a class and a derived class
        //and the same assembly/namespace.
        protected internal string Name5 { get; set; }
        //You can also combine protected and private, so it can be accessed in it's class and a derived class.
        //But it is fairly new to c#, so the minimum version would be 7.2
        //private protected string Name6 { get; set; } 
    }
}
