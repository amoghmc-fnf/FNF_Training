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
    data = [];
    constructor() {
        this.loadData()
    }

    loadData = () => {
        if (localStorage.getItem("empList") != null) {
            const json = localStorage.getItem("empList")
            this.data = JSON.parse(json)
        }
    }

    saveData = () => {
        const json = JSON.stringify(this.data)
        localStorage.setItem("empList", json)
    }

    addNewEmployee = (emp) => {
        this.loadData()
        this.data.push(emp)
        this.saveData()
    }

    deleteEmployee = (id) => {
        this.loadData()
        let index = this.data.findIndex((e) => e.empId == id);
        this.data.splice(index, 1)
        this.saveData()
    }

    getAllEmployees = () => {
        this.loadData()
        return this.data
    }

    updateEmployee = (id, emp) => {
        this.loadData()
        let index = this.data.findIndex((e) => e.empId == id)
        this.data.splice(index, 1, emp)
        this.saveData()
    }
}

const hide = (...elements) => [...elements].forEach(e => (e.style.display = 'none'))

const show = (id) => document.getElementById(id).style.display = 'block'
