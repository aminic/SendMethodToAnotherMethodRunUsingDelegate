using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMethodToAnotherMethodRunUsingDelegate
{

    public class MessagePool
    {
        public string GetMessage()
        {
            return "this is message";
        }
    }

    public class MainCaller
    {



        public void InvokeMethod(Action method)
        {
            method.Invoke();
        }
        public T InvokeMethod<T>(Func<T> method) where T : class
        {
            return method.Invoke() as T;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var w = new MessagePool();
            var h = new MainCaller();

            var result = h.InvokeMethod<string>(() => w.GetMessage());
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
