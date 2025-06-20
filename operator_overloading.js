class MyNumber {
    constructor(value) {
        this.value = value
    }

    valueOf() {
        return this.value
    }

    toString() {
        return `MyNumber(${this.value})`
    }
}

const a = new MyNumber(10);
const b = new MyNumber(20);

console.log(a + b)

console.log(String(b))

console.log(a * b)