# RaymapGame

Important: This is an extension to Raymap (<https://github.com/byvar/raymap/>) and cannot run without it.

## How to use

1. Setup Raymap repo (link above).
2. Drag the content of the RaymapGame repo into the Raymap repo folder.
3. Open the Unity Project.
4. Open the MapViewer scene.
5. Add the RaymapGame.prefab to the scene.

## Changing maps ingame

RaymapGame supports switching ingame! The following call will clear all caches for Raymap + RaymapGame and let you switch to Learn_10.
```Management.ChangeMap("Learn_10")```
