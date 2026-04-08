# Exercise - Inheritance with Aggregation 📎

## General Guidelines 🚨
1. **Respect** the attribute and method names defined in the exercise.
2. Be **careful** with the **arguments** specified in the exercise.
3. **Do not add** unsolicited arguments and maintain the order defined in the prompt.
4. Verify that there are **no compilation errors** in the project before submitting.
5. Classes must follow **encapsulation** rules (use properties).

---

## Class Diagram
![diagram.png](diagram.png)

## Class: `Developer` 🚩

### Public Methods

**Properties (Getters and Setters)**
- Must contain **all** getter and setter properties.

**`public double CalculateSalary()`**
- **Description**: Calculates the developer's salary based on the `hoursWorked` and `hourlyRate` attributes.

---

## Class: `WebDeveloper` 🖥️

### Public Methods

**Properties (Getters and Setters)**
- Must contain **all** getter and setter properties.

**`public double CalculateSalary()`**
- **Description**: Calculates the developer's salary based on the `hoursWorked` and `hourlyRate` attributes, adding mentoring hours, which are worth **$ 300.00** per hour.

**`public bool IsFullstack()`**
- **Description**: Returns `true` if the developer is fullstack, meaning the `backend`, `frontend`, and `database` attributes are not `null`.

---

## Class: `MobileDeveloper` 📱

### Public Methods

**Properties (Getters and Setters)**
- Must contain **all** getter and setter properties.

**`public double CalculateSalary()`**
- **Description**: Calculates the developer's salary based on the `hoursWorked` and `hourlyRate` attributes, adding prototyping hours, which are worth **$ 200.00** per hour.

---

## Class: `Consultancy` 🏢

### Public Methods

**Properties (Getters and Setters)**
- Must contain **all** getter and setter properties, **except** for the developer list setter.

**`public void Hire(Developer developer)`**
- **Description**: Adds the developer to the consultancy if there are vacancies available.
- **Important**: The `vacancies` attribute represents a maximum limit (capacity) of developers and should not be decremented when hiring.

**`public void HireFullstack(WebDeveloper developer)`**
- **Description**: Adds the fullstack developer to the consultancy, validating if they are truly fullstack according to the rules of the `IsFullstack` method.

**`public double GetTotalSalaries()`**
- **Description**: Returns the sum of all salaries of the developers in the consultancy.

**`public int GetMobileDeveloperCount()`**
- **Description**: Returns the total number of mobile developers in the consultancy.

**`public List<Developer> FindBySalaryGreaterThanOrEqual(double salary)`**
- **Description**: Returns all developers with a salary greater than or equal to the value passed as an argument.

**`public Developer FindLowestSalary()`**
- **Description**: Returns the developer with the lowest salary in the consultancy.
- **Note**: If the list is empty, return `null`.

---

### Challenge ⚡

**`public List<Developer> FindByTechnology(string technology)`**
- **Description**: Returns the developers who use the technology passed as an argument (could be `frontend`, `backend`, `database`, `platform`, or `language`).

**`public double GetTotalSalariesByTechnology(string technology)`**
- **Description**: Returns the sum of the salaries of the developers who use the specified technology.