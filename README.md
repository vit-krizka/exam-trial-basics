# TRIAL EXAM: Programming Basics

### Getting Started

 - Fork this repository under your own account
 - Clone the forked repository to your computer
 - Commit your progress frequently and with descriptive commit messages
 - All your answers and solutions must go in this repository
 - Please create directories for each of the tasks except the question time
 - Don't forget to answer the questions

### What can I use?

- You can use any resource online, but **please work individually**
- **Don't just copy-paste** your answers and solutions, use your own words instead
- **Don't push your work** to GitHub until your mentor announces that the time is up


# Tasks

## Symmetric matrix

```
Create a function named `isSymmetric` 
that takes an n×n integer matrix (two dimensional array/list) as parameter
and returns true, if that matrix is symmetric
(diagonally from top-left to bottom-right) or false if it is not.
```

Example 1:

```
[
  [1, 0, 1]
  [0, 2, 2]
  [1, 2, 5]
]
```

Output:

```
true
```

Example 2:

```
[
  [7, 7, 7]
  [6, 5, 7]
  [1, 2, 1]
]
```

Output:

```
false
```

## Most Common Character

```
Write a function that takes a filename as a parameter.
Return the most common character of the file's content.
If the file doesn't exists return a string:
"File does not exists!"
```

Example

[Example file can be found here](./countchar.txt)

Output

```
e
```

## Pirates

``` 
Write a program which can store pirates in a ship.

 Pirate:
 
 - A pirate has name, gold, health point which is default 10. A pirate might be a captain and maybe has wooden leg.
 - You must create the following methods:

 - if a pirate is a captain:
    - `work()` which increase the gold by 10, and decrease the HP by 5.
    - `party()` which increase the HP by 10.
 - if not a captain:
    - `work()` which increase the gold by one, and decrease the HP by one.
    - `party()` which increase the HP by one.

 - if the pirate has wooden leg, then the string must look like this:
    - Hello I'm Jack. I have wooden leg, and 20 golds.
 -  If not:
    - Hello I'm Jack. I still have my real leg, and 20 golds. 
  
 Ship:

 - It should have a list of pirates.
 - You must be able to add new pirates to the ship. It must have only one captain!
 - You must create the following methods:
 - `getPoorPirates()` which returns a list of names containing the pirates that
    - has wooden leg and have less than 15 golds
 - `getGolds()` which returns the golds of all the pirates have.
 - `lastDayOnTheShip()` which calls the pirates `party()`.
 - `preparationForBattle()` which calls 
    - the pirates `work()` method five times
    - then the ships `lastDayOnTheShip()` method.

```

## Question time!

### How can you generate a random number?

*type your answer here*

### What is a ternary operator? How does it work?

*type your answer here*
