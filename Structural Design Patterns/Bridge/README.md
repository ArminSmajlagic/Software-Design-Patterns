# Bridge Design Pattern (AKA. Handle/Body)

### Definition

Bridge decouples an abstraction from its implementation so that the two can vary independently. 
Abstraction can have several possible implementations, the usual way to accommodate them is to use inheritance. 
An abstract class defines the interface to the abstraction, and concrete subclasses implement it in different ways. 
But this approach isn't always flexible enough. 
Inheritance binds an implementation to the abstraction permanently, which makes it difficult to modify,
extend, and reuse abstractions and implementations independently. 

The Bridge pattern addresses these problems by putting the abstraction
and its implementation in separate class hierarchies.

### Use

- When we  want to avoid a permanent binding between an abstraction and its implementation (so the implementation can be swtched or selected)
- When both the abstractions and their implementations should be extensible by subclassing (combine different abstractions and implementations and extend them independently)
- When changes in the implementation of an abstraction should have no impact on clients
- When we want to share an implementation among multiple objects

### Participants

- Abstraction
  - defines the abstraction's interface
  - maintains a reference to an object of type Implementor
- RefinedAbstraction
  - Extends the interface defined by Abstraction
- Implementor
  - defines the interface for implementation classes
  - interface provides only primitive operations
- ConcreteImplementor
  - implements the Implementor interface and defines its concrete implementation

### UML

![UML](https://user-images.githubusercontent.com/45321513/196161006-c96817e8-4a52-48ec-a78d-111afae29b2e.jpeg)
