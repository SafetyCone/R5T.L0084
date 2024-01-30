# R5T.L0084
Git library.


## How this librar works.

This library uses the net6.0 target framework platform. It uses net6.0 (instead of the default netstandard2.1) because it depends on LibGit2Sharp, and the latest version of LibGit2Sharp uses net6.0.

Functionality waterfall:

* R5T.L0084.F001 - Strictly-framework (net6.0) LibGit2Sharp-based Git functionality library. Allowed dependencies: R5T.L0072 (strictly-framwork library for net6.0), and R5T.L0083.F001 (the strictly-framework LibGit2Sharp functionality library).