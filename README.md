# Exercise 7: Temperature Conversion

This is an exercise for the coursera course [Introduction to C# Programming and Unity](https://www.coursera.org/learn/introduction-programming-unity)

### Problem 1 – Temperature Calculations with Int


1. Declare three **int** variables to store an original temperature in Fahrenheit, a calculated temperature in Celsius, and a calculated temperature in      Fahrenheit (when you convert from Celsius back to Fahrenheit).
2. Assign 0 as your original temperature in      Fahrenheit and print that Fahrenheit value, convert to Celsius and print the Celsius value, then convert the Celsius value back to Fahrenheit and print the Fahrenheit value. Be sure to label each of your outputs rather than just printing out the numbers.
3. Assign 32 as your original temperature in Fahrenheit and print that Fahrenheit value, convert to Celsius and      print the Celsius value, then convert the Celsius value back to Fahrenheit and print the Fahrenheit value. Be sure to label each of your outputs rather than just printing out the numbers.
4. Assign 212 as your original temperature in Fahrenheit and print that Fahrenheit value, convert to Celsius and print the Celsius value, then convert the Celsius value back to Fahrenheit and print the Fahrenheit value. Be sure to label each of your      outputs rather than just printing out the numbers.
Attach the script to the Main Camera in the scene and run the game to see the output in the Console window.

You'll discover that the conversion from 0 to Celsius and back to Fahrenheit yields 5, not 0, for the final Fahrenheit temperature. That's one of the points of this exercise! Think about the data type you used and why you might get this result given that data type.

### Problem 2 – Temperature Calculations with Float

1. Declare three **float** variables to store an original temperature in Fahrenheit, a calculated temperature in Celsius, and a calculated temperature in      Fahrenheit (when you convert from Celsius back to Fahrenheit).
2. Assign 0 as your original temperature in      Fahrenheit and print that Fahrenheit value, convert to Celsius and print the Celsius value, then convert the Celsius value back to Fahrenheit and print the Fahrenheit value. Be sure to label each of your outputs rather than just printing out the numbers.

Now the conversion from 0 to Celsius and back to Fahrenheit is closer to 0, but it’s still not exactly 0. Remember, even though floating point numbers are approximations of the real numbers in the continuous domain, they give us more precision than whole numbers do. That's why we got a closer final Fahrenheit temperature when we used **float** variables instead of **int** variables.

### Problem 3 – Temperature Calculations with Double

1. Declare three **double** variables to store an original temperature in Fahrenheit, a calculated      temperature in Celsius, and a calculated temperature in Fahrenheit (when you convert from Celsius back to Fahrenheit).
2. Assign 0 as your original temperature in Fahrenheit and print that Fahrenheit value, convert to      Celsius and print the Celsius value, then convert the Celsius value back to Fahrenheit and print the Fahrenheit value. Be sure to label each of your outputs rather than just printing out the numbers.

Finally, the conversion from 0 to Celsius and back to Fahrenheit yields a 0 as you probably originally expected. Because the **double** data type uses more bytes than the **float** data type, we don’t get the rounding error we got when we used **floats**.  

This exercise shows how data type really matters, especially when we do multiple calculations.
 
## Installation
To install, follow these steps:

Via Downloading from GitHub:

Download this repository onto your machine by clicking the "Clone or Download" button or Fork the repo into your own Github account
Download and extract the zip file to a directory of your choice.  

Via command line:

`$ git clone https://github.com/puglisac/coursera-c-sharp-ex7.git`  

open Exercise7.sln in [Visual Studio](https://visualstudio.microsoft.com/) and click Run to start.
