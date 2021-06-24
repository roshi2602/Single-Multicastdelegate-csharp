using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//in this, deligate is assigned to single method at a time
namespace SingleCastDelegate
{
    //Single cast Delegate
    //create method first then create delegate

    public delegate void DemoDelegate(int n1, int n2);
    class Program
    {
        //1 method
        public static void Demo(int n1, int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("{0}", res);
        }

        //--------------------------------------
        //Multicast delegates
        //when delegate is wrapped with more than 1 method
        //we use += and -= operators in this
        public static void Add(int a, int b)     //make method and delegate have same signature
        {
            int c = a + b;
            Console.WriteLine("addition{0}", c);
        }

        public static void Sub(int a, int b)     //make method and delegate have same signature
        {
            int c = a - b;
            Console.WriteLine("subtaction{0}", c);
        }

        //----------------------------------
        static void Main()
        {
            //for singlecast delegate
            DemoDelegate dd = new DemoDelegate(Demo);
            dd.Invoke(5, 10);
           
            //---------------------------------------------
            //for multicast delegate
            DemoDelegate dg = new DemoDelegate(Add);

            dg += Sub;  //using same object and sending reference of Sub method  //+=, -+ used in multicast delegate
            dg(150, 50);

            Console.ReadLine();
        }

     
    }
}
