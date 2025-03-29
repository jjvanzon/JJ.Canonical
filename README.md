JJ.Canonical 
============

Internal infrastructure. Shared data types used across JJ projects.
Legacy version updated to newer .NET.

A __canonical model__ is an interesting design pattern in software development for exchanging data between multiple systems, that have overlap in functionality.

The concept of a canonical model is also describred in [JJ's Reference Architecture](https://jjvanzon.github.io/JJs-Reference-Architecture/) under [Service Oriented Architecture](https://jjvanzon.github.io/JJs-Reference-Architecture/service-oriented-architecture.html). 

This canonical model is a bit more minimal than others:
It only contains successful flags and validation messages and combinations of ID's and names.

But at least it gets to combine data from `JJ.Framework.Validation` and `JJ.Framework.Business` to a single set of models to send it through multiple layers of the architecture.