using System;
using Parent;
/// <summary>
/// Access is limited to the current assembly or the derived types of the containing class. It means access is granted to any class which is derived from the containing class within or outside the current Assembly.
/// </summary>
namespace Protected_Internal
{

    class Child : Parent.Parent
    {

        // Main Method
        public static void Main(String[] args)
        {
            // Accessing value in another assembly
            Child obj3 = new Child();

            // Member value is Accessible
            obj3.value = 9;
            Console.WriteLine("Value = " + obj3.value);
        }
    }
}
