using System;

namespace Classy
{
    /* Class: ClassOne
     * Author: Jonathan Karcher
     * Purpose: Display random fact one
     */
    public class ClassOne : IClass
    {
        /* Method: StringToReturn
         * Purpose: Display random fact one using the IClass method
         * Restrictions: None
         */
        public void StringToReturn()
        {
            Console.WriteLine("Random fact: If two pieces of similar metals touch in a vacuum, and if both pieces are perfectly flat and polished, \nthey will fuse to effectively make one new piece.");
        }
    }
    /* Class: ClassTwo
     * Author: Jonathan Karcher
     * Purpose: Display random fact two
     */
    public class ClassTwo : IClass
    {
        /* Method: StringToReturn
         * Purpose: Display random fact two using the IClass method
         * Restrictions: None
         */
        public void StringToReturn()
        {
            Console.WriteLine("Random fact: The King's holly plant reproduces by cloning, since the reproduction is vegetative, all the plants in \nthe colony are genetically identical making the entire grove a clone.");
        }
    }
    /* Interface: IClass
     * Author: Jonathan Karcher
     * Purpose: Create an interface that connects ClassOne and ClassTwo
     */
    public interface IClass
    {
        /* Method: StringToReturn
         * Purpose: Act as a connection between ClassOne and ClassTwo
         * Restrictions: None
         */
        void StringToReturn();
    }
    /* Class: Program
     * Author: Jonathan Karcher
     * Purpose: Manage how ClassOne and ClassTwo are displayed
     */
    class Program
    {
        /* Method: Main
         * Purpose: Entery point for the program
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            // create a ClassOne
            ClassOne one = new ClassOne();
            // create a ClassTwo
            ClassTwo two = new ClassTwo();
            // call MyMethod with ClassOne
            MyMethod(one);
            // newLine
            Console.WriteLine();
            // call MyMethod with ClassTwo
            MyMethod(two);
            // newLine
            Console.WriteLine();
        }
        /* Method: MyMethod
         * Purpose: using an object entered display the content in StringToReturn from IClass
         * Restrictions: None
         */
        public static void MyMethod(object myObject)
        {
            // set an interface equal to myObject and cast it as an interface
            IClass c = (IClass)myObject;
            // output the StringToReturn that the interface is referencing
            c.StringToReturn();
        }
    }
}
