# Factory Desgin Pattern (Virtual Constructor)

### Definition

In the Factory pattern, we create objects without exposing the creation logic to the client and the client uses the same common interface to create a new type of object. 
Factory Desgin Pattern defines an interface for creating an object, but it lets subclasses to decide which class to instantiate.
With this we change the place of object creation and we solve the problem of tight coupling with the class hierarchy.	

### Use

- when class can't anticipate the class of objects it must create
- when class wants its subclasses to specify the objects it creates
- when classes delegate responsibility to one of several helper subclasses, and you want to localize the knowledge of which helper subclass is the delegate

### Participant

- Abstract Product
  - defines the interface of objects the factory method creates
- Concrete Product
  - implements the Abstract Product interface
- Abstract Factory
  - declares the factory method, which returns an object of type Product (it can have default implementation)
  - may call the factory method to create a Product object
- Concrete Factory
  - overrides the factory method to return an instance of a Concrete Product

### UML