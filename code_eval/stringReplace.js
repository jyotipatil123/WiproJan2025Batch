// stringReplace.js
function stringReplace(originalString, searchString, replacement) {
    return originalString.replace(new RegExp(searchString, 'g'), replacement);
}

module.exports = stringReplace;