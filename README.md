TASK 1 : VEHICLE RENTAL SYSTEM

How do I approached the problem?
Firstly, I had to read the problem carefully and understand it well. 
Secondly, I tried to image the solution in my head.
Thirdly, I selected the best way of solving this problem and started writing code.
During the process I had small issues, but I managed to fix them( Who runs code sucessfully in the first attempt :D).

How does the solution work?
I have used polymorphism. By doing that I can have:
Managable code,
Code quality,
OOP and SOLID princeples.

I had to find the commong properties for all the vehicles and created an abstract class "Vehicle".
After that there were a different property for the rest of classes.(safety rating, age, years of experience).

When I inherited the abstract class I had to calculate the total cost, insurance and additional insurance. They were different according to the vehicle.

Then I had to create a class "Invoice".
In this class I calculate the total sum for :
Total cost
Insurance
Additional insurane
Total sum.

I have used abstraction and encapsulation, because there were methods such as :
TTotal cost
Insurance
Additional insurane
which must no be shown public. If they are the user might change the current formula.



