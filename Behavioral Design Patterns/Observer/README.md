C:\Users\pc\Desktop\DesignPatterns\Behavioral Design Patterns\Observer

# Observer Design Pattern (AKA. Dependents, Publish-Subscribe)

### Definition

Observer  design pattern defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. 
It lets us define a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing.

When we use OOP principles we tend to partition the system into a collection of cooperating classes we need to maintain consistency between related objects.
Reusebility is one of the main key features of OOP which we want to maintain. Tightly coupled objects reduce reusability, that is why we use this pattern to achive consistency.

The Observer pattern describes how to establish relationships between objects.
The key objects in this pattern are subject and observer. 
A subject may have any number of dependento bservers. 
All observers are notified whenever the subject undergoes a change in state. 
In response, each observer will query the subject to synchronize its state with the subject's state.

This kind of interaction is also known aspublish-subscribe. 
The subject is the publisher of notifications. 
It sends out these notifications without having to know who its observers are. 
Any number of observers can subscribe to receive notifications.  

### Use

- When a change to one object requires changing others, and you don't know how many objects need to be changed 
- When an object should be able to notify other objects without making assumptions about who these objects are (avoiding tight coupling)

### Participants

- Subject
  - knows its observers (there can be many observers of one subject)
  - provides an interface for attaching and detaching Observer objects
- Observer
  - defines an updating interface for objects that should be notified of changes in a subject
- Concrete Subject
  - stores state of interest to Concrete Observer objects
  - sends a notification to its observers when its state changes
- Concrete Observer
  - maintains a reference to a Concrete Subject object
  - stores state that should stay consistent with the subject's
  - implements the Observer updating interface to keep its state consistent with the subject's

### UML
![UML](https://user-images.githubusercontent.com/45321513/196162377-42ecb3a4-98e6-4e2e-a43d-a6c7ee3b90b2.jpeg)

