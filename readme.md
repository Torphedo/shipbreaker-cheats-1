# Shipbreaker Cheats

This repo contains a mod for Hardspace: Shipbreaker that re-enables many debug functions, and adds some new cheats. The mod is now using BepInEx, but there are still a few issues to fix.

### Known Issues
- None of the keybinds are implemented

## Installation
Installation Steps:
- Download the latest [BepInEx release](https://github.com/BepInEx/BepInEx/releases/tag/v5.4.19). For a 64-bit Windows machine, download the `x64` build. For a Linux machine, download the `unix` build.
- Extract the zip file, so that `changelog.txt` is in the same folder as `Shipbreaker.exe`.
- Open the `BepInEx` folder, and create a new folder named `plugins`.
- Go to the [Releases](https://github.com/Torphedo/shipbreaker-cheats-1/releases) tab of this repo, then download `shipbreaker-cheats.dll` and place it in the `plugins` folder you made.
- Download `config.ini`, and place it in the same folder as `Shipbreaker.exe`.
- Run the game.

To change cheat settings, open `config.ini` and change the options.

## Building
To build a DLL of the mod yourself, make a new folder next to `shipbreaker-cheats.csproj` named `externals`. Copy the following DLLs from the BepInEx release, and from `[Shipbreaker folder]/Shipbreaker_Data/Managed`:

```
0Harmony.dll
BBI.Unity.Game.dll
BepInEx.dll
BepInEx.Harmony.dll
Carbon.Core.Unity.dll
InControl.dll
UnityEngine.CoreModule.dll
UnityEngine.dll
UnityEngine.PhysicsModule.dll
Unity.Entities.dll
```

After copying all of these DLLs, open the project in your IDE and build it.
Assuming you have BepInEx installed, place the DLL in the `plugins` folder and run the game.
