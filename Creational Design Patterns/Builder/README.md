# Builder Design Pattern

### Definition

Builder is a creational design pattern that lets you construct complex objects step by step. 
Builder pattern separates the construction of a complex object from its representation so that the same construction process can create different representations.
It is used to construct a complex object step by step and the final step will return the object. 
The process of constructing an object should be generic so that it can be used to create different representations of the same object.

### Usages

Parser class of compiler is a director which takes program node builder as argument for its constructor.
When the parser is done, it asks the builder for the parse tree it built and returns it to the client.

ByteCodeStream is a builder that creates a compiled method as a byte array (the complex object it builds is encoded as a byte array).

### Participants

- Builder
  - specifies an abstract interface for creating parts of a Product object
- Concrete Builder
  - constructs and assembles parts of the product by implementing the Builder interface
  - provides an interface for retrieving the product
- Director
  - onstructs an object using the Builder interface
- Product
  - represents the complex object that is being construction
  - includes classes that define the constituent parts, including interfaces for assembling the parts into the final result

### Implementation

Step 1 : Client creates an instance of concrete builder
Step 2 : Client creates an instance of director (durector takes builder as arguemnt for constructor)
Step 3 : Client calls the construct method of builder to start the proces of creation
Step 4 : Drictor tels concrete builder to start the proces of object creation
Step 5 : Concrete builder creates the object part by part and holds it
Step 6 : Client calls get result method of concrete builder to give him the final product

### UML

![uml](https://user-images.githubusercontent.com/45321513/196160517-65692f2d-797a-4698-a0d7-387fda8f6d10.jpeg)
