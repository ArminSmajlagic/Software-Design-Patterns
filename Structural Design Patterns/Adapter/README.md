# Adapter Design Pattern (AKA. Wrapper)

### Definition

Adapter converts the interface of a class that we need to use into another interface clients expect and can work with. 
Main goal of adapter is to allow classes to collaborate that could not otherwise because of incompatible interfaces. 

We tend to encounter cases when we want to use a library with useful tools and that is reusable but the interface doesn't match the domain-specific interface an application requires
That is why we use adapter.

### Use

- When we want to use an existing class, and its interface does not match the one you need
- When we want to create a reusable class that cooperates with unrelated or unforeseen classes, that is, classes that don't necessarily have compatible interfaces
- When we need to use several existing subclasses, but it's impractical to adapt their interface by subclassing every one. An object adapter can adapt the interface of its parent class.


### Components

- Target
  - defines the domain-specific interface that Client can uses
- Client
  - collaborates with objects conforming to the Target interface
- Adaptee
  - defines an existing interface that needs adapting
- Adapter
  - adapts the interface of Adaptee to the Target interface (adapter is responsible for functionality the adapted class)

### UML

![UML](https://user-images.githubusercontent.com/45321513/196160915-b44eb731-bdc1-4cfe-817e-16725d314ef5.jpeg)
