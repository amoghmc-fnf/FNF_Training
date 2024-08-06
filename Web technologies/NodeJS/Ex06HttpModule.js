const http = require("http")
const fs = require("fs")
const root = __dirname
const portno = 1234

http.createServer((req, res) => {
    const url = req.url;
        if (url == "/Welcome") {
            res.write("<h1>Hello world from NodeJs webserver</h1>")
            res.write("The requested url is: " + url)
            res.end()
        }
        else if (url == "/ClientApp") {
            const filename = root + "/ClientApp.html"
            fs.createReadStream(filename).pipe(res)
            return
        }
}).listen(portno)

console.log(`Server is available at ${portno}`)