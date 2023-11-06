# Apple Picker (ECS) 🍎

An exciting and challenging game where players aim to catch falling apples in baskets. Adjust the difficulty settings to make it easier or harder, depending on your mood!

## Table of Contents

- [Description](#description)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Scripts](#scripts)
- [Screenshots](#screenshots)
- [Contributing](#contributing)
- [Credits](#credits)

## Description

The game involves a tree that drops apples. The player controls a basket that moves left and right, attempting to catch these apples before they hit the ground. The game's difficulty can be adjusted to change aspects like basket size, apple drop rate, and tree movement.

## Features

- **Three Difficulty Levels**: Easy, Medium, Hard.
  - **Easy**: Larger basket, slower apples.
  - **Medium**: Standard size and speed.
  - **Hard**: Smaller basket, faster apples, and fewer baskets to start with.
- **Responsive Controls**: Use the mouse to move the basket.

## Installation

1. Ensure you have Unity installed.
2. Clone this repository.
3. Open the project in Unity.
4. Build and play!

## Usage

1. Start the game and select your preferred difficulty level.
2. Use the mouse to control the basket's movement.
3. Try to catch as many apples as you can!
4. Game over when you miss too many apples.

## Scripts

- **Apple.cs**: Handles apple behavior like falling and destroying when out of bounds.
- **AppleTree.cs**: Manages the apple tree's movement and apple dropping logic.
- **ApplePicker.cs**: Controls the overall game logic, like tracking the number of baskets and what happens when an apple is missed.
- **Basket.cs**: Manages the basket's movement and catching apples.
- **ScoreCounter.cs**: A UI component that updates and displays the current score.
- **HighScore.cs**: Tracks and displays the high score.
- **DifficultyScreen.cs**: Manages the game's difficulty setting and starts the game.

## Screenshots

**Game Performance via OOP**

**Game Performance via ECS**

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes.

## Credits

- **Eduardo De La Rosa**: Initial creation and development.
