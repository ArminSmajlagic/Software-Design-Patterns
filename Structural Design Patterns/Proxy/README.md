C:\Users\pc\Desktop\DesignPatterns\Structural Design Patterns\Proxy

# Proxy Design Pattern (AKA. surrogate)

### Definition

Proxy pattern provides a surrogate or placeholder for another object to control access to it.
One reason for controlling access to an object is to defer the full cost of its creation and initialization until we actually need to use it.


### Use

- When we have a need for a more versatile or sophisticated reference to an object than a simple pointer
- A remote proxy provides a local representative for an object in a different address space.
- A virtual proxy creates expensive objects on demand
- A protection proxy controls access to the original object (Protection proxies are useful when objects should have different access rights)
- A smart reference is a replacement for a bare pointer that performs additional actions when an object is accessed

### Participants

- Proxy
  - maintains a reference that lets the proxy access the real subject. 
  - provides an interface identical to Subject's so that a proxy can by substituted for the real subject
  - controls access to the real subject and may be responsible for creating and deleting it
  - other responsibilities depend on the kind of proxy
    - remote proxies are responsible for encoding a request and its arguments and for sending the encoded request to the real subject in a different address space
    - virtual proxies may cache additional information about the real subject so that they can postpone accessing it
    - protection proxies check that the caller has the access permissions required to perform a request

- Subject
  - defines the common interface for RealSubject and Proxy so that a Proxy can be used anywhere a RealSubject is expected

- RealSubject
  - defines the real object that the proxy represents

### UML