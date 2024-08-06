const fs = require("fs")

const filename = "./Ex03ShoppingCart.js"
// fs.readFile(filename, "utf-8", (err, data) => {
//     if (err) {
//         console.log(err.message)
//     }
//     else {
//         console.log(data)
//     }
// })
// console.log("File reading is going on")

// console.log(fs.readFileSync(filename, "utf-8"))
// console.log("file read synchronously")

const obj = {"id": 1, "name": "Milk", "price": 25}
const data = `${JSON.stringify(obj)}`
fs.appendFileSync("SampleData.json", data, 'utf-8')

