# MathOperationApp

A beginner-friendly C# console application that demonstrates **void methods** and **named parameters** in object-oriented programming.

---

## 📋 Description

This project shows how to define and call a void method in C#, and highlights the difference between positional and named parameter syntax. It is intended as a learning exercise for those getting started with C# and .NET.

---

## 🚀 Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later recommended)
- A C# compatible IDE such as [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### Running the App

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/MathOperationApp.git
   cd MathOperationApp
   ```

2. Build and run the project:
   ```bash
   dotnet run
   ```

---

## 📂 Project Structure

```
MathOperationApp/
├── Program.cs       # Entry point and MathOperations class
└── README.md
```

---

## 💻 Code Overview

### `MathOperations` Class

Contains the `DoMath` method, which accepts two integers:

| Parameter | Type  | Description                          |
|-----------|-------|--------------------------------------|
| `num1`    | `int` | Gets multiplied by 2 and displayed   |
| `num2`    | `int` | Gets displayed as-is                 |

### `Program` Class

Instantiates `MathOperations` and calls `DoMath` twice — once using **positional parameters** and once using **named parameters**.

---

## 📤 Expected Output

```
Result of math operation on first number: 10
Second number is: 10

Result of math operation on first number: 14
Second number is: 20
```

---

## 🧠 Concepts Covered

- **Void methods** — methods that perform actions without returning a value
- **Positional parameters** — arguments passed in order: `DoMath(5, 10)`
- **Named parameters** — arguments passed by name: `DoMath(num1: 7, num2: 20)`
- **Class instantiation** — creating an object from a class using `new`

---

## 📝 License

This project is open source and available under the [MIT License](LICENSE).
