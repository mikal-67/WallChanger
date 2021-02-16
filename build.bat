@ECHO off
cd src
csc Program.cs Wallpaper.cs
ren Program.exe WallChanger.exe
move wallchanger.exe ..
cd ..