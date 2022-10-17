# Memento Design Pattern (AKA. Token) 

### Definition

Memento pattern captures and externalizes an object's internal state so that the object can be restored to this state later.
Sometimes it's necessary to record the internal state of an object.
This is required when implementing checkpoints and undo mechanisms that let users back out of tentative operations or recover from errors.
A memento is an object that stores a snapshot of the internal state of another object — the memento's originator.
The undo mechanism will request a memento from the originator when it needs to checkpoint the originator'sstate. 
The originator initializes the memento with information that characterizes its current state. 
Only the originator can store and retrieve information from the memento.

Objects normally encapsulate some or all of their state, making it inaccessible to other objects and impossible to save externally. 
Exposing this state would violate encapsulation, which can compromise the application's reliability and extensibility.
That is why we have caretaker that is responsible for the memento's safekeeping.


### Use

- When a snapshot of (some portion of) an object's state must be saved so that it can be restored to that state later
- When a direct interface to obtaining the state would expose implementation details and break the object's encapsulation

### Participants

- Memento
  - stores internal state of the Originator object (store as little as necessary to keep originator's discretion)
  - protects against access by objects other than the originator
- Originator
  - creates a memento containing a snapshot of its current internal state
  - uses the memento to restore its internal state
- Caretaker
  - is responsible for the memento's safekeeping
  - never operates on or examines the contents of a memento

### UML