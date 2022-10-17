# Singleton Design Pattern

### Definition

The singleton pattern is one of the simplest design patterns. 
It is a design pattern that restricts the instantiation of a class to one object. 
Sometimes we need to have only one instance of our class for example a single DB connection shared by multiple objects as creating a separate DB connection for every object may be costly.
Similarly, there can be a single configuration manager or error manager in an application that handles all problems instead of creating multiple managers.

### Use

- when there must be exactly one instance of a class, and it must be accessible to clients from a well-known access point
- when the sole instance should be extensible by subclassing, and clients should be able to use an extended instance without modifying their code

### Participants

- Singleton
  - defines an Instance operation that lets clients access its unique instance
  - may be responsible for creating its own unique instance (but not neccessarily)

