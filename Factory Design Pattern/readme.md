# Factory Design Pattern - SOLID Principles Adherence

This repository implements the **Factory Design Pattern** using a coffee shop analogy, where different types of coffee (`Robusta`, `Cappuccino`, `Espresso`) are created and served using an abstraction (`ICoffee` interface). The code demonstrates how the Factory Design Pattern adheres to the **SOLID** design principles.

## Project Structure

- **ICoffee**: Interface that defines common behaviors for different coffee types (methods: `milk()`, `sugar()`).
- **Concrete Coffee Classes**: `Robusta`, `Cappuccino`, and `Espresso` implement the `ICoffee` interface.
- **CoffeeFactory**: Creates coffee objects based on the provided coffee type.
- **CoffeeServer**: Serves coffee by utilizing the factory to create the correct coffee type.

## SOLID Principles

### 1. Single Responsibility Principle (SRP)

**Definition**: A class should have only one reason to change.

- **Factory** (`CoffeeFactory`): Its only responsibility is to create instances of coffee based on the type.
- **Server** (`CoffeeServer`): Its only responsibility is to serve coffee, using the factory for object creation.
- This clear separation of concerns ensures that changes in coffee preparation logic or types of coffee do not affect the `CoffeeServer`.

### 2. Open/Closed Principle (OCP)

**Definition**: Classes should be open for extension but closed for modification.

- **Factory Design Pattern** allows new coffee types (e.g., `Latte`, `Mocha`) to be added by extending the `ICoffee` interface and creating new classes.
- The existing logic of the factory remains unchanged when adding new types, adhering to the "closed for modification" rule.
  
### 3. Liskov Substitution Principle (LSP)

**Definition**: Subtypes must be substitutable for their base types without altering the correctness of the program.

- All coffee types (`Robusta`, `Cappuccino`, `Espresso`) implement the `ICoffee` interface, which ensures they can be used interchangeably in the `CoffeeServer`.
- The behavior remains consistent regardless of the coffee type, ensuring that substituting any subtype doesn’t break the functionality.

### 4. Interface Segregation Principle (ISP)

**Definition**: Clients should not be forced to depend on methods they do not use.

- The `ICoffee` interface is minimal, with only two methods: `milk()` and `sugar()`. These methods are essential for any coffee type, ensuring no class implements unnecessary methods.
- As more specific behaviors are needed in the future, more focused interfaces can be introduced, following the ISP.

### 5. Dependency Inversion Principle (DIP)

**Definition**: High-level modules should not depend on low-level modules. Both should depend on abstractions.

- The `CoffeeServer` does not depend on the specific coffee implementations (`Robusta`, `Cappuccino`, `Espresso`). Instead, it depends on the `ICoffee` abstraction.
- The factory (`CoffeeFactory`) handles the creation of concrete classes, ensuring the `CoffeeServer` remains decoupled from specific implementations, which follows the DIP.

## How to Run the Program

1. Clone the repository.
2. Ensure you have a C# environment set up (e.g., Visual Studio).
3. Create an instance of the `CoffeeServer` and serve coffee by passing the desired coffee type:
   ```csharp
   CoffeeFactory factory = new CoffeeFactory();
   CoffeeServer server = new CoffeeServer(factory);
   ICoffee coffee = server.serveCoffee(CoffeeType.Robusta);
