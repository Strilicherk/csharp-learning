# Exercise - Relationships 2 📎

## General Guidelines: 🚨
1. **Respect** the attribute and method names defined in the exercise.
2. Be **careful** with the **arguments** specified in the exercise.
   **Do not** add unsolicited arguments and keep the order defined in the prompt.
3. Verify that there are **no compilation errors** in the project before submitting.
4. The classes must follow encapsulation rules.

## Banking System

Open the sample project and implement the `Transaction` and `CheckingAccount` classes as follows:

![diagram.png](diagram.png)

## Checking Account

* Must have all getter and setter properties, except for the transaction list setter.

Methods:

* AddTransaction:
  * Must validate if the category or description are null or consist only of whitespace characters.
  * Must also validate if the transaction value is null or different from 0.
  * If the transaction is valid, add it to the transaction list.

* FindTransactionsByCategory:
  * Must search for all transactions already performed with a specific category, ignoring case sensitivity.
  * If none are found, return an empty list.

* FindTransactionsByValue:
  * Must search for all transactions already performed with a specific value.
  * If none are found, return an empty list.

* FindOutcomeTransactions:
  * Must search for all outcome transactions, i.e., those with a negative value.
  * If none are found, return an empty list.

* FindIncomeTransactions:
  * Must search for all income transactions, i.e., those with a positive value.
  * If none are found, return an empty list.

* FindTransactionsByDescription:
  * Must search for all transactions containing a specific description.
  * To facilitate the search, the method should allow searching with only a part of the description so the user doesn't need to type the full description.
  * Also, ignore case sensitivity. If none are found, return an empty list.
  * If the parameter is null, return an empty list.
  * **Tip**: Use the `Contains()` method to check if a specific string is present in another.

* FindHighestValue:
  * Must search for the highest value among all transactions performed in the bank account.
  * If there are no transactions in the list, return 0.

* FindLowestValue:
  * Must search for the lowest value among all transactions performed in the bank account.
  * If there are no transactions in the list, return 0.

* GetBalance:
  * Must return the final account balance after all transactions have been processed.
  * If there are no transactions in the list, return 0.

## Transaction

* Must have all getter and setter properties and a full constructor.

## 💡 Tip

* To check if a `string` contains only whitespace characters, use the `string.IsNullOrWhiteSpace()` method in C#.