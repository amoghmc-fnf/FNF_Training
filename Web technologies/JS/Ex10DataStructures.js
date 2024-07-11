// set example
console.log(setExample())

function setExample() {
    let set = new Set()
    set.add("Item1")
    if (set.has("Item1"))
        console.log("Item already exists")
    else
        set.add("Item1")
    return set;
    
}

console.log(setExample())

// map example
const items = new Map()
items.set("apple", 200)
items.set("strawberry", 600)
items.set("grapes", 100)
items.set("guavas", 250)
items.set("oranges", 300)

for (const item of items) {
    console.log(item)
}


