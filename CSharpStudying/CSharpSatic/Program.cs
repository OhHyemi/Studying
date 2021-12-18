using System;

namespace CSharpSatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var staticField1 = new StaticField(2);

            Console.WriteLine($"field1:{StaticField.field1}, field2:{staticField1.field2}");
            int value = 2;
            StaticField.StaticMethod(value);
        }
    }

    class StaticField
    {
        public static int field1;
        public int field2;

        public StaticField(int num)
        {
            field2 = num;
        }
        static StaticField()
        {
            field1 = 1;
        }

        public static void StaticMethod(int value)
        {
            field1 = value;
        }
    }
}