# List 5 - Introduction to OOP 📎

## General Guidelines: 🚨
1. **Respect** the attribute and method names defined in the exercise.
2. Be **careful** with the **arguments** specified in the exercise. 
**Do not** add unsolicited arguments and keep the order defined in the prompt.
3. Verify that there are **no compilation errors** in the project before submitting.

## Tips: 💡
* Be careful when dividing values in C#. Dividing integer values always results in an integer division.
  ```csharp
  // Integer division of two integers
  double value = salary * 10 / 100;
  // > Result: 10 / 100 = 0
  
  // Division of an integer and a double
  double value2 = salary * 10 / 100.0;
  // > Result: 10 / 100.0 = 0.1

## Exercise 1 - Bakery 🚩

Dona Maria's bakery needs a system to manage the cakes sold in her store, enabling the generation of a sales report for each type of cake. To implement the system in C# with OOP (Object-Oriented Programming), create:

The `Cake` class must contain the following attributes and methods:

**Attributes:**
* flavor (`string`) (e.g., chocolate, strawberry, or pineapple)
* price (`double`) (e.g., 30.00 and 50.00)
* quantitySold (`int`) (e.g., 10)
* quantityInStock (`int`) (e.g., 100)

**Methods:**
* SellCake: 
  * **receives** an integer representing the desired quantity of the cake.
  * **updates** the `quantitySold` attribute with the new quantity.
  * **updates** the `quantityInStock` attribute with the new quantity after the cake sale.
  * if the requested quantity is a negative value, **do nothing**.
  * if the requested quantity exceeds the available limit, **do nothing**.

* IncreaseStock:
  * **receives** an integer representing the quantity to be added to the stock.
  * **updates** the `quantityInStock` attribute with the new quantity.
  * if the provided quantity is a negative value, **do nothing**.

* AvailableQuantity:
  * **returns** how many units of this cake are available for sale (`int`).

* TotalSold:
  * **returns** the total amount of money from sold cakes (`double`).

Use the `Main` method in a `BakeryTest` class to run the necessary tests.

## Exercise 2 - Packages 🚩

Create a program to manage a carrier's packages, generate shipping labels, and calculate shipping costs.

The `Package` class must contain the following attributes and methods:

**Attributes:**
* size (`string`) (e.g., S, M, L)
* senderAddress (`string`) (e.g., 18 Gloria Saints Street)
* recipientAddress (`string`) (e.g., 255 Dr. Pedro Ave)
* distance (`double`) (e.g., 42.2)
* productValue (`double`) (e.g., 87.50)

**Methods:**

* CalculateShipping:
  * **returns** the shipping cost of the product (`double`), taking into account the defined **size** and **distance**.
  * use the following tables for the calculation:

    | Size | Added Value 💸 |
    |---------|------------------------------------|
    | **S** | 1% of the package value |
    | **M** | 3% of the package value |
    | **L** | 5% of the package value |

    | Distance | Added Value 💸 |
    |------------------------|---------------------|
    | **Up to 50km** | $ 3.00 |
    | **Between 50km and 200km** | $ 5.00 |
    | **Above 200km** | $ 7.00 |

* ApplyDiscountCoupon:
  * **receives** the discount percentage to be applied to the product value, e.g., 20, 15... 
  **(`int`)**
  * **alters** the product value to the new discounted value.

* TotalPackageValue:
  * **returns** the total value of the package (product value + shipping cost) (`double`).

Use the `Main` method in a `PackageTest` class to run the necessary tests.

## Exercise 3 - Company 🚩

Create a program to manage a company's employees.

The `Employee` class must contain the following attributes and methods:

**Attributes:**
* name (`string`) (e.g., William)
* role (`string`) (e.g., Systems Analyst)
* salary (`double`) (e.g., 8000.0)

**Methods:**

* AdjustSalary:
  * **receives** the percentage value of the adjustment (e.g., 10, 20) (`int`).
  * **updates** the `salary` attribute with the new adjusted value.

* CalculateHourlyRate:
  * **returns** the value of the hour worked per month given the `salary` of the `Employee` (`double`).
  * consider that each employee works 220 hours per month.

* CalculateOvertime:
  * **receives** the amount of hours worked outside the regular working hours (`int`).
  * **receives** the night shift premium percentage to be received (`int`).
  * **returns** the amount to be received in overtime given the (**salary**, **overtime hours worked**, and **night shift premium**) (`double`).

Use the `Main` method in a `CompanyTest` class to run the necessary tests.


