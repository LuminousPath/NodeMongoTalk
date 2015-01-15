using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdgeJs;

namespace NodeDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            writeit();
            Console.ReadLine();
        }

        static async void writeit()
        {
            var func = Edge.Func(@"
                return function (data, cb) {
                    cb(null, 'Node.js ' + process.version + ' welcomes ' + data);
                }
            ");

            Console.WriteLine(await func(".NET"));
        }
    }
}
