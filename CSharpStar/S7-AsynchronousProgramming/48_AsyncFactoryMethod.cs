using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStar.S7_AsynchronousProgramming
{
    internal class AsyncFactoryMethod
    {
        public class Foo
        {
            public Foo()
            {

            }
            public async Task<Foo> InitAsync()
            {
                await Task.Delay(1000);
                return this;
            }
            // Factory method
            public static Task<Foo> createAsync()
            {
                var result = new Foo();
                return result.InitAsync();
            }
        }

        public class Demo 
        {
            static async void Main(string[] args)
            {
                /*var foo = new Foo();
                await foo.InitAsync();*/
                Foo x = await Foo.createAsync();
                Console.WriteLine(x);
            }
        }
    }
}
