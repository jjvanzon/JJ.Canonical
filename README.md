JJ.Canonical 
============

Internal infrastructure.  

Shared data types used across JJ projects.  
Legacy version updated to newer .NET.

[Canonical models](https://jjvanzon.github.io/JJs-Reference-Architecture/service-oriented-architecture.html#canonical-model) are an interesting design pattern for exchanging data between multiple systems, that overlap in functionality. [JJ's Software Architecture](https://jjvanzon.github.io/JJs-Reference-Architecture/) describes the concept of [canonical models](https://jjvanzon.github.io/JJs-Reference-Architecture/service-oriented-architecture.html#canonical-model) under [Service Oriented Architecture](https://jjvanzon.github.io/JJs-Reference-Architecture/service-oriented-architecture.html#). 

This [canonical model](https://jjvanzon.github.io/JJs-Reference-Architecture/service-oriented-architecture.html#canonical-model) is a bit more minimal than others: It only contains successful flags, validation messages and ID and Name combos. But at least it gets to combine data from `JJ.Framework.Validation` and `JJ.Framework.Business` to a single set of models to send it through multiple layers of the architecture.