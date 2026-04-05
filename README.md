# FPS Game Project (CSE 528)

## Overview
This project is a simple FPS (First Person Shooter) game built in Unity.  
The player can move, aim, and shoot enemies in a small indoor level.

The game includes enemy AI movement, shooting behavior, sound effects, and basic level design.

---

## Player Controls
- WASD: Move
- Mouse: Look around
- Left Click: Shoot

---

## Enemy Design

### Enemy Visual Design
Enemies are represented using two parts:
- A **cube (base object)** which acts as the core enemy
- A **Banana Man model** attached as a visual character

The Banana Man is only used for visual representation.  
It is not an independent enemy.

### Important Mechanic (Trap Behavior)
The Banana Man is **linked to the cube enemy**.

- The cube is the **actual enemy object**
- The Banana Man is only a **visual attachment**
- When the cube is destroyed, the Banana Man disappears with it
- Shooting the Banana Man alone has **no effect**

This creates a **trap-like design**, where the visible character is not the real target.

---

## Enemy AI Behavior
Each enemy has a simple AI script:
- Moves forward continuously
- Detects obstacles using SphereCast
- Rotates randomly to avoid walls
- Detects player using raycasting
- Fires a projectile when player is detected

---

## Enemy Shooting
- Enemies shoot **fireballs**
- Fireballs move using Rigidbody velocity
- Fireballs are instantiated from a prefab

---

## Enemy Management
- Multiple enemies are placed in the scene (4 enemies)
- Each enemy works independently
- Each enemy has:
  - Wandering AI
  - Shooting logic
  - Reactive behavior (destroy on hit)

---

## Level Design
The level is a simple indoor environment:
- Walls forming rooms and corridors
- Obstacles for cover
- Multiple enemy positions for gameplay variety

---

## Sound Effects
- Shooting sound is added to the player
- AudioSource is used to play gunshot sounds

---

## Notes
- Enemy AI uses Unity physics (Raycast and SphereCast)
- Fireball uses Rigidbody for movement
- Banana Man is only decorative and linked to the cube

---

## Author
CSE 528 Student Project
