var http = require('http')
var datetime = require('./datetime')
var mes = require('./message')
http.createServer((req, res) => {
    res.writeHead(200, {'Content-type': 'text/html;charset=utf-8'});
    res.write(`<b>Xin chào</b> ${mes.showHello()}`);
    res.end();
}).listen(8080)
