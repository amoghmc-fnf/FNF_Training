const external = require("./CustomModule")
console.log(external)
console.log(external.simpleFunction())
console.log(external.mathTable(64))

const mybook = new external.book(1, "Dune", "Frank Herbert")
console.log(mybook)