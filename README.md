# AtomLauncher
## Windows Explorer-friendly launcher for Atom

AtomLauncher is a simple wrapper for the `atom.cmd` script shipped with the [Atom](https://atom.io/) editor.

As shipped, Atom cannot nicely be assigned to file types as the default program to open the file for several reasons:

* The executable is in a version-specific folder and so moved with each release.
* Assigning to the `atom.cmd` script gives an unknown/generic file icon which looks horrible.
* Launching files with the `atom.cmd` script flashes up a console window (albeit briefly).

See [Atom Issue #4893](https://github.com/atom/atom/issues/4893)

The current version assumes that `atom.cmd` is on your PATH.

## Manual installation

Currently the launcher must be installed manually by the user:

1. Ensure `atom.cmd` is on your PATH (type `atom` into a Command Prompt window and see if Atom launches if unsure).
2. Download the latest AtomLauncher release from the [releases page](https://github.com/Xcodo/atom-launcher/releases).
3. Extract the files to any location on your computer (for instance `%LOCALAPPDATA%\AtomLauncher`).
4. In Windows Explorer, right-click on a file type you wish to open with Atom and select Open with>Choose default program.
  * ![Open with example](http://i.imgur.com/etbHyIb.png)
5. Click the Browse button and navigate to where you placed AtomLauncher.
6. Double-click `AtomLauncher.exe` to select the program.
7. Click Ok in the Open with dialog to set AtomLauncher as the default program for this file type in future.
8. Atom should open and display the file.
9. Repeat for each file type required.

## Future plan

- [x] Add instructions to release.
- [ ] Make the PATH configurable, possibly with an INI file.
- [ ] Add installer.
- [ ] Look at having a document icon in place of the full Atom icon for files.
- [ ] Look at installing AtomLauncher as a suggested program in the "Open with..." dialog.
- [ ] Look at optionally setting as default for some file types from installer.
