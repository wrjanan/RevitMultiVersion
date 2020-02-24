# RevitMultiVersion

This repository is meant to be the barebones format of a C# Revit Plugin code base.

The most important portions of this repository are the csproj file.

This file consist of settings which aid in handling the various versions of Revit assembly file.
The Lib folder consists of the various Revit assemblies.

This can be changed by changing the built version.
Debug-2016 references version 2016 Revit
Debug-2017 references version 2017 Revit
Debug-2018 references version 2018 Revit
Debug-2019 references version 2019 Revit
Debug-2020 references version 2020 Revit

The default version for debug & release is 2018.

The csproj file also consists of build settings which saves the built files into the selected version.


This bare bones repository consists of the basic building blocks that is necessary for building a Revit Plugin for the various versions of Revit.

Have a good day!
