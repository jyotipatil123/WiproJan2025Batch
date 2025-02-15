const map = new Map<string, number>(); 
map.set('apple', 3);
map.set('banana', 5);


const appleCount = map.get('apple'); // Output: 3
console.log(appleCount);

const hasBanana = map.has('banana'); 
console.log(hasBanana);

// for each loop in typescript 
let numbers: number[] = [1, 2, 3, 4, 5];

numbers.forEach((number) => {
    console.log(number);
});

//foreach loop using map
map.forEach((value, key) => {
    console.log(`${key} = ${value}`);
});
