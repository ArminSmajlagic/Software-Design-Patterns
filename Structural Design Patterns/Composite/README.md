# Composite Design Pattern

### Definition

Composite patterns composes objects into tree structures to work with these structures as if they were individual objects.
Composite lets clients treat individual objects and compositions of objects uniformly. 
It is a partitioning design pattern and describes a group of objects as a single instance of the same type of object.
It allows you to have a tree structure and ask each node in the tree structure to perform a task/method over the whole tree structure.
We achive this by using interface that allows treating complex and primitive objects uniformly.

### Use

- When we want to represent part-whole hierarchies of objects

- When we want clients to be able to ignore the difference between compositions of objects and individual objects (Clients will treat all objects in the composite structure uniformly)

### Participants

– Component
  - declares the interface for objects in the composition
  - implements default behavior for the interface common to all classes (optional)
  - declares an interface for accessing and managing its child components
  - defines an interface for accessing a component's parent in the recursive structure, and implements it (optional)
- Leaf
  - represents leaf objects in the composition (leaf has no children)
  - defines behavior for primitive objects in the composition
- Composite
  - defines behavior for components having children
  - stores child components
  - implements child-related operations in the Component interface
- Client
  - manipulates objects in the composition through the Component interface

### UML