# Advanced Calculator

## Overview
The **Advanced Calculator** is a feature-rich console application developed in C# that supports various mathematical operations, including basic arithmetic, scientific calculations, and advanced functions such as trigonometry and logarithms.

## Features
- Basic arithmetic operations: Addition, Subtraction, Multiplication, Division
- Scientific functions: Sine, Cosine, Tangent
- Logarithmic and Exponential functions
- Power and Square root calculations
- History of past calculations
- User-friendly command-line interface

## Technologies Used
- C#
- .NET Framework / .NET Core (Specify version)

## Installation
### Prerequisites
- Install [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- Ensure you have a C# compiler set up on your system

### Steps to Run
1. Clone the repository:
   ```sh
   git clone https://github.com/your-username/advanced-calculator.git
   ```
2. Navigate to the project directory:
   ```sh
   cd advanced-calculator
   ```
3. Build and run the application:
   ```sh
   dotnet run
   ```

## Usage
- Launch the application and follow the on-screen instructions.
- Enter mathematical expressions based on available operations.
- Use the history feature to view previous calculations.

## Code Structure
```
AdvancedCalculator/
├── AdvancedCalculator.sln  # Solution file
├── AdvancedCalculator/
│   ├── App.xaml            # Application definition
│   ├── App.xaml.cs         # Application logic
│   ├── MainWindow.xaml     # Main window layout
│   ├── MainWindow.xaml.cs  # Main window code-behind
│   ├── Calculator.cs       # Core calculator logic
│   ├── Helpers/
│   │   └── MathHelper.cs   # Mathematical helper functions
│   └── Properties/
│       ├── AssemblyInfo.cs # Assembly information
│       └── Resources.resx  # Resource file
└── Tests/
    ├── AdvancedCalculator.Tests.csproj  # Test project file
    └── CalculatorTests.cs               # Unit tests for Calculator
```

## Contributing
Contributions are welcome! Follow these steps to contribute:
1. Fork the repository.
2. Create a new branch (`feature-new-function`).
3. Commit your changes (`git commit -m 'Add new function'`).
4. Push to the branch (`git push origin feature-new-function`).
5. Open a Pull Request.

## License
This project is licensed under the MIT License. See `LICENSE` for details.

## Contact
For any questions or suggestions, feel free to reach out via [your-email@example.com](mailto:your-email@example.com).

