var map = new Map();
map.set('apple', 3);
map.set('banana', 5);
var appleCount = map.get('apple'); // Output: 3
console.log(appleCount);
var hasBanana = map.has('banana');
console.log(hasBanana);
// for each loop in typescript 
var numbers = [1, 2, 3, 4, 5];
numbers.forEach(function (number) {
    console.log(number);
});
map.forEach(function (value, key) {
    console.log("".concat(key, " = ").concat(value));
});
