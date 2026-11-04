Collect and Avoid

I made this game in Unity 6.6. The goal is to collect 9 coins without getting caught by the enemy. If you get caught, press **Try Again** to restartю.

Controls

- WASD - move
- Mouse - look around
- Space - jump

How to play

1. Download this repository with **Code → Download ZIP** and extract it.
2. In Unity Hub, click **Add → Add project from disk** and select the folder with `Assets`, `Packages` and `ProjectSettings`.
3. Open it with Unity `6000.6.7f1`.
4. In the Project window, open `Assets/_Recovery/0.unity` and press **Play**.

Perfomance

Stable 60 fps

Scripts

- `PlayerController`, `RigidbodyMovement` and `PlayerJump` - player movement and jumping.
- `EnemyAI` - enemy patrol and chase.
- `Coin` and `Rotate` - coin pickup and rotation.
- `ScoreLabel` - score on the screen.
- `GameManager` - win and lose screens and restart.

Assets

- Background music - https://freesound.org/people/ryusa/sounds/531175/
- Coin sound - unity free assets
- Coin model - unity free assets
- Character model - just my favorite capsule
  
Known bugs

Camera slides through the walls. EnemyAI sometimes bugs

What I learned

I learned basically everything that you see in my project, because its my first project in Unity.
