const fs = require('fs');

fs.readFile('testdata.txt', 'utf8', (err, data) => {
  if (err) throw err;
  console.log(data);
});


fs.writeFile('testdata.txt', 'Hello, World!', (err) => {
  if (err) throw err;
  console.log('File has been saved!');
});

fs.appendFile('testdata.txt', ' Appended content.', (err) => {
    if (err) throw err;
    console.log('Content appended!');
  });
  