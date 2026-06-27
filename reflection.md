1. Why did you use inheritance?
Inheritance was used to represent the IS‑A relationship, since every transport is a Vehicle. It ensures shared behavior and structure across all transports. This reduces duplication and enforces consistency in the system.  

2. Why did you use interfaces?
Interfaces capture the CAN‑DO abilities like driving, flying, or sailing. They allow flexibility so different vehicles can implement only the abilities they need. This makes the design extensible and modular.  

3. Could Helicopter inherit from both Vehicle and Airplane? Why or why not?  
No, because C# only supports single class inheritance. A class can inherit from one base class but implement multiple interfaces. That’s why Helicopter inherits Vehicle and implements both IFlyable and IDriveable.  

4. Why can Helicopter implement both IFlyable and IDriveable?
C# allows multiple interface implementation. This lets Helicopter express both abilities without breaking inheritance rules. It models real‑world behavior where a helicopter can both fly and drive.  

5. If a Submarine can both sail and dive, how would you design it? 
Submarine would inherit from Vehicle to keep the IS‑A relationship. It would implement ISailable and a new IDiveable interface. This way it can perform both sailing and diving actions.  
