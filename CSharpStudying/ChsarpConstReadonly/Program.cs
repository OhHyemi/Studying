using System;

namespace ChsarpConstReadonly
{
    class Program
    {
        private readonly static Test test = new Test();

        static void Main(string[] args)
        {
            TestClass testClass = new TestClass(20);
            
            //const: 클래스에 멤버변수 중 canst변수가 있다면 static변수 처럼 작동함!(단 하나!)
            //readonly: 클래스 인스턴스 마다 각자 다른 값을 가질 수 있음.
            Console.WriteLine($"ValueA: {TestClass.ValueA}, ValueB: {testClass.ValueB}");
            Test test1 = new Test();

            //개체 참조를 바꾸는 것은 불가능
          //  test = test1;//오류!!!
            //개체 내 필드를 바꾸는 것은 가능!
            test.value1 = 3;

        }
    }

    class Test
    {
        public int value1 = 1;
    }
    class TestClass
    {
        //const는 선언 때 값을 초기화해주어야 함.
        public const int ValueA = 10;
        //readonly는 선언때 초기화를 안해줘도 됨.
        public readonly int ValueB;
        //readonly는 생성자에서 초기화가 가능.
        //const는 생성자에서도 불가능 하다.
        private Test test = new Test();
        public TestClass(int value)
        {
            ValueB = value;
        }

        public void Method(int value)
        {
            //둘 다 초기화후에는 값 변경이 불가능 하다!
            //ValueB = value; 
           // ValueA = value;

            //const는 메소드 안에서 선언 가능
            const int valueC = 1;
            //readonly는 불가능 합니다.
           // readonly int valueD
                
        }
    }
}