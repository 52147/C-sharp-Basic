// Assuming you've added a reference to Assembly A in your project
using AssemblyA;

namespace AssemblyB
{
    public class ClassC
    {
        public void TestMethod()
        {
            ClassA classAInstance = new ClassA();
            // classAInstance.MethodA(); 
            // This line would cause a compile-time error because MethodA is 'internal' 
            // and ClassC is in a different assembly, even if it references Assembly A.
        }
    }

    class Program
    {
        static void Main()
        {
            ClassC classCInstance = new ClassC();
            classCInstance.TestMethod();
        }
    }
}
