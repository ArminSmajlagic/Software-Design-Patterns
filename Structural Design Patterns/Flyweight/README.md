C:\Users\pc\Desktop\DesignPatterns\Structural Design Patterns\Flyweight

# Flyweight Design Flyweight

### Definition

Flyweight pattern is one of the structural design patterns that provides a ways to decrease number of object and with that improving application's structural complexity.
It helps us use sharing to support larger numbers of somewhat simular objects efficiently.
Important to mention is that flyweight objects are immutable (they cannot be modified once they have been constructed).

A flyweight is a shared object that can be used in multiple contexts simultaneously.

The flyweight acts as an independent object in each context—it's indistinguishable from an instance of the object that's not shared. 
Flyweights cannot make assumptions about the context in which they operate. 
The key concept here is the distinction between intrinsic and extrinsic state.  
Intrinsic state is stored in the flyweight; it consists of information that's independent of the flyweight's context, thereby making it sharable. 
Extrinsic state depends on and varies with the flyweight's context and therefore can't be shared. 
Client objects are responsible for passing extrinsic state to the flyweight when it needs it.

### Use

- When an application uses a large number of objects
- When storage costs are high because of the sheer quantity of objects
- When most object state can be made extrinsic
- When many groups of objects may be replaced by relatively few shared objects once extrinsic state is removed
- When the application doesn't depend on object identity

### Participants

- Flyweight
  - declares an interface through which flyweights can receive and act on extrinsic state
- Concrete Flyweight
  - implements the Flyweight interface and adds storage for intrinsic state
  - ConcreteFlyweight object must be sharable
  - Any state it stores must be intrinsic; that is, it must be independent of the ConcreteFlyweight object's context. 
- Unshared Concrete Flyweight
  - not all Flyweight subclasses need to be shared (Flyweight interface enables sharing; it doesn't enforce it)
- Flyweight Factory
  - creates and manages flyweight objects
  - ensures that flyweights are shared properly
  -  FlyweightFactory object supplies an existing instance or creates one, if none exists
- Client
  - maintains a reference to flyweight(s)
  - computes or stores the extrinsic state of flyweight(s)

### UML