/*namespace practice_task18
{
    internal class Program
    {

        class encaptulate_task
        {
            private string EmployeeName;
            private string EmployeeAddress;
            private string EmployeeId;

            public string Name
            {
                get
                {
                    return EmployeeName;
                }
                set
                {
                    EmployeeName = value;
                }
            }
            public string Address
            {
                get
                {
                    return EmployeeAddress;
                }
                set
                {
                    EmployeeAddress = value;
                }
            }
        }
        class class1
        {
            static void Main(string[] args)
            {
                encaptulate_task obj = new encaptulate_task();
                obj.Name = " arunkumar";
                obj.Address = "hyderabad";
                Console.WriteLine("Encaptulation");
                Console.WriteLine("Name" + "   " + obj.Name);
                Console.WriteLine("Adress" + "   " + obj.Address);
            }
        }
    }
}*/
/*namespace practice_task18
{
    internal class Program
    {

        class class1
        {

            public class1()
            {
                Console.WriteLine("this is constructor with out parameters");
            }
            public class1(int i)
            {
                int number = i;
                Console.WriteLine(number);
            }
            public class1(int i, int j)
            {
                int number0 = i;
                int number1 = j;
                int number2 = number0 + number1;
                Console.WriteLine("additon of the these two number" + number2);

            }


        }
        class class2
        {
            public static void Main(String[] args)
            {
                class1 obj = new class1();
                class1 obj1 = new class1(1);
                class1 obj2 = new class1(1, 2);
            }
        }
    }

}*/
/*
namespace practice_task18
{
    internal class Program
    {

        class class1
        {
            public class1()
            {
                Console.WriteLine("this instance constructor of class1");

            }
            static class1()
            {
                Console.WriteLine("this is static constructor of class1");
            }
        }
        class class2 : class1
        {
            public class2()
            {
                Console.WriteLine("this instance constructor of class2");
            }
            static class2()
            {
                Console.WriteLine("this is static constructor class2");
            }
        }
        class class3
        {


            public static void Main(string[] args)
            {
                class2 obj = new class2();
            }
        }
    }
}*/
/*namespace practice_task18
{
    internal class Program
    {
        public class Class3
        {
            public void Dispaly()
            {
                Console.WriteLine("this the base class");
            }
        }
        public class class2 : Class3
        {
            new public void Display() //this is overrided method from base collection
            {
                Console.WriteLine("this is overided class");
            }
        }
        class simple
        {
            public static void Main(string[] args)
            {
                class2 obj = new class2();
                Class3 obj1 = new Class3();
                obj1.Dispaly();
                obj.Dispaly();
            }
        }
    }
}
*/
