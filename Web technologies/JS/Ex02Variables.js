const msg = "welcome to js"
console.log(msg)

let res = 13 + 14
console.log(res)

// let vs var
///////////////////////////////////////////////////
let example = "sample test"
console.log(example)
{
    let example = "some more tests"
    console.log(example)
}
console.log(example)

var example2 = "sample test"
console.log(example2)
{
    var example2 = "some more tests"
    console.log(example2)
}
console.log(example2)
////////////////////////////////////////////////////

let value = 123
console.log(typeof(value))
value = 12.324
console.log(typeof(value))
value = "hello"
console.log(typeof(value))
value = null
console.log(value)
value = true
console.log(typeof(value))
value = ["apples", "mangoes", "oranges"]
console.log(typeof(value))
value = {name: "amogh", address: "bangalore"}
console.log(typeof(value))
let undefined_identifier
console.log(undefined_identifier)