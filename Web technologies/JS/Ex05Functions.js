function addFunc(v1, v2) {
    return v1 + v2
}

const subFunc = function(v1, v2) {
    return v1 - v2
}

const v1 = parseFloat(prompt("Enter the first value"))
const v2 = parseFloat(prompt("Enter the second value"))
let result = addFunc(v1, v2)
console.log(result)
result = subFunc(v1, v2)
console.log(result)
