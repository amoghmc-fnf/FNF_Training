let v1 = parseFloat(prompt("first value"))
if (isNaN(v1)) {
    alert("this is not a valid number, so taking 0");
    v1 = 0;
}
let v2 = parseFloat(prompt("second value"))
if (isNaN(v2)) {
    alert("this is not a valid number, so taking 0");
    v2 = 0;
}
let op = prompt("enter choice : +, -, /, *")
switch(op) {
    case "+": alert("The result of add is " + (v1 + v2));
    break;
    case "-": alert("The result of sub is " + (v1 - v2));
    break;
    case "*": alert("The result of mult is " + (v1 * v2));
    break;
    case "/": alert("The result of div is " + (v1 / v2));
    break;
}