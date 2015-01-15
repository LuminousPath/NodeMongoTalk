var http = require('http');
var edge = require('edge');
var port = process.env.port || 1337;

var globalreturn;

var hello = edge.func(function () {/*
    async (input) => { 
        return ".NET welcomes " + input.ToString(); 
    }
*/
});

hello('Node.js', function (error, result) {
    if (error) throw error;
    globalreturn = result;
});

http.createServer(function (req, res) {
    res.writeHead(200, { 'Content-Type': 'text/plain' });
    res.end(globalreturn);
}).listen(port);