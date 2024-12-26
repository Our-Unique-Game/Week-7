# Character Keyboard Mover

Link to game:
https://gman17.itch.io/week-7

This Unity script allows a player to control a character using the keyboard. The character can move, jump, run, and crouch. The player's speed is displayed on the screen using a UI Text element.

## Features

- **Movement**: Use `W`, `A`, `S`, `D` keys to move the character.
- **Jump**: Press `Space` to make the character jump.
- **Run**: Hold `Left Shift` to run.
- **Crouch**: Hold `Left Ctrl` to crouch. Crouching reduces the character's speed.
- **Speed Display**: The current speed of the character is displayed on the screen.

## How It Works

1. **Input Actions**: The script uses Unity's Input System to handle keyboard inputs for movement, jumping, running, and crouching.
2. **Character Controller**: The script requires a `CharacterController` component to move the character.
3. **Camera**: The script adjusts the camera's vertical movement speed when crouching.
4. **Speed Display**: The script updates a UI Text element to display the current speed of the character.

## Setup

1. **Add the Script**: Attach the `CharacterKeyboardMover` script to your player GameObject.
2. **Character Controller**: Ensure the player GameObject has a `CharacterController` component.
3. **Camera**: Assign the main camera to the `playerCamera` field in the script.
4. **UI Text**: Create a UI Text element in your scene and assign it to the `speedText` field in the script.
