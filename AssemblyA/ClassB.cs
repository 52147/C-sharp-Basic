namespace AssemblyA
{
    public class ClassB
    {
        public void TestMethod()
        {
            ClassA classAInstance = new ClassA();
            classAInstance.MethodA(); // This is valid because ClassB is in the same assembly as ClassA
        }
    }
}
