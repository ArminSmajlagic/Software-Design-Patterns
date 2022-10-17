# Abstract Factory Design Pattern

### Definition

Goal of abstract factory is to provide an interface for creating families of related or dependent objects without specifying their concrete classes.
Abstract Factory pattern is almost similar to Factory Pattern is considered as another layer of abstraction over factory pattern. 
Abstract Factory patterns work around a super-factory which creates other factories.
Abstract factory pattern implementation provides us with a framework that allows us to create objects that follow a general pattern. 
So at runtime, the abstract factory is coupled with any desired concrete factory which can create objects of the desired type.

### Examples

Graphical user interfaces are consited of families of simular components such as buttons, scrollbars, windows etc.
We can define an abstract component factory that decalares interface for creating each one of component families.
Clients can have as well an abstarct component representation to work with and call operations of abstract factory to obtain an instance of these components 
without being aware of there concrete implementation. Thus making clients independent of creation.

### Participants

- Abstract Factory 
  - declares an interface for operations that create abstract product objects
- Concrete Factory (we can have many of these and they should be implemented as singletons)
  - implements the operations to create concrete product objects
- Abstract Product
  - declares an interface for a type of product object
- Concrete Product
  - defines a product object to be created by the corresponding concrete factory
  - implements the abstract product interface
- Client
  - uses only interfaces declared by abstract factory and abstract product classes

### UML