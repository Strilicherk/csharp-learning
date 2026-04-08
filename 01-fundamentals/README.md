# Leveling - Methods 📎

## General Guidelines: 🚨
1. Respect the attribute and method names defined in the exercise.
2. Pay attention to the arguments specified in the exercise. Do not add unrequested arguments and keep the order defined in the prompt.

---

### Exercise 1

Inside the `ExerciseMethods` class, write the following methods:

* `bool VerifyMajority(int age)`
  * Must return `true` if the age passed as an argument is greater than or equal to 18, and `false` otherwise.


* `double CalculateAverage(double value1, double value2, double value3)`
  * Must return the average of the values passed as arguments.


* `int LargestNumber(int value1, int value2, int value3)`
  * Must return the largest number among the values passed as arguments.


* `int CalculateFactorial(int value)`
  * Must return the factorial of the value passed as an argument.
  * The factorial of a number is the product of all positive integers from 1 to the number itself.
  * Example: 5! = 5 * 4 * 3 * 2 * 1 = 120


* `bool VerifyPrime(int value)`
  * Must return `true` if the value passed as an argument is a prime number, and `false` otherwise.
  * A prime number is a natural number greater than 1 that has only two divisors: 1 and itself.


* `int CalculatePower(int baseValue, int exponent)`
  * Must return the result of the base number raised to the exponent passed as an argument.
  * Example: 2^3 = 2 * 2 * 2 = 8
  * Use a loop to calculate the power.


* `int CalculateChangeInCandies(double purchaseValue, double receivedValue)`
  * Must return the amount of candies that can be bought with the change from the purchase.
  * Consider that each candy costs $0.25.
  * Example: If the purchase was $10.00 and the received value was $20.00, the change will be $10.00. With this change, it is possible to buy 40 candies.
  * If the received value is less than the purchase value, return 0.
  * **Tip:** Use a loop.

---

### Challenge - Verify Palindrome

* `bool VerifyPalindrome(string word)`
  * Must return `true` if the word passed as an argument is a palindrome, and `false` otherwise.
  * A palindrome is a word, phrase, or number that reads the same backward as forward.
  * Example: "radar", "kayak", "12321", "Race car"
  * Tip: Useful tools from the `string` class in C#:
    * `Replace()` returns a new string replacing a character or string of your choice with another.
    * `ToLower()` returns a copy of the string converted to lowercase.
    * `[]` (indexer) gets a character from the text at a specific index (e.g., `word[0]`).
    * `Length` property gets the size of the text.