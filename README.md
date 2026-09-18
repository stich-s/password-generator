# password-generator
#  C# Password Generator

A simple password generator built using **C# and .NET 10.0**.

The application runs in the console and allows the user to choose how long they want their password to be. It then randomly selects characters from a predefined set of uppercase letters, lowercase letters, numbers, and special characters.

##  Features

- User-defined password length
- Uppercase letters (A-Z)
- Lowercase letters (a-z)
- Numbers (0-9)
- Special characters (!@#$%^&*)
- Random character selection
- Simple console-based interface

##  Technologies

- **C#**
- **.NET 10.0**
- **Visual Studio**
- Console Application

##  How It Works

1. The program creates a list of characters that can be used.
2. The user enters their desired password length.
3. A `Random` object is created to generate random positions.
4. A `for` loop runs until the requested password length is reached.
5. A random character is selected and added to the password.
6. The completed password is displayed in the console.

 ## Example

```text
How long should the password be? 12

-------------------------
    PASSWORD GENERATOR
-------------------------

Your password is:
G7@kP2!xQ9#L

Press any key to exit...

