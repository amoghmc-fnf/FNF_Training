const external = require("./CartIIFE")

external.addItem({"id": 1, "name": "Milk", "price": 25})
external.addItem({"id": 2, "name": "Chicken", "price": 155})
external.addItem({"id": 3, "name": "Fish", "price": 500})
external.addItem({"id": 4, "name": "Eggs", "price": 30})

console.log(external.getAll())

console.log(external.removeItem({"id": 1}))
console.log(external.findItem(3))

console.log(external.getAll())

