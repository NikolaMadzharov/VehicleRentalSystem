TASK 1: VEHICLE RENTAL SYSTEM
How did I approach the problem?

Understanding the Problem: I started by reading the problem carefully to understand the requirements and constraints.

Visualizing the Solution: I then visualized the solution in my head, considering various approaches to solving the problem.

Selecting the Best Approach: I selected the most efficient approach and began writing the code. During the process, I encountered small issues, but I managed to fix them (who runs code successfully on the first attempt, right?
).

How does the solution work?
I used polymorphism to achieve a maintainable, high-quality code base that adheres to OOP and SOLID principles.

Abstract Class: I identified common properties for all vehicles and created an abstract class called Vehicle. This class serves as a base class for all vehicle types.

Specific Properties: Each derived class has specific properties (e.g., safety rating, age, years of experience) that are unique to that type of vehicle.

Calculations: When inheriting the abstract class, I implemented methods to calculate the total cost, insurance, and additional insurance, which vary according to the vehicle type.

Invoice Class: I created a class called Invoice to calculate the total sums, including:
Total cost
Insurance
Additional insurance
Overall total sum

I employed abstraction and encapsulation to hide methods like TotalCost, Insurance, and AdditionalInsurance from being publicly accessible. This prevents users from altering the current formula, ensuring the integrity of the calculations.
