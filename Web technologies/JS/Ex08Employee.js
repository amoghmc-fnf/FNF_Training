class Employee {
    constructor(id, name, address, salary) {
        this.id = id
        this.name = name
        this.address = address
        this.salary = salary;
    }
    display = () => `${this.name} is from ${this.address} and has raised the bill amount of Rs.${this.salary}`
}