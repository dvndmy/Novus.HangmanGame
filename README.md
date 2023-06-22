# Hangman Game

This is a simple console-based Hangman game implemented in C#. The game randomly selects a word from a predefined word list and challenges the player to guess the word by entering letters one at a time. The player has a limited number of attempts to guess the word correctly.

## How to Play

1. Run the program.
2. The game will display the initial state with dashes representing the letters of the word.
3. Enter a letter and press Enter to make a guess.
4. If the guessed letter is in the word, it will be revealed in the correct position(s).
5. If the guessed letter is not in the word, the game will count it as a wrong attempt.
6. You have a maximum of 7 wrong attempts to guess the word correctly.
7. The game will continue until one of the following conditions is met:
   - The player guesses the word correctly and wins the game.
   - The player uses all the attempts and loses the game.
8. After the game ends, the program will display a message indicating whether the player won or lost.

## Customization

You can customize the word list by modifying the `wordList` variable in the code. Add or remove words as desired. The game will randomly select a word from the updated list.

## Notes

- The game only accepts single letters as guesses. If you enter multiple characters, only the first character will be considered.
- The game is case-sensitive. Make sure to enter letters in the correct case.

Enjoy playing Hangman!
