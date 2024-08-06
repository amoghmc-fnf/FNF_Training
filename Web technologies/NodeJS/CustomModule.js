module.exports.simpleFunction = function() {
    console.log("Simple function is created");
}

module.exports.mathTable = function(num = 5) {
    console.log(`Multiplication table for ${num}`)
    for (let i = 1; i <= 10; i++)
        console.log(`${num} X ${i} = ${num * i}`)
}

module.exports.book = class {
    constructor(id, title, price) {
        this.id = id,
        this.title = title,
        this.price = price
    }
}