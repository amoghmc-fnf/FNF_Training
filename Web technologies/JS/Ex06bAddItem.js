let items = []

const addItem = (item) => {
    items.push(item)
}

const removeItem = (item) => {
    let index = items.indexOf(item);
    if (index < 0)
        throw "Item not found!"
    items.splice(index, 1)
}

const getAllItems = () => items