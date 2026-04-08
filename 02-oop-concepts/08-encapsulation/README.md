# Exercise - Encapsulation and UML 📎

## General Guidelines: 🚨
1. **Respect** the attribute and method names defined in the exercise.
2. Be **careful** with the **arguments** specified in the exercise.
   **Do not** add unsolicited arguments and keep the order defined in the prompt.
3. Verify that there are **no compilation errors** in the project before submitting.
4. The classes must follow encapsulation rules.
5. Leave an **empty constructor** for use in unit tests.

## Exercise - Transit Pass 🚩

Implement the following class diagram:

![image](diagrama/bilhete-unico.png)

Methods of the `TransitPass` class:

* The class should contain only properties (getters and setters) to access and modify the attribute values.

Methods of the `Bus` class:

* The class should contain only getter properties to access the attributes.

* ChargeFare(transitPass: TransitPass)
  * checks if the pass is blocked, and if so, displays the message "blocked transit pass".
  * checks if there is enough balance on the pass, and if not, displays the message "Insufficient balance to perform the operation".
  * updates the **balance** value of the pass.
  * students pay half the fare value.
  * updates the **passengerCount** attribute.

* ChargeFare(money: double)
  * checks if the provided amount of **money** is sufficient to pay the fare, and if not, displays the message "Insufficient money to perform the operation".
  * updates the **passengerCount** attribute.

Methods of the `RechargeStation` class:

* The class should contain only getter properties to access the attributes.

* CheckBalance(transitPass: TransitPass)
  * checks if the pass is blocked, and if so, displays the message "blocked transit pass", returns 0, and does not update the **consultationCount** attribute.
  * updates the **consultationCount** attribute.
  * **returns** the current balance value of the pass (`double`).

* Recharge(transitPass: TransitPass, amount: double)
  * checks if the recharge amount is at least R$ 5.00 (Minimum value), and if not, displays the message "Minimum recharge value not reached".
  * checks if the pass is blocked, and if so, displays the message "blocked transit pass".
  * updates the pass's **balance** value by adding the recharge amount.
  * updates the **rechargeCount** attribute.

* Block(transitPass: TransitPass)
  * updates the **isBlocked** attribute of the transit pass to true.