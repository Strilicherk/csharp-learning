# Revision - Methods 📎

## General Guidelines: 🚨
1. Respect the attribute and method names defined in the exercise.
2. Pay attention to the arguments specified in the exercise. Do not add unrequested arguments and keep the order defined in the prompt.

## Exercise 1

Inside the `GradeManager` class, write the following methods:

- `List<double> ReadGrades()`:
    - This method asks the user to input the number of grades, and then reads each grade from the console, adding it to the list of grades.
    - Returns the list of grades.
    - If the user enters an invalid value (less than 1) for the amount of grades, return an empty list.

- `double? CalculateAverage(List<double> grades)`:
    - Calculates the average of the provided grades by summing all of them and dividing by the total number of grades.
    - If the list is null or empty, it must return `null`.

- `bool? VerifyResult(double? average)`:
    - Returns whether the student passed or failed, considering 7.0 as the minimum passing grade.
    - Returns `null` if the average value is null or negative.

- `void CalculateDifference(List<double> grades, double average)`:
    - This method receives a list of grades and calculates the difference between each grade and the average.
    - If the grade is equal to the average, display the message:
      ```
      Grade X is exactly the average.
      ```
      If the grade is above the average, display the message:
      ```
      Grade X is Y point(s) above the average.
      ```
      If the grade is below the average, display the message:
      ```
      Grade X is Y point(s) below the average.
      ```

- `double? CalculateWeightedAverage(List<double> grades)`:
    - This method reads from the console a weight for each provided grade and adds it to a list of weights.
    - Calculates the weighted average of the grades by multiplying each grade by its respective weight and dividing by the sum of the weights. For example:
        - grades: [5.0, 6.0, 7.0]
        - weights: [1.0, 2.0, 3.0]
        - weighted average = (5.0 * 1.0 + 6.0 * 2.0 + 7.0 * 3.0) / (1.0 + 2.0 + 3.0) = 6.33

Inside the `Main` method, call these methods.