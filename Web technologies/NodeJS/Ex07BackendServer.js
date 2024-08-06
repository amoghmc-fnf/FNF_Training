const http = require("http")
const fs = require("fs")
const parse = require("url").parse;
const empList = []

const portno = 1235
const root = __dirname;
const data = require("./MyData.json");
const { json } = require("stream/consumers");

function errorPage(res)
{
    const file = root + "/ErrorPage.html"
    fs.createReadStream(file).pipe(res)
}

function processGet(req, res) {
    let query = parse(req.url, true).query;
    var rec = {"name" : query.username, "email" : query.useremail};
    empList.push(rec);
    const msg =`<p>Thank you for registering with us!!</p><p>Mr.${query.username}'s email Address is ${query.useremail} </p>`
    res.write(msg);
    res.end();
}

http.createServer((req, res) => {
    console.log(req.method);
    if (req.method == "GET") {
        const query = parse(req.url).query;
        if (query != null) {
            processGet(req, res);
            return;
        }
    }

    switch (req.url)
    {
        case "/empdata":
            res.write(JSON.stringify(data))
            break;
        case "/register":
            fs.createReadStream(root + "/RegistrationPage.html").pipe(res)
            return;
        default:
            errorPage(res)
            return
    }
    res.end()
}).listen(portno)

console.log("Server is available at port no " + portno)