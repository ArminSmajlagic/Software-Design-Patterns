# Command Design Pattern (AKA. Action, Transaction)

### Definition

Command Design Pattern turns a request into a stand-alone object that contains all information about the request.
This transformation lets US pass requests as a method arguments.
The Pattern encapsulates a request as an object, thereby letting you parameterize clients with different requests, delay or queue a request’s execution or log requests, and support undoable operations.
Executed commands are stored in a history list so it is easy to perform rollback of request execution. 
A request can be executed as a transaction (transaction encapsulates a set of changes to data).

Command decouples the object that invokes the operation from the one that performs it.
They are classes that can be manipulated and extended like any other object.
Commands can be assembled into a composite command (in this case composite commands are an instance of the Composite pattern)
It's easy to add new Commands, because we don't have to change existing classes.

### Use

- When we want to parameterize objects by an action to perform (procedural languages implement this as rollback function)
- When we want to specify, queue, and execute requests at different times (A Command object can have a lifetime independent of the original request)
- When we want to suport undo operation (the Command's Execute operation can store state for reversing its effects in the command itself)
- When we want to support logging changes so that they can be reapplied in case of a system crash (tihs is possible if we extend command interface with load and store operations)


### Participants

- Command
  - declares an interface for executing an operation
- Concrete Command
  - defines a binding between a Receiver object and an action
  - implements Execute by invoking the corresponding operation(s) on Receiver
- Client
  - creates a Concrete Command object and sets its receiver
- Invoker
  - asks the command to carry out the request
- Receiver
  - knows how to perform the operations associated with carrying out a request. Any class may serve as a Receiver


### UML

![UML](https://user-images.githubusercontent.com/45321513/196161922-6ecdcee8-76ac-43da-a9ec-803d80011db6.jpeg)
