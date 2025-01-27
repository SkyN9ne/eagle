This is the Eagle 1.0 beta distribution.

Contents
--------

    1. Introduction
    2. Documentation
    3. Compiling & Installing Eagle

## Introduction
---------------

Eagle (Extensible Adaptable Generalized Logic Engine) is an implementation of
the Tcl scripting language for the Common Language Runtime (CLR).  It is
written completely in C#.  Superficially, it is similar to Jacl; however, it
was written from scratch based on the design and implementation of Tcl 8.4.  It
provides most of the functionality of the Tcl 8.4 interpreter while borrowing
selected features from Tcl 8.5 and the upcoming Tcl 8.6 in addition to adding
entirely new features.

Eagle is maintained, enhanced, and distributed freely by the Eagle community
(which may have some degree of cross-membership with the Tcl community).  The
home for the Eagle sources and the bug/patch database is:

[https://eagle.to/cgi-bin/eagle]

with the Eagle web site hosted at:

    https://eagle.to/

Eagle is a freely available open source package.  You can do virtually anything
you like with it, such as modifying it, redistributing it, and selling it
either in whole or in part.  See the file "```license.terms```" for complete
information.

## Documentation
----------------

The documentation for Tcl 8.4 script commands and syntax largely applies to
Eagle as well.  Additional documentation is a work in progress.

This includes:

A. The Tcl commands missing from Eagle.

B. The differences between Tcl and Eagle commands, where applicable.
    
C. The Eagle commands that have no Tcl equivalent.
    
D. The managed integration and extensibility APIs.

## Compiling and Installing Eagle
---------------------------------

Prior to compiling and running Eagle, you must run the provided Strong Name
Verification Skipping Tool (i.e. ```Library\Tools\strongName.bat``` or
```Library\Tools\data\strongName*.reg```).  

This is necessary because [for security
reasons] the official strong name signing private keys are not part of the
public source distribution.  Alternatively, you may choose to sign the
assemblies with the strong name signing key of your choice.

The sources may be built from inside the Microsoft Visual Studio 2005 (or
higher) integrated development environment.  Alternatively, they may be built
using the Microsoft .NET Framework Version 2.0 RTM (or higher) command line
build environment.

To build for the Windows operating system, use the following command:

    MSBuild Eagle.sln /t:Rebuild

To build for the Unix operating system, use the following command:

    MSBuild Eagle.sln /t:Rebuild /p:EagleWindows=false /p:EagleUnix=true

To build and run the test suite, use the following command:

    MSBuild Eagle.sln /t:Rebuild /p:EagleRunTests=true

There are a variety of other compile time options that may be specified when
building from the command line.  For example, to disable features which are
known not to work correctly in Mono 2.0, add ```/p:EagleMono=true``` to either of
the command lines above.  Please refer to the file ```Eagle.Settings.targets``` for
more information.
