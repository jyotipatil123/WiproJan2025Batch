class Person1 {
    name: string;
    age: number;
  
    constructor(name: string, age: number) {
      this.name = name;
      this.age = age;
    }
    greet() {
        console.log(`Hello, my name is ${this.name} and I am ${this.age} years old.`);
      }    
}


class Employee extends Person1 {
    position: string;
  
    constructor(name: string, age: number, position: string) {
      super(name, age);
      this.position = position;
    }
  
    work() {
      console.log(`${this.name} is working as a ${this.position}.`);
    }
  }
  
  const employee1 = new Employee('Bob', 25, 'Developer');
  employee1.greet(); // Output: Hello, my name is Bob and I am 25 years old.
  employee1.work();
  