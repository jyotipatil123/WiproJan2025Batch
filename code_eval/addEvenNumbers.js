// addEvenNumbers.js
function addEvenNumbers(numbers) {
    return numbers.reduce((sum, num) => num % 2 === 0 ? sum + num : sum, 0);
}

module.exports = addEvenNumbers;