# DigitalFootballPrototype

Homework 8 in C#

You’re hired by FIFA to help them with creating a prototype for „digital football“.

Since this is a testing prototype, the usage scenarios are simplified. Soccer field is represented only by X
coordinate, where 0 is the value of the center line. Right edge of the field is 45; left edge is -45. Y axis is
not taken into consideration: we only check ball movement from left to right and back.

The ball has:
Method for calculating and returning the average speed of the ball. This method takes 3
parameters: starting position, final position and time and calculates the average speed based on
them. Formula for speed is v=s/t

The positions are given as x-axis values. The positions can be also negative so take this into
consideration. The result has to always be positive.

For example:
CalculateAverageSpeed(30, 70, 20). Result: ((70-30)/20))= 2.
CalculateAverageSpeed(30, -10, 20) Result: ((-10-30))/20))= 2.
CalculateAverageSpeed(30, 0, 20) Result: ((0-30))/20))= 1.5

Method for determining whether the goal (värav) counted or not, based on the coordinate of
the ball (coordinate for x axis is the method parameter). To count as a goal, the whole ball has to
be inside the goal; having half of the ball in does not count.
To simplify, we assume that the goal is shaped like a box. The coordinate represents the middle
point of the ball. The ball is inside a goal if:
ballCoordinate - ballRadius>= goalCoordinaates –goalDepth

Method for finding the total number of goal attempts (from previous method): separate the ones that counted and the ones that did not count (where ball was not fully in the goal).

Method for calculating the kinetic energy of hitting the ball with foot. This method takes velocity as a parameter and prints kinetic energy. Kinetic energy is calculated by: E = (mv^2)/2, where m is the weight of the ball and v is the velocity.

Method for creating and printing out a unique code for the ball.
  For the normal ball the code is generated from four first letters from the sponsor’s name and 5 random numbers.
  For the youth ball the code is generated from three first letters from the sponsor’s name and 3 random numbers.
Think of possible exceptions and avoid them or catch them!

There are two different balls:
Normal ball diameter is 70 cm. With normal ball the goal depth is always 1.7m. The weight of the ball is 450g.
Youth ball diameter is 56 cm. With this ball the goal depth is 1.4m. The weight is 380g.
Both balls have a constructor that takes sponsor’s name as a parameter.

In main method create both balls. With both:
Try checking if the ball was inside the goal with 20 random coordinate values (test also negative ones). Also try the situations where the coordinates are invalid. After doing that print out how many goals counted and how many did not count. The sum of them should be 20.
Calculate average speed for 10 random coordinates.
Find kinetic energy for velocity values ranging from 1 to 5.
Create a unique code for both balls.

Tips:
How to solve:
1. Write on a paper all the methods and properties the classes should have and find which
class should be the base class.
2. Implement base class and test it in main method.
3. If base class works, then start creating derived classes.
• Take into consideration the limits for the coordinates; coordinates can range from -45 to 45. Tip: make a separate method to check the validity of the coordinates.
• Start by thinking through what methods should the classes contain and how they differ fromeach other. Start from writing the base class.
