# MiniMapGame

A 2D maze game built in Unity. Move with the arrow keys; a mini-map in the
top-right corner shows your position in the whole maze.

**Play it here:** (https://adisagi.itch.io/the-maze)



## Camera size and screen rotation
In an orthographic camera, `orthographicSize` is half of the visible world
height, so visible width = 2 * size * aspect. When the device is rotated to
portrait the aspect ratio drops, the visible width shrinks and objects look
bigger. `CameraWidthFitter` recalculates the size every frame so the visible
width stays constant and objects keep the same relative size.

## Team
sagu rahat
adi platzky
