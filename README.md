# Yuxi-3D-Unity-BallRunGameAdvanced

## Overview

**Yuxi-3D-Unity-BallRunGameAdvanced** builds upon the foundation of **Yuxi-3D-Unity-BallRunGame** by introducing more complex gameplay mechanics, improved controls, and enhanced visuals. This advanced version features more sophisticated scripts for player movement, camera control, UI interaction, and obstacle management. The result is a richer, more dynamic, and more engaging 3D ball-rolling experience.

## Key Differences from the Original

- **Enhanced Player Control (PlayerControl.cs)**:  
  Compared to the basic version’s simple movement logic, this advanced version provides more precise and responsive control over the rolling ball, delivering smoother motion and better collision feedback.
  
- **Dedicated Camera Control (CameraControl.cs)**:  
  A separate camera control script offers improved camera tracking and angles, ensuring a clearer and more fluid in-game view.
  
- **Advanced Obstacle Management (BarrierControl.cs / DestroyBarriers.cs / WallControl.cs)**:  
  In addition to basic barriers, the advanced version introduces scripts for generating, updating, moving, and destroying obstacles, creating a more varied and challenging level design.
  
- **UI Interaction Improvements (UIControl.cs)**:  
  New UI control scripts enable richer user interface elements—such as score displays, timers, and on-screen prompts—providing more feedback and immersion.
  
- **Improved Level Flow (Yuxi-3D-BallRunGameAdvance.exe)**:  
  The provided executable offers a balanced difficulty curve, smoother progression, and more intuitive player feedback, resulting in a more enjoyable and polished experience.

## Project Structure

- **Scripts**
  - `PlayerControl.cs`: Advanced player movement and collision handling.
  - `CameraControl.cs`: Smooth and responsive camera follow logic.
  - `BarrierControl.cs`: Creation, movement, and management of dynamic obstacles.
  - `DestroyBarriers.cs`: Logic for removing obstacles to maintain level flow.
  - `WallControl.cs`: Control logic for walls and other stationary objects.
  - `UIControl.cs`: Handles UI elements and updates during gameplay.

- **Executable**
  - `Yuxi-3D-BallRunGameAdvance.exe`: The built version to experience the advanced features firsthand.

## Getting Started

1. **Clone the Repository**  
   ```bash
   git clone https://github.com/yourusername/Yuxi-3D-Unity-BallRunGameAdvanced.git
2. **Open in Unity**
Open Unity Hub and select the `Yuxi-3D-BallRunGameAdvance.exe` folder as the project.
3. **Run the Game in the Editor**
- Open the main scene.
- Press the Play button in the Unity Editor.
4. **Build the Game**
- Go to `File > Build Settings...`.
- Add the main scene to the build list.
- Choose a target platform and click "Build" or "Build and Run".

## Contributing
1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Commit and push your changes.
4. Open a Pull Request to merge your changes into the main branch.

## License
This project is licensed under the MIT `LICENSE`.
