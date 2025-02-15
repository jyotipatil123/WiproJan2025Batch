var Employee = /** @class */ (function () {
    function Employee(name, age) {
        this.name = name;
        this.age = age;
    }
    Employee.prototype.greet = function () {
        console.log("Hello, my name is ".concat(this.name));
    };
    return Employee;
}());
var employee = new Employee("Alice", 30);
employee.greet(); // Output: Hello, my name is Alice
