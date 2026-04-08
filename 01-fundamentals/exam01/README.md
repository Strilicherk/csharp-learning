# Continuous Assessment 01 - Practice 📎

## 📌 General Guidelines:
1. Verify that there are **no compilation errors** in the project before submitting.
2. Respect the attribute and method names defined in the exercise.
3. Pay attention to the arguments specified in the exercise. Do not add unrequested arguments and keep the order defined in the prompt.

> Tip: copy and paste the names from the instructions to avoid typos.

## 🎬 Cinema

You are the developer of a system created in C# for the CineTech cinema chain, and you have been asked to implement some methods to help with the cinema's operations.

For this, you were given detailed documentation regarding how this cinema chain works:

### 💺 Room

The prices of the rooms are calculated as follows:

The base price of the room is $30.00.
The 3D room adds $5.00 to the ticket price.
The IMAX room adds $10.00 to the ticket price.

The CineTech cinema has 4 rooms:

* **Room 1:** * Standard room
  * Capacity: 50 seats
  * Price: $30.00


* **Room 2:**
  * 3D room
  * Capacity: 37 seats
  * Price: $35.00


* **Room 3:** * IMAX room
  * Capacity: 90 seats
  * Price: $40.00


* **Room 4:** * 3D and IMAX room
  * Capacity: 80 seats
  * Price: $45.00

### Observations:
* When buying a ticket, students can request a half-entry and pay half the ticket price.
* The cinema **always profits 10%** of the value of each ticket sold.

### 🛠️ Implementation

With the documentation in hand, you must create the following methods inside the `Cinema` class:

* `bool ValidateRoom(int room)`
  * Verifies if the room number is valid.
  * Returns `true` if the room number is valid, and `false` otherwise.
  * Example: if the room number is 3, the return is `true`.
  * Example: if the room number is 5, the return is `false`.


* `double CalculateTicketValue(int room, bool halfEntry)`
  * Calculates the ticket value according to the room and whether it is a half-entry or not.
  * Example: if the room is 3D and the ticket is a half-entry, the ticket value is $17.50.
  * Example: if the room is IMAX and the ticket is full price, the ticket value is $40.00.
  * If the room is invalid, return 0.0.


* `double CalculateTotalProfit(int[] rooms, bool[] students)`
  * Calculates the total profit of the cinema according to the array of rooms and students.
  * Each position in the array represents a ticket, and the program must combine the information from both arrays to get the complete ticket information.
  * Example: 
    * rooms[0] = 2
    * students[0] = false 
    * **Result:** Standard ticket in room 2
  * Example:
    * rooms[1] = 4
    * students[1] = true
    * **Result:** Student ticket in room 4
  * Calculate the profit according to the provided documentation.


### 🍅 Tomatometer:
Rotten Tomatoes collects reviews from professional critics (usually from respected publications).
Each review is classified as "Fresh" (positive) or "Rotten" (negative).
The Tomatometer score is the percentage of reviews that are Fresh.

Formula:

$$
\text{Tomatometer} = \left( \frac{\text{number of Fresh reviews}}{\text{total reviews}} \right) \times 100
$$

#### What do the badges mean?

| Badge                      | Condition                                          |
|----------------------------|----------------------------------------------------|
| Fresh 🍅                   | If the movie has 60% or more positive reviews.     |
| Rotten 🤢                  | If the movie has less than 60% positive reviews.   |

To improve the quality of the movies shown at CineTech, you were asked to implement a system that calculates the Tomatometer badge for the movies that will be playing.

### 🛠️ Implementation

* `string CalculateTomatometerBadge(bool[] reviews)`
  * Calculates the Rotten Tomatoes badge according to the movie's reviews.
  * The reviews array stores each review as a boolean value:
    * true: positive review
    * false: negative review
  * The method **must return** only **"fresh"** or **"rotten"** (in lowercase).
  * **Careful:** convert the values to `double`, otherwise C# will perform integer division.
  * Example:
    * reviews = [true, true, false, true]
    * score = 3 / 4 * 100 = 75%
    * badge = fresh

## 📓 Final Guidelines:

### 🎯 Observations:

1. The project contains automated tests to verify the implementation of the methods.
2. The `Cinema` class is already created, and the methods must be implemented inside it.
3. The project has a `Main` class in case you want to manually test how the methods work.

### 📦 Submission:

1. `commit` the code and then `push` it to the GitHub repository.
2. Open **GitHub** and **verify** if the last `push` was successful.

### Good luck! 🍀