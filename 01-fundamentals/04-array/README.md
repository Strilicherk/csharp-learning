# Exercise - Arrays 📎

## General Guidelines: 🚨
1. Respect the attribute and method names defined in the exercise.
2. Pay attention to the arguments specified in the exercise. Do not add unrequested arguments and keep the order defined in the prompt.

---

### Exercise 1 - Arrays

Inside the `ExerciseArrays` class, create the following methods:

* `int Sum(int[] array)`
  * Must return the sum of all elements in the array.


* `double CalculateAverage(double[] grades)`
  * Must return the arithmetic average of all grades contained in the `grades` array.


* `int FindLargestNumber(int[] array)`
  * Must return the largest value within the number array.


* `int CalculateDecimal(int[] binary)`
  * Receives an array containing a binary value and calculates the corresponding decimal value.
  * Example:
    * **Input:** binary = [1, 0, 1, 0]
    * **Output:** 10
  * Tip:
    * To convert `Math.Pow` to the `int` type in C#, use explicit casting like this: `(int)Math.Pow(2.0, 2.0)`


* `char[] Reverse(char[] array)`
  * Must reverse the array received as an argument and return it.
  * Example: `['j', 'a', 'v', 'a'] => ['a', 'v', 'a', 'j']`


* `int[] Merge(int[] array1, int[] array2)`
  * Read two arrays of different sizes (sorted) and create a third array interleaving their elements.
  * Example: \
    A = [1, 2, 5, 8] \
    B = [3, 4, 6] \
    Result = [1, 2, 3, 4, 5, 6, 8]

---

### Challenge - Two Sum

* `int[] TwoSum(int[] array, int target)`
  * Given an array of integers and a target integer, return the indices of the two numbers so that they add up to the target number.
  * You can assume that each input has exactly one solution.
  * Example 1:
    * **Input:** array = [2,7,11,15], target = 9 \
      **Output:** [0, 1]
  * Example 2:
    * **Input:** array = [2,3,4], target = 6 \
      **Output:** [0, 2]