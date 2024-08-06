const express = require("express")
const app = express()
const portno = 2222
const root = __dirname

app.use(express.urlencoded({extended: false}))
app.use(isAuthenticated)
function isAuthenticated(req, res, next) {
    console.log("The request is authenticated")
    next();
}


app.get("/register", (req, res) => {
    res.sendFile(root + "/RegistrationPage.html")
})

app.get("/processRegister", (req, res) => {
    const content = req.query
    res.send(content)
})

app.post("/postRegister", (req, res) => {
    const {username, useremail} = req.body
    const msg = `<h1>Username: ${username} with Email: ${useremail} has been registered!</h1>`
    res.send(msg)
})





// this must be the last piece of code as once it starts listening u cant change the code!
app.listen(portno, () => {
    console.log("server available at port: " + portno)
})