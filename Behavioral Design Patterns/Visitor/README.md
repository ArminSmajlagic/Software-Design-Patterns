# Visitor Design Pattern

### Definition

Visitor pattern represents an operation to be performed on the elements of an object structure.
Visitor lets us define a new operation without changing the classes of the elements on which it operates (basicaly it lets us separate algorithms from the objects on which they operate).

The Visitor pattern suggests that we place the new behavior into a separate class called visitor, instead of trying to integrate it into existing classes. 
The original object that had to perform the behavior is now passed to one of the visitor’s methods as an argument, providing the method access to all necessary data contained within the object.

### Use

- When an object structure contains many classes of objects with different interfaces, and you want to perform operations on these objects that depend on their concrete classes
- when many distinct and unrelated operations need to be performed on objects in an object structure, and we want to avoid "polluting" their classes with these operations
- when the classes defining the object structure rarely changes, but we often want to define new operations over the structure

### Participants

- Visitor
  - declares a Visit operation for each class of Concrete Element in the object structure (operation's name and signature identifies the class that sends the Visit request to the visitor)
- ConcreteVisitor
  - implements each operation declared by Visitor (Each operation implements a fragment of the algorithm defined for the corresponding class of object in the structure)
  - provides the context for the algorithm and stores its local state (state often accumulates results during the traversal of the structure)
- Element
  - defines an Accept operation that takes a visitor as an argument
- ConcreteElement
  - implements an Accept operation that takes a visitor as an argument
- ObjectStructure
  - can enumerate its elements
  - may provide a high-level interface to allow the visitor to visit its elements
  - may either be a composite (using Composit pattern) or a collection such as a list or a set

### UML