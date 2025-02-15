interface Person2 {
    name: string;
    age: number;
    greet: () => void;
  }
  
  class Employee implements Person2 {
    name: string;
    age: number;
  
    constructor(name: string, age: number) {
      this.name = name;
      this.age = age;
    }
  
    greet() {
      console.log(`Hello, my name is ${this.name}`);
    }
  }
  
  const employee = new Employee("Alice", 30);
  employee.greet(); // Output: Hello, my name is Alice
  