# Pizza Ordering System (C# Windows Forms)

A desktop-based Pizza Ordering System developed using C# and Windows Forms. The application provides an interactive graphical interface that allows users to customize their pizza orders by selecting different sizes, crust types, toppings, and dining preferences.

The system automatically calculates the total order price and displays an order summary before confirming the order.

## Features

### 1. Pizza Size Selection
- Small
- Medium
- Large
- Automatic price updates based on the selected size.

### 2. Crust Selection
- Thin Crust
- Thick Crust
- Automatic price calculation based on crust selection.

### 3. Toppings Customization

Users can select multiple toppings:
- Extra Cheese
- Onion
- Mushrooms
- Olives
- Tomatoes
- Green Peppers

The application calculates the additional topping costs automatically.

### 4. Dining Preferences
- Eat In
- Take Out

### 5. Order Summary
- Selected pizza size.
- Selected crust type.
- Selected toppings.
- Dining preference.
- Automatically calculated total price.

### 6. Order Management
- Order confirmation through a dialog box.
- Order placement confirmation message.
- Disable order configuration after successful confirmation.
- Reset functionality to start a new order.

## Technologies Used

- **Programming Language:** C#
- **Framework:** .NET Framework 4.8
- **GUI Framework:** Windows Forms (WinForms)
- **IDE:** Microsoft Visual Studio
- **Concepts:** Event-Driven Programming, Event Handlers, Conditional Statements, Methods, and Windows Forms Controls.

## Project Structure

```text
pizza-ordering-system-csharp/
│
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
├── Program.cs
├── App.config
├── Pizza Project.csproj
├── Pizza Project.slnx
│
├── Properties/
│   ├── AssemblyInfo.cs
│   ├── Resources.resx
│   ├── Resources.Designer.cs
│   ├── Settings.settings
│   └── Settings.Designer.cs
│
└── README.md
```

## How to Run

### Prerequisites
- Windows operating system.
- Microsoft Visual Studio.
- .NET Framework 4.8 Developer Pack.

### Steps

1. Clone the repository:

```bash
git clone https://github.com/Muha7/pizza-ordering-system-csharp.git
```

2. Open the project solution in Visual Studio using `Pizza Project.slnx`, or open `Pizza Project.csproj` directly.

3. Allow Visual Studio to load the project and its dependencies.

4. Build the solution using **Build → Build Solution**.

5. Run the application by pressing **F5** or clicking Start.

## Project Purpose

This project was developed to practice C# programming and Windows Forms application development, focusing on graphical user interfaces, event-driven programming, user interaction, conditional logic, and dynamic price calculation.

## Notes

This is an educational desktop application demonstrating a basic pizza ordering workflow. It does not connect to a real restaurant ordering or payment system.

## Author

**Muha7**

GitHub: [@Muha7](https://github.com/Muha7)
