# Coffee Time - 001 ☕ - Date and Time 📅⏰

> "I wasted time, and now doth time waste me."
> *William Shakespeare*

## General Guidelines: 🚨

1. Respect the attribute and method names defined in the exercise.
2. Pay attention to the arguments specified in the exercise. Do not add unrequested arguments and keep the order defined in the prompt.

---

### 🕰️ Exercise 1 - Verify if a date has passed

`bool IsPast(DateTime startDateTime, DateTime endDateTime)`

- Must return `true` if `startDateTime` is before `endDateTime`, otherwise `false`.

---

### 🎂 Exercise 2 - Calculate age

`int CalculateAge(DateTime birthDate, DateTime currentDate)`

- Must return the age in full years considering the birth date and the current date.

**Example:**

- Input: `birthDate = 2000-09-01`, `currentDate = 2025-09-01`
- Output: `25`

> **💡 Tip**
> - In C#, subtracting two `DateTime` objects returns a `TimeSpan`, which counts days, not years. 
> - A common way to calculate age in C# is by subtracting the `.Year` property of both dates, and then adjusting the result down by 1 if the birthday hasn't occurred yet in the current year.
> - Official Documentation for `DateTime`: https://learn.microsoft.com/en-us/dotnet/api/system.datetime

---

### 📆 Exercise 3 - Verify weekend

`bool IsWeekend(DateTime date)`

* Must return `true` if the informed date is a Saturday or Sunday, otherwise `false`.

**Example:**

- Input: `date = 2025-09-06` (Saturday)
- Output: `true`

> **💡 Tip**
> - You can use the `DayOfWeek` property from your `DateTime` object. It returns an enumeration representing the day.
> - Be careful: The `DayOfWeek` enum in C# uses a different numeric sequence than the one requested in Exercise 6. In C#, it follows: **0 = Sunday, 1 = Monday ... 6 = Saturday**.

---

### 📅 Exercise 4 - Next business day

`DateTime NextBusinessDay(DateTime date)`

* Must return the next date that is neither Saturday nor Sunday.

**Example:**

- Input: `date = 2025-09-06` (Saturday)
- Output: `2025-09-08` (Monday)

---

### ✍️ Exercise 5 - Format date and time

`string FormatDateTime(DateTime dateTime)`

- Must format the date and time with the following fields:

    - Month and year
    - 12-hour time with minutes and seconds
    - AM/PM
    - Fractions of a second (C# calculates "ticks" which can represent down to 100-nanosecond intervals. You can extract up to 7 decimal places).

**Example:**

- Input: `dateTime = 2025-09-25T15:30:45.123`
- Output: `09/25/2025 03:30:45 PM (nanoseconds: 123)`

> **💡 Tip**
> - You can use the `ToString("format")` method.
> - You will need custom format specifiers like `MM`, `yyyy`, `hh`, `tt`, and `f` or `F`.
> - Official Documentation for Custom Date and Time Format Strings: https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings

---

### 🗓️ Exercise 6 - Generate Weekly Meetings

`List<DateTime> GenerateWeeklyMeetings(DateTime startDate, DateTime endDate, List<int> daysOfWeek)`

* Generates a list with **all meeting dates** that occur between `startDate` and `endDate`.
* Each meeting happens on the **days of the week specified** in `daysOfWeek`.
* The `daysOfWeek` input list follows the pattern: **1 = Monday ... 7 = Sunday**.

**Example 1:**

* **Input:**
  `startDate = 2025-09-01`
  `endDate = 2025-09-15`
  `daysOfWeek = [2, 4]` *(Tuesdays and Thursdays)*

* **Output:**
  `[2025-09-02, 2025-09-04, 2025-09-09, 2025-09-11]`

**Example 2:**

* **Input:**
  `startDate = 2025-09-01`
  `endDate = 2025-09-10`
  `daysOfWeek = [1, 7]` *(Mondays and Sundays)*

* **Output:**
  `[2025-09-01, 2025-09-07, 2025-09-08]`

> **💡 Tip**
> - Because the C# `DayOfWeek` enum defaults to `0 = Sunday`, you will need to write a small logic or mapping to align the user's `1-7` input with the internal C# representation. 

---

### 🔥 Challenge - Father's Day

`DateTime CalculateFathersDay(int year)`

* Returns the date of **Father's Day in Brazil** for the given year.
* Father's Day **always falls on the second Sunday of August**.

**Example:**

* **Input:**
  `year = 2023`

* **Output:**
  `2023-08-13`