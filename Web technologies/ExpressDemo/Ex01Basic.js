const express = require('express')
const app = express();
const portno = 2222

app.get("/", (req, res) => res.write("Home Page"));
app.get("/Employees", (req, res) => res.send("Employees Page"));
app.get("/Customers", (req, res) => res.send("Customers Page"));
app.get("/Orders", (req, res) => res.send("Orders Page"));
app.get("/AboutUs", (req, res) => res.send("AboutUs Page"));
app.get("/Registration", (req, res) => {
    res.sendFile(__dirname + "/RegistrationPage.html")
})

app.listen(portno, () => {
    console.log("Server is running at " + portno)
})