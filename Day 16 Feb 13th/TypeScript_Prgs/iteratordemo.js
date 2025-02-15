function makeRangeIterator(start, end, step) {
    if (start === void 0) { start = 0; }
    if (end === void 0) { end = Infinity; }
    if (step === void 0) { step = 1; }
    var nextIndex = start;
    var iterationCount = 0;
    var rangeIterator = {
        next: function () {
            var result;
            if (nextIndex < end) {
                result = { value: nextIndex, done: false };
                nextIndex += step;
                iterationCount++;
                return result;
            }
            return { value: iterationCount, done: true };
        }
    };
    return rangeIterator;
}
var it = makeRangeIterator(1, 10, 2);
var result = it.next();
while (!result.done) {
    console.log(result.value); // 1 3 5 7 9
    result = it.next();
}
console.log("Iterated over sequence of size: ", result.value);
