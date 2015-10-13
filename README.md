# AtomLauncher
## Windows Explorer-friendly launcher for Atom

AtomLauncher is a simple wrapper for the `atom.cmd` script shipped with the [Atom](https://atom.io/) editor.

As shipped, Atom cannot nicely be assigned to file types as the default program to open the file for several reasons:

* The executable is in a version-specific folder and so moved with each release.
* Assigning to the `atom.cmd` script gives an unknown/generic file icon which looks horrible.
* Launching files with the `atom.cmd` script flashes up a console window (albeit briefly).

See [Atom Issue #4893](https://github.com/atom/atom/issues/4893)

The current version assumes that `atom.cmd` is on your PATH.

## Future plan

* Add instructions to release.
* Make the PATH configurable, possibly with an INI file.
* Add installer.
* Look at having a document icon in place of the full Atom icon for files.
* Look at installing AtomLauncher as a suggested program in the "Open with..." dialog.
* Look at optionally setting as default for some file types from installer.
