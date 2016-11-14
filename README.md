# Back End - C#/.NET - Alphabits

Simple console application to get comfortable with C#. Specifications listed below.

==============================

- Downloading Project
    - [Installation](#installation)
    - [To Run](#torun)
- Specifications and Project Information
    - [Languages] (#languages)
    - [Tools] (#tools)
    - [Specifications] (#specifications)
    - [Contributors] (#contributors)

==============================

## Downloading Project

### Installation

Clone the repository from GitHub:

`git clone https://github.com/mattbruton/NSS_Alphabits.git`

Navigate to the project from the directory it was cloned into:

`cd NSS_Alphabits/`

### To Run

Open the solution file in Visual Studio and start the program.

## Specs and Project Information

### Languages

1.C#

### Tools / Frameworks

1. Visual Studio 2015

==============================
### Specifications
==============================
Use visual studio and C# to build a console app where the user is challenged to enter all the letters of the alphabet, one at a time, without repeating any, and without typing any non-letter characters.

## Behavior

1. After each successful input,  display the number of letters already entered.
1. After each unsuccessful input, display a helpful message explaining why the input was unsuccessful (e.g. 'not a letter', 'duplicate letter', etc.)
1. Upon completing the task (entering in all 26 letters), the user should receive some gratifying message like "Congratulations"

## Technical requirements

1. Use one Class in addition to the program file.
1. Your class should include a constructor function, an "addChar" method, and a "listLength" method.
1. Keep your user's successfully input letters as a list of characters
1. Use the String.Format method to craft your messages to users
