JJ.Canonical 
============

Internal infrastructure.  

Shared data types used across JJ projects.  
Legacy version, updated to target newer .NET.

[Canonical models](https://jjvanzon.github.io/JJs-Reference-Architecture/service-oriented-architecture.html#canonical-model) are a design pattern for exchanging data between systems with overlapping functionality. [JJ's Software Architecture](https://jjvanzon.github.io/JJs-Reference-Architecture/) describes the concept under [Service Oriented Architecture](https://jjvanzon.github.io/JJs-Reference-Architecture/service-oriented-architecture.html#).

This particular canonical model is a bit minimal. It includes only:

- Success flags  
- Validation messages  
- ID and Name combos

But at least it gets to combine data from `JJ.Framework.Validation` and [JJ.Framework.Business](https://www.nuget.org/packages/JJ.Framework.Business) to a single set of models to send it through multiple layers of the architecture.