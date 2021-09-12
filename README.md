# ACME COMPANY MARCELO ROMERO

# Exercise
The company ACME offers their employees the flexibility to work the hours they want. They will pay for the hours worked based on the day of the week and time of day, according to the following table:

|Monday - Friday   | Saturday and Sunday  |
| ------------ | ------------ |
|  00:01 - 09:00 25 USD |  00:01 - 09:00 30 USD |
|  09:01 - 18:00 15 USD |  09:01 - 18:00 20 USD |
| 18:01 - 00:00 20 USD  |  18:01 - 00:00 25 USD |

The goal of this exercise is to calculate the total that the company has to pay an employee, based on the hours they worked and the times during which they worked. The following abbreviations will be used for entering data:

| MO   | TU   | WE   | TH   | FR   | SA   | SU   |
| ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ |
|  Monday  | Tuesday |  Wednesday   | Thursday   |  Friday  | Saturday   | Sunday   |

Input: the name of an employee and the schedule they worked, indicating the time and hours. This should be a .txt file with at least five sets of data. You can include the data from our two examples below.

Output: indicate how much the employee has to be paid
For example:

|  Case |  Case 1  | Case2   |
| ------------ | ------------ | ------------ |
|  **Input** | RENE=MO10:00-12:00,TU10:00-12:00,TH01:00-03:00,SA14:00-18:00,SU20:00-21:00  | ASTRID=MO10:00-12:00,TH12:00-14:00,SU20:00-21:00  |
|   **Output** |The amount to pay RENE is: 215 USD  |  he amount to pay ASTRID is: 85 USD|


# Architecture
The architecture used was: Component-based architecture, having the following classes: 
ConnectionFile
Person
Schedule
Program

# Approach and Methodoloy

The solution was made by separating the different functionalities into components based on the problem. Having the **ConnectionFile class** which has two functions, one to read the file "prueba.txt" and another to close the file.

The **class Person** which contains several variables to store the schedules of the regular work week and weekends. In addition to methods such as **SetName**, **SetHoursWorked** which sets the value of the variables mentioned above. And the **SalaryToPay** function which calculates the value of the salary entered.

The **Schedule class** which has two arrays containing the regular weekdays and weekends. A **SeparateSchedule** function which is used to go through each value entered and separate: the day, the start and end times separately. And to make calls to other functions.

The **DayRestriction** function identifies if a valid day has been entered, this function is used in the** IdentifyDay** function which will tell if it is a regular weekday or not.

The **HourControl** function which is the schedule restriction and is used in the **HourException** function in which other validations are performed. In turn this function is used by the **HoursCounter** function which counts the total hours worked.

The **HoursSplitter** function which separates the hours in an array and identifies whether it is morning, afternoon or evening.

The **Program class** is in charge of obtaining the .txt file and going through it line by line, separating the name of the string received and displaying the message with the total value to be paid for each worker. 

# How to Run the Program.
1. First download the **"prueba.txt"** file and the **"ioetSolutionMR.rar"** file.

1. Once downloaded, the **"prueba.txt"** file should be placed in the** root of the local disk C** for later use.

1. Unzip the file** "ioetSolutionMR.rar"** which will contain an .exe file.

1. Execute the **.exe** file and the solution will appear.

