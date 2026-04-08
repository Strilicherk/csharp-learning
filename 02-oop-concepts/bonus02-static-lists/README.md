# Coffee Time - 002 ☕ - Static List 📋️

> "The list is the origin of culture. It's part of the history of art and literature. What does culture want? To make infinity comprehensible."
> *Umberto Eco*

## General Guidelines: 🚨
1. Pay **attention** to the **arguments** specified in the exercise.
   **Do not** add unrequested arguments and keep the order defined in the prompt.
2. Verify that there are **no compilation errors** in the project before submitting.
3. Classes must follow encapsulation rules.

## Static List: 📚️

A **List** is a type of data structure characterized by containing information of the same type.

Lists can be implemented statically or dynamically.
A dynamic list implementation allows its size to be changed at runtime.
In this exercise, we will work with the implementation of a static list from scratch.

**Static lists** can be implemented using **vectors (or arrays)**.
Arrays are characterized by storing elements of the same type.
The size of the array is defined at the time of its creation, statically (it does not change at runtime).

The **array** has its **index ranging from 0 to n-1** (where n is the number of elements in the array).

We are going to implement a class that represents a Static List.
Initially, we will implement a static list of integers.

Below is the description of how the class will be structured:

### Class `StaticList` 🗂️

#### Attributes: 📌

The class has the following attributes:

* `int?[] array`
* `int elementCount` - Represents the actual amount of elements inserted into the array and also represents the index where the next value will be inserted.

#### Constructor: 🏗️

* `StaticList(int capacity)`

    * Receives the maximum capacity of the array.
    * Initializes the array with the provided size.
    * Initializes `elementCount`.

#### Methods: 🛠️

Implement the following methods:

* `void Add(int? element)` ➕

    * Receives the element to be inserted.
    * If the array is "full", displays a "List is full" message and does not add the element to the array.


* `int Search(int? element)` 🔍

    * Receives the element to be searched for.
    * Returns the array index where the element is located, or -1 if it was not found.


* `bool RemoveByIndex(int index)` ❌

    * Receives the index of the element to be removed.
    * Returns `true` if it was removed, or `false` if the index is invalid.
    * Reorganizes the array if necessary.
    * Example:
        * Initial array: [1, 2, 3]
        * Remove index: 1
        * Result: [1, 3, null]


* `bool RemoveElement(int? element)` 🧹

    * Receives the element to be removed.
    * Searches for the element to be removed.
    * Returns `true` if it was removed, and `false` if it was not found.
    * Reorganizes the array if necessary.
    * Example:
        * Initial array: [10, 20, 30]
        * Remove element: 20
        * Result: [10, 30, null]


* `override string ToString()` 📝

    * Returns the elements of the array in text format.
    * Ex: \[10, 90, 80, 4, 8]