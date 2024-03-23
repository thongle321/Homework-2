var http = require('http')
var fs = require('fs')
var url = require('url')
var product = require('./product')
http.createServer((req, res) => {
    let Filename = ''
    let x = url.parse(req.url,true)
    switch(x.pathname)
    {
        case '/':
        case '/home':
            Filename = 'home.html'
            break
        case '/login':
            Filename = 'login.html'
            break
        case '/register':
            Filename = 'register.html'
            break
        case '/product':
            res.writeHead(200, {'Content-Type': 'text/html;charset=utf-8'})
            res.write(product.getProducts(x.query.id,x.query.color))
            res.end()
            return
    }
    fs.readFile(Filename, (err,data) => {
        if(err)
        {
            res.writeHead(404, {'Content-Type': 'text/html;charset=utf-8'})
            res.write('Trang web khong ton tai');
            return res.end()
        }
        res.writeHead(200, {'Content-Type': 'text/html;charset=utf-8'})
        res.write(data)
        return res.end()

    })

}).listen(8080)