# Shipbreaker Cheats

This repo contains a mod for Hardspace: Shipbreaker that re-enables many debug functions, and adds some new cheats. The mod has finally been ported to BepInEx, but there are still some outstanding issues to fix.

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
```

After copying all of these DLL, open the project in your IDE and build it.