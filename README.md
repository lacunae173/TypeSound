# TypeSound

Make Nintendo Switch sound while typing.
- Uses low level keyboard hook to capture key strokes.
- Tray icon and simple volume adjust UI made with Windows Forms.
- Uses SFML to play audio.

### Use
- Unzip and run TypeSound.exe to start
- Double click on tray icon to adjust volume
- Right click on tray icon to exit

### Use note
- The program might be identified as malware because it uses keyboard hook

### Compile note
To Build the project in Visual Studio
- Open TypeSound.sln in Visual Studio
- Download [SFML.Net](https://www.sfml-dev.org/download/sfml.net/)
- Copy dlls in the `extlibs` folder into target folder (`bin/Debug` or `bin/Release`)
- Rename `csfml-xxxx-2.dll` to `csfml-xxxx.dll`
- Build the project
