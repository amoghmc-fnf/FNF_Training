class Employee {
    constructor(id, name, address, salary) {
        this.id = id
        this.name = name
        this.address = address
        this.salary = salary;
    }
    display = () => `${this.name} is from ${this.address} and has raised the bill amount of Rs.${this.salary}`
}

class EmployeeRepo {
    data = [new Employee(1, "phaniraj", "bangalore", 56000),
        new Employee(2, "ram", "mysore", 50000),
        new Employee(3, "vinod", "bangalore", 76000),
        new Employee(4, "shyam", "hyderabad", 45000),
    ];

    addNewEmployee = (emp) => [...this.data, emp]

    deleteEmployee = (id) => {
        let index = this.data.findIndex((e) => e.empId == id);
        this.data.splice(index, 1)
    }

    getAllEmployees = () => this.data

    updateEmployee = (id, emp) => {
        let index = this.data.findIndex((e) => e.empId == id)
        this.data.splice(index, 1, emp)
    }
}

const hide = (...elements) => [...elements].forEach(e => (e.style.display = 'none'))

const show = (id) => document.getElementById(id).style.display = 'block'
