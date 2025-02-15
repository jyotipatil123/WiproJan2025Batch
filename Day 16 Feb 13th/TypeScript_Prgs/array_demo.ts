let fruits: string[] = ["Apple", "Banana", "Cherry"];
fruits.push("Date");
console.log(fruits);                // Output: ["Apple", "Banana", "Cherry", "Date"]

let lengths = fruits.map(fruit => fruit.length);
console.log(lengths); // Output: [5, 6, 6, 4]
