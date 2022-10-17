# Prototype Design Pattern

### Definition

Prototype copys an existing object insted of creating a new instance from scratch which may save time and other resources if creation is a heavy process.
The existing object acts as a prototype with all has properities and values that those properities hold.
Only if required the copied object can overwrite the existing values of the prototype.
One of the best available ways to create an object from existing objects is the clone() method. 
Clone is the simplest approach to implement a prototype pattern, but it is not the only way.

### Use

- when the classes to instantiate are specified at run-time, for example,by dynamic loading
- when instances of a class can have one of only a few different combinations of state
- when proces of creation is expensive and objects are very simular (mentioned above)

### Participants

- Abstarct Prototype
  - declares an interface for cloning itself
- Concrete Prototype
  - implements an operation for cloning itself
- Client
  - creates a new object by asking a prototype to clone itself

### UML

![UML](https://user-images.githubusercontent.com/45321513/196160752-e9a57880-c659-48da-809b-c750d1cf71c6.jpeg)
