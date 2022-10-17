C:\Users\pc\Desktop\DesignPatterns\Behavioral Design Patterns\Iterator

# Iterator Design Pattern (AKA. Cursor)

### Definition


Iterator pattern provides a way to access/traverse the elements of an aggregate object (collection) sequentially without exposing its underlying representation (such as list, stack, tree, etc). 
An aggregate object such as a list should give us a way to access its elements without exposing its internal structure.
The key idea in this pattern is to take the responsibility for access and traversal out of the aggregate object and put it into an iterator object.
The Iterator class should define an interface for accessing the list's elements and keep track of the current element (so it doesn't repeat itself).
The problem with specifying a data strucutre to the iterator to iterate is that it couples with that structure. What if we want to iterate over another strcuture.
We can do this by generalizing the iterator concept to support polymorphic iteration. 

Control of the iteration can be handeled externaly or internaly depending on who performes it.
External iterator is the one that controles the client, and the internal iterator controls itself.
Iterators that only hold the position of the current element are called cursors and the iteration algoritham performes the aggregate.

Iterator suportes these basic operations First, Next, IsDone, and CurrentItem.
But it can support operations such as Previous Element (moves iterator a step back), SkipTo (skips to specific place) which is useful in ordered structures.

### Use

- When we want to access an aggregate object's contents without exposing its internal representation
- When we want to support multiple traversals of aggregate objects
- When we want to provide a uniform interface for traversing different aggregate structures (to support polymorphic iteration)

### Participants

- Iterator
  - defines an interface for accessing and traversing elements
- Concrete Iterator
  - implements the Iterator interface
  - keeps track of the current position in the traversal of the aggregate
- Aggregate
  - defines an interface for creating an Iterator object
- Concrete Aggregate
  - implements the Iterator creation interface to return an instance of the proper Concrete Iterator

### UML