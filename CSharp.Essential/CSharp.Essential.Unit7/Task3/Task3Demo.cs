namespace CSharp.Essential.Unit7
{
    public class Task3Demo
    {
        public static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Changed";
        }

        public static void StructTaker(ref MyStruct myStruct)
        {
            myStruct.change = "Changed";
        }
    }
}