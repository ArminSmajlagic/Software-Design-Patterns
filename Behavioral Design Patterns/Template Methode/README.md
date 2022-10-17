C:\Users\pc\Desktop\DesignPatterns\Behavioral Design Patterns\Template Method

# Template Method Design Pattern

### Definition

Template Method defines the base of an algorithm in an operation alowing for redefinition some steps to subclasses.
Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.

This is achived by using template method that defines the order of the algoritham (method contains only function calls and if neccessary conditions and loops).
This can be an abstract class containing the template method and definitions of steps (smaller functions) while concrete classes can override that behaviour and change the algoritham steps.

### Use

- When we want to implement the invariant parts of an algorithm once and leave it upto subclasses to implement the behavior that can vary
- when common behavior among subclasses should be factored and localized in a common class to avoid code duplication
- When we want to control subclasses extensions

### Participants

- AbstractClass
  - defines abstract primitive operations that concretesub classes define to implement steps of an algorithm
  - implements a template method defining the skeleton of an algorithm
- ConcreteClass
  - implements the primitive operations to carry out subclass-specificsteps of the algorithm

### UML