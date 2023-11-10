# Apple Picker (ECS) 🍎

An exciting and challenging game where players aim to catch falling apples in baskets. Adjust the difficulty settings to make it easier or harder, depending on your mood!

## Table of Contents

- [Description](#description)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Scripts](#scripts)
- [Screenshots](#screenshots)
- [Observations](#observations)
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

- **AppleAuthoring.cs**: Serves as an authoring component for apples, defining properties such as fall speed. When attached to a GameObject, it provides the data needed to create an ECS entity representing an apple in the game.

- **AppleTreeAuthoring.cs**: Acts as an authoring component for the apple tree. It specifies parameters like movement speed, the edges of the screen for bouncing behavior, and the chance to change direction. This script helps convert the apple tree GameObject into an ECS entity with these properties.

- **BasketAuthoring.cs**: Used as an authoring component for baskets, specifying properties like movement speed. This script is responsible for converting the basket GameObject into an ECS entity, allowing the game to handle baskets in the ECS context.

- **BasketCollisionSystem.c**s: An ECS system that detects collisions of baskets with other entities, such as apples. When a collision is detected, it can trigger the destruction of apples and update game state accordingly, like reducing the number of available baskets.

- **BasketMovementSystem.cs**: This ECS system is responsible for updating the position of basket entities based on player input, such as mouse movement, allowing the player to catch falling apples with the basket.

- **RandomDirectionChangeSystem.cs**: An ECS system that periodically changes the direction of the apple tree entity's movement. It uses a random chance based on a specified probability to determine when the apple tree should change direction.

- **TreeMovementSystem.cs**: Manages the back-and-forth movement of the apple tree entity within the bounds of the game screen. It updates the tree's position each frame and reverses direction when it reaches the specified edges.

## Screenshots

**Game Performance via OOP**

![OOP Implementtaion](https://cdn.discordapp.com/attachments/1103515433862172673/1172340959053352970/OOP.jpg?ex=655ff699&is=654d8199&hm=a8e42554c7314811475e62c27c7e1fb66357bf387e0caa10e52ad3fa2d4a2f8b&)  

**Game Performance via ECS**

![ECS Implementation](https://cdn.discordapp.com/attachments/1103515433862172673/1172340967966257182/ECS.jpg?ex=655ff69b&is=654d819b&hm=0c3f0a6907fd39f9c29e7e20dab83ac6a2d4f3605bd4e1aee7ec1b4afcf9aeb2&)  

## Observations

The ECS version of Apple Picker performs better than the OOP version primarily because ECS optimizes data access patterns for the CPU, grouping similar components together in memory. This allows the game to process large numbers of entities efficiently, handling data locality and enabling better CPU cache utilization. Additionally, ECS inherently supports parallel processing, which means that the game logic for handling apples, baskets, and tree movement can be executed simultaneously across multiple CPU cores, this improves performance over the OOP version where objects are typically updated sequentially and can suffer from cache thrashing due to less optimal memory layouts.

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes.

## Credits

- **Eduardo De La Rosa**: Initial creation and development.
