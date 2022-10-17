# Fascade Design Pattern

### Definition

Fascade provides a unified interface to a set of interfaces in a subsystem. 
It defines a higher-level interface that makes the subsystem easier to use.
Usually facades manage the full life cycle of objects they use.
The facade pattern is appropriate when you have a complex system that clients want to use in a simplified way, or we want to make an external layer over an existing system which is incompatible with other system.
Facade deals with interfaces, not implementation.

Structuring a system into subsystems helps reduce complexity. 
A common design goal is to minimize the communication and dependencies between subsystems. 
One way to achieve this goal is to introduce a facade object that provides a single, simplified interface to the more general facilities of a subsystem. 


### Use

- When we want to provide a simple interface (fascade)to a complex subsystem (only clients needing more customizability will need to look beyond the facade)

- When there are many dependencies between clients and the implementation classes of an abstraction (use facade to decouple the subsystem from clients and other subsystems)

- When we want to layer our subsystems (Use a facade to define an entry point to each subsystem level)

- When subystems are dependent on each other (to make them communicate with each other solely through their facades)

### Participants

- Facade
  - knows which subsystem classes are responsible for a request
  - delegates client requests to appropriate subsystem objects
- Subsystem classes
  - implement subsystem functionality
  - handle work assigned by the Facade object
  - have no knowledge of the facade; that is, they keep no references to it

### UML


### Compiler Fascade Example