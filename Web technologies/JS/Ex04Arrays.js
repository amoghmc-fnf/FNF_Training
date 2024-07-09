const fruits = ["apples", "mangoes", "oranges", "bananas"]
console.log(fruits)

// using for loops
for (let i = 0; i < fruits.length; i++) {
    const element = fruits[i]
    console.log(element)
}

for (const fruit of fruits)
    console.log(fruit)

for (const key in fruits) {
    console.log(`Index: ${key}: Value:${fruits[key]}`)
}

fruits.splice(2, 2, "guava", "strawberry", "blueberry")

for (const element of fruits)
    console.log(element)