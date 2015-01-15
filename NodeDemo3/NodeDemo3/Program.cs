using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdgeJs;

namespace NodeDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            StartServer();
            Console.ReadLine();
        }

        static async void StartServer()
        {
                var createHttpServer = Edge.Func(@"
                    var http = require('http');

                    return function (port, cb) {
                        http.createServer(function (req, res) {
                            res.end('Hello, world! ' + new Date());
                        }).listen(port, cb);
                    };
                ");

                await createHttpServer(8080);
        }
    }
}
