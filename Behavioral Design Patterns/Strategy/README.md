# Strategy Design Pattern (AKA. Policy)

### Definition

Strategy Design Pattern defines a family of algorithms, encapsulate each one, and make them interchangeable. 
Strategy lets the algorithm vary independently from clients that use it.
We tend to encounter a case where we have many classes that are very simular but offer diferent operations.
Strategies provide a way to configure a class with one of many behaviors.
The Strategy pattern suggests that you take a class that does something specific in a lot of different ways and extract all of these algorithms into separate classes called strategies.

### Use

- When many related classes differ only in their behavior
- When we need different variants of an algorithm (algoirthms with different space/time complexity)
- When we want to avoid exposing complex, algorithm-specific datastructures

### Participants

- Strategy
  - declares an interface common to all supported algorithms.
- ConcreteStrategy
  - implements the algorithm using the Strategy interface
- Context
  - is configured with a ConcreteStrategy object
  - maintains a reference to a Strategy object (to call the algorithm defined by a Concrete Strategy)
  - may define an interface that lets Strategy access its data

### UML

![UML](https://user-images.githubusercontent.com/45321513/196162587-b09286a1-8818-49fe-9d21-ef6f8572f9f4.jpeg)
