using System;
using System.Linq;

namespace testSolution
{
    class Program
    {
        public class HelpAttribute : Attribute
        {
            string url;
            string topic;
            public HelpAttribute(string url)
            {
                this.url = url;
            }

            public string Url => url;

            public string Topic
            {
                get { return topic; }
                set { topic = value; }
            }
        }

        [Help("https://docs.microsoft.com/dotnet/csharp/tour-of-csharp/attributes")]
        public class Widget
        {
            [Help("https://docs.microsoft.com/dotnet/csharp/tour-of-csharp/attributes",
            Topic = "Display")]
            public void Display(string text) { }
        }




        static Class2 class2 = new Class2();
        static Class1 class1 = new Class1();
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello World!"); Console.WriteLine("Hello World!"); Console.WriteLine("Hello World!");

            //Console.WriteLine("你好  世界");

            //class2.PrintMy2();
            //class1.PrintMy();

            //Console.WriteLine("Solution 改变");
            //Console.WriteLine("netcoreapp3.3");


            //Type widgetType = typeof(Widget);

            ////Gets every HelpAttribute defined for the Widget type
            //object[] widgetClassAttributes = widgetType.GetCustomAttributes(typeof(HelpAttribute), false);

            //if (widgetClassAttributes.Length > 0)
            //{
            //    HelpAttribute attr = (HelpAttribute)widgetClassAttributes[0];
            //    Console.WriteLine($"Widget class help URL : {attr.Url} - Related topic : {attr.Topic}");
            //}

            //System.Reflection.MethodInfo displayMethod = widgetType.GetMethod(nameof(Widget.Display));

            ////Gets every HelpAttribute defined for the Widget.Display method
            //object[] displayMethodAttributes = displayMethod.GetCustomAttributes(typeof(HelpAttribute), false);

            //if (displayMethodAttributes.Length > 0)
            //{
            //    HelpAttribute attr = (HelpAttribute)displayMethodAttributes[0];
            //    Console.WriteLine($"Display method help URL : {attr.Url} - Related topic : {attr.Topic}");
            //}

            //Console.ReadLine();

            Console.ReadLine();
            Console.WriteLine("Solution 改变");
            Console.WriteLine("netcoreapp3.3");
            Console.WriteLine("Solution 改变");
            Console.WriteLine("netcoreapp3.3"); Console.WriteLine("Solution 改变");
            Console.WriteLine("netcoreapp3.3"); Console.WriteLine("Solution 改变");
            Console.WriteLine("netcoreapp3.3");
            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));
            // Output:
            // 4 9 16 25
            // 4 9 16 25
            // 4 9 16 25
            // 4 9 16 25
            // 4 9 16 25
            // 4 9 16 25
            // 4 9 16 25
        }
    }
}
