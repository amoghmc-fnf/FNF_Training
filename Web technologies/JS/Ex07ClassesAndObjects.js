const emp = {
    empName: "Phaniraj",
    empAddress: "Bangalore",
    empSalary: 56000
}

const emp2 = emp;
emp2.empSalary = 76000

console.log(emp.empSalary)
console.log(emp2.empSalary)

for (const key in emp)
    console.log(`Property: ${key}, value: ${emp[key]}`);

const emp3 = { ...emp, empId: 12415 }
console.log(emp3)

///////////////Creating multiple objects////////////////////
const employee = function (id, name, address) {
    this.Id = id;
    this.name = name;
    this.address = address;

    this.display = function () {
        return `${this.name} is from ${this.address}`
    }
}

console.log(employee)

const employee1 = new employee(123, "phaniraj", "bangalore")
const employee2 = new employee(234, "vinod", "shimogga")
alert(employee2.display())
employee2.address = "bhadaravati"
console.log(employee1.address)
console.log(employee2.address)

///////////////////ES6 syntax of class//////////////////
class Customer {
    constructor(id, name, address, bill) {
        this.id = id
        this.name = name
        this.address = address
        this.bill = bill;
    }
    display = () => `${this.name} is from ${this.address} and has raised the bill amount of Rs.${this.bill}`
}

const cst = new Customer(123, "Suresh", "Bangalore", 5000)

alert(cst.display())
