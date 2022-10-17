# Mediator Design Pattern

### Definition

Mediator Pattern defines an object that encapsulates how a set of objects interact.
Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently. 
It restricts direct communications between the objects and forces them to collaborate only via a mediator object.
With this it reduces chaotic dependencies between objects. 

Need for this pattern has emerged with object-oriented design that encourages the distribution of behavior among objects. 
Such distribution can result in an object structure with many connections between objects.
In the worst case, every object ends up knowing about every other in a system.

A mediator is responsible for controlling and coordinating the interactions of a group of objects.
The mediator serves as an intermediary that keeps objects in the group from referring to each other explicitly.
The objects only know the mediator, thereby reducing the number of interconnections.

### Use

- When a set of objects communicate in well-defined but complex ways. The resulting interdependencies are unstructured and difficult to understand. 
- When reusing an object is difficult because it refers to and communicates with many other objects
- When a behavior that's distributed between several classes should be customizable without a lot of subclassing

### Participants

- Mediator
  - defines an interface for communicating with Colleague objects
- Concrete Mediator
  - implements cooperative behavior by coordinating Colleague objects
  - knows and maintains its colleagues
- Colleague classes
  - each Colleague class knows its Mediator object
  - each colleague communicates with its mediator whenever it would have otherwise communicated with another colleague

### UML