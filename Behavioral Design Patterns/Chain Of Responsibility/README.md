C:\Users\pc\Desktop\DesignPatterns\Behavioral Design Patterns\Chain Of Responsibility

# Chain Of Responsibility Design Pattern

### Definition

Chain of Responsibility is a behavioral design pattern that lets you pass requests along a chain of handlers. 
Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.
With this we avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. 
We chain the receiving objects and pass the request along the chain until an object handles it.

This pattern reduces coupling by freeing the object from knowing which other object handles arequest. 
An object only has to know that a request will be handled appropriately. 
This is achived by setting single reference of successor to each object, so that the object doesnt know the whole chain structure.

This pattern also allows flexibility in assigning responsibilities to objects.
Which is useful for distributin resposnibility over the chain of objects.

But there is no guarantee that the request is going to be handeled since there is no explicit receiver. (Proper configuration can fix this) 

### Use

- When more than one object is able to handle a request, and the handler isn't known prior to the event that sent request
- When you want to issue a request to one of several objects without specifying the receiver explicitly
- When the set of objects that can handle a request should be specified dynamically

### Participants

- Handler
  - defines an interface for handling requests
  - optionaly can implement next successor in the chain
- Concrete Handler
  - handles requests it is responsible for
  - can access its successor
  - if the Concrete Handler can handle the request, it does so; otherwise it forwards the request to its successor
- Client
  - initiates the request to a Concrete Handler object on the chain

### UML