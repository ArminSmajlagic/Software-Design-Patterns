# Decorator Design Pattern (AKA. Wrapper)

### Definition

Decorator extends additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
It lets us attach new behaviors to objects by placing these objects inside special wrapper that contains the behaviors.
The decorator conforms to the interface of the component it decorates so that its presence is transparent to the component's clients.
The decorator forwards requests to the component and may perform additional actions before or after forwarding.
Transparency lets you nest decorators recursively, and allowing an unlimited number of added responsibilities.

### Use

- When we want to add responsibilities to individual objects dynamically and transparently, without affecting other objects
- When when extension by subclassing is impractical

### Participants

- Component
  - defines the interface for objects that can have responsibilities added to them dynamically
- Concrete Component
  - defines an object to which additional responsibilities can be attached
- Decorator
  - maintains a reference to a Component object 
  - defines an interface that conforms to Component's interface
- Concrete Decorator
  - adds responsibilities to the component

### UML

![UML](https://user-images.githubusercontent.com/45321513/196161169-46e981d9-9fce-4f8e-b02a-15ea43ce9229.jpeg)
