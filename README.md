# Word Counter

#### _"We count words in a sentence." - 07/26/19_

#### _By **Uriel Gonzalez**_

## Description

A C# program with 2 initial inputs that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. It should check for full word matches only. (For instance, if provided the word "house" and sentence "My housemate is crazy." the first five letters of the word housemate would not be counted.)

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **The program determines if the user input is valid or not. [word; Sentence]** | car; That is my car. | Valid |
| **The program determines if the user input is valid or not when there is a space inside the word.** | ca r | Invalid |
| **The program determines if the user input is valid or not where there are special characters.** | car! | Invalid |
| **The program determines if the user input is valid or not if a word was never entered.** |  | Invalid |
| **The program matches full words only.** | car; cart | 0 |
| **The program counts how many matching words are in one sentence, no punctuation.** | car; I will sell my car and then buy another car because I love having a car." | 3 |
| **The program counts how many matching words are in one sentence with punctuation.** | car; Today I have to wash my car, my mom's car, and also my sister's car. | 3 |



## Setup/Installation Requirements

1. Clone this repository:
    ```
    $ git clone https://github.com/Ugonz86/WordCounter.git
    ```
2. Run the application
    ```
    $ dotnet run
    ```

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C# / .NET

## Support and contact details

_Please contact Uriel Gonzalez - ugonzalez86@gmail.com with questions and comments._

### License

*GNU GPLv3*

Copyright (c) 2019 **_Uriel Gonzalez_**
