class Customer {
    constructor(id, name, address) {
        this.CustomerId = id
        this.CustomerName = name
        this.CustomerAddress = address
    }
}
class CustomerRepo {

    constructor() {
        this.customerList = []
        this.customerList.push(new Customer(11, "Phaniraj", "Bangalore"))
        this.customerList.push(new Customer(12, "Vinod", "Mysore"))
        this.customerList.push(new Customer(13, "Shyam", "Belgaum"))
        this.customerList.push(new Customer(14, "Abraham", "Kochi"))
    }

    getAllCustomers = () => this.customerList

    addCustomer(cst) {
        this.customerList.push(cst)
    } 

    findCustomer(id) {
        return this.customerList.find((c) => c.CustomerId == id)
    }

    findAllCustomers = (name) => this.customerList.filter(c => c.CustomerName.incldes(name))

    updateCustomer(cst) {
        for (const item of this.customerList) {
            if (item.CustomerId == cst.CustomerId) {
                item.CustomerName = cst.CustomerName
                item.CustomerAddress = cst.CustomerAddress
                return true
            }
        }
        return false
    }

    deleteCustomer(id) {
        let index = 0
        for (const item of this.customerList) {
            if (item.CustomerId == id)
                break;
            index++;
        }
        this.customerList.splice(index, 1);
    }
}

const cstrepo = new CustomerRepo()
cstrepo.addCustomer(new Customer(1, "1abc", "ban"))
cstrepo.addCustomer(new Customer(2, "2abc", "ban"))
cstrepo.addCustomer(new Customer(3, "3abc", "ban"))
cstrepo.addCustomer(new Customer(1, "4abc", "ban"))
cstrepo.addCustomer(new Customer(5, "5abc", "ban"))