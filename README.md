# Professional-Design-Patterns-Implementations
Professional Design Patterns Implementations 

This repository contains the ***professional design patterns implementations of mine*** that I use to teach design patterns to young software engineering students.

Now it's free for everyone.

# Design Patterns Explanations

### Singleton Design Pattern
The Singleton Design Pattern ensures that only one instance of an object is created and that this instance is always used.

**How do we use the Singleton Design Pattern in real life?**
- The main purpose of the Singleton Design Pattern is to ensure that an object instance and its value, when changed, are used uniformly by multiple users. For example, if we want to keep track of the number of visitors currently on a website, this visitor count is the same for all users and everyone reads the same value. When a new visitor enters the system, this value is incremented, and again, everyone is affected uniformly. This way, the state of an instance is controlled.
- If an object instance, especially when passing between layers, is only performing operations and does not hold any value, using the Singleton Design Pattern is very beneficial. For example, imagine a class in your business layer that performs add, delete, update operations. This class is re-created (new'ed) for every user operation, which is a costly process. Instead, we should create this object once and make it usable by everyone.

**When should we use the Singleton Design Pattern?**
- When an object is created using the Singleton Design Pattern, it occupies space in memory for the entire runtime of the program. If a Singleton object is to be created, this object should be used uniformly by everyone.

**Factory Method Design Pattern and Singleton Design Pattern**
- Professional programmers instance a Singleton object through the Factory Method Design Pattern in the business layer.

### Factory Method Design Pattern
The Factory Method Design Pattern is one of the most commonly used design patterns today. Its purpose is to control changes in software. It includes a structure that can vary from logging used in the data access layer to caching systems, implementing different techniques over time. This, of course, also applies to business layer objects.

### Abstract Factory Design Pattern
- In addition to the Factory Method Design Pattern, the Abstract Factory Design Pattern is used for bulk object usage, making object usage easier and creating logic for standard objects when data states require it, and for object creation.
- When writing code in a business layer, you might need to use different techniques such as logging and caching. Logging and caching each have various methods within them.
  - Logging → to a database, file, email, etc.
  - Caching → memory cache, Redis cache, etc.
  - Instead of using consecutive "if" commands to manage these situations, the Abstract Factory Design Pattern is used.

### Prototype Design Pattern
- The purpose of the Prototype Design Pattern is to minimize object creation costs. It is not always possible to use the Prototype Design Pattern; it can only be used as needed. If there is a base class, its clone can be created, and new objects can be produced from that clone.

### Builder Design Pattern
- As the name suggests, the Builder Design Pattern aims to create an instance of an object. This instance is created as a result of sequential steps being processed in order. Professional programmers usually use this pattern in the business layer or user interface layer to avoid writing code with consecutive "if" commands and instead inject the relevant Builder and instantiate accordingly.
- Suppose you have a model object or DTO object in an interface. Different product information is shown to new users and old users on an e-commerce site. To achieve this, a series of sequential steps must be applied.

### Facade Design Pattern
- The Facade Design Pattern is one of the simplest design patterns to implement. The meaning of "Facade" is "front," "appearance." It gathers various classes used for common purposes into a single facade, making access to these classes easier.

### Adapter Design Pattern
- The Adapter Design Pattern ensures that a different system can work as a natural part of the existing system without disrupting the existing system.

### Composite Design Pattern
- The purpose of the Composite Design Pattern is to create a hierarchy among objects and to access these hierarchical objects when needed.

### Proxy Design Pattern
- The Proxy Design Pattern is similar to a caching system. When a class is called for the first time, it performs a certain operation, but when called a second time, it uses the results from the previous call.

### Decorator Design Pattern
- The Decorator Design Pattern is used to assign different meanings to a basic object under different conditions.

### Bridge Design Pattern
- In the Bridge Design Pattern, the purpose is to use abstraction techniques to manage parts of an object that can be abstracted, changed, or switched.

### Strategy Design Pattern
- The Strategy Design Pattern involves determining a strategy and executing a method according to that strategy.

### Observer Design Pattern
- The Observer Design Pattern can be used frequently. It is a design pattern that allows systems subscribed to it to be activated when an operation occurs. For example, in a shopping system, customers may want to be notified when the price of a product drops. The Observer Design Pattern can be used for such situations.

### Chain of Responsibility Design Pattern
- The Chain of Responsibility Design Pattern is used to create hierarchical objects. It indicates which object to activate according to certain conditions. There is a hierarchical structure among these objects. Imagine you are in a company and making expenses. If these expenses are under 100 units, your manager can authorize the expense, but if the expenses are over 100 units, the vice president decides. For expenses over 1000 units, the president approves.

### Memento Design Pattern
- The Memento Design Pattern is used as needed. It allows an object to revert to its previous state after a change.

### Template Method Design Pattern
- The Template Method Design Pattern is used very frequently. Imagine you are controlling business processes in a business layer and have different operations within a method. Each of these different operations can be called by different methods. However, if each operation behaves differently according to different conditions, you would need to write a lot of nested "if" commands to manage them. With the Template Method Design Pattern, you can quickly create a template, abstract it, and assign concretes (concrete implementations) to this abstract template to perform the operation.

### State Design Pattern
- The State Design Pattern is used to control the current state of an object.

### Mediator Design Pattern
- The Mediator Design Pattern is very useful. It is used to make different systems communicate with each other. Imagine a teacher providing online education remotely; students and the teacher will communicate through an application. A student sends their question to the teacher via the application, or the teacher sends their answer to the student via the application.

### Command Design Pattern
- The Command Design Pattern is very useful. We actually use it frequently in daily life. For example, when you open a text editor, write something, save it, and then write something again, the text editor keeps all these changes in a list. This allows you to undo any changes by pressing Ctrl+Z. You can also think of this in robot programming, where a robot can take a step back or turn right/left using commands. In an automation system, the Command Design Pattern can be used to list the operations performed by a user and send them to the database later.

### Visitor Design Pattern
- The Visitor Design Pattern is very useful. It allows similar or hierarchical objects to be called through one of them. Imagine you want to increase the salaries of all the hierarchies in a company. You can create a hierarchical model for this, but the purpose of the Visitor Design Pattern is to maintain other objects from the top of the hierarchy to the bottom using the same pattern.

### Dependency Injection Design Pattern
- The Dependency Injection Design Pattern is used to eliminate the dependency of one object on another. It is very useful for transitioning between layers. For example, when transitioning from the business layer to the data access layer, the business layer's dependency on the data access layer needs to be minimized or even eliminated. Additionally, it suggests minimizing the internal dependency of business layer code. The use of cross-cutting concerns such as logging, caching, and security with Dependency Injection is also very common.

### Null Object Design Pattern
- Sometimes, when developing software, you might want the job definition you create to do nothing for testing purposes. You cannot directly send null because you will get a null reference error. Instead, you design an object that does nothing and send that.

### Multiton Design Pattern
- As the name suggests, it is a multiple version of Singleton. The Multiton Design Pattern produces instances for specific conditions and provides the relevant instance when needed for that condition.
