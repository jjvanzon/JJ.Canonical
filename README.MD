JJ.Canonical
============

A canonical model can be an interesting design pattern, when exchanging data between multiple systems, that overlap in functionality.

`JJ.Canonical` applies this concept to the `JJ` projects. Though there is not a whole lot of data exchange between these systems, at least multiple systems' data can be converted to a set of common types.

The idea is to keep canonical models pure data, no logic. That way the data can be sent over a wire and exchanged between systems without a whole lot of surprises. The concept of a canonical model is also describred in [JJ's Reference Architecture](https://github.com/jjvanzon/JJs-Reference-Architecture) under [Service Architecture](https://github.com/jjvanzon/JJs-Reference-Architecture/blob/master/Service%20Architecture.docx). It can make exchanging data between systems more efficient with less code for data conversions as you add more systems to the so called *Enterprise Service Bus (ESB)*. The canonical model would be one component of an ESB.

Usually a canonical model may contain a whole lot more data types. `JJ.Canonical` only exchanges Success flags and validation messages and combinations of ID's and Names. So that is quite a lot more minimal than other ESB's. But at least it gets to combine data from JJ.Framework.Validation and JJ.Framework.Business, and possibly of other sources to a single set of models.

`JJ.Canonical.Business` holds the code for converting between the disparate systems' models and types.

`JJ.Canonical` used to be copied between multiple projects, so it seemed to make sense to move it to a separate project and share the same code amongst the other projects.