🧱 JJ.Canonical 
===============

<h2>📔 Contents</h2>

- [🏛 Architecture](#-architecture)
- [🏗️ Dev Env](#️-dev-env)
- [🚀 Deployment](#-deployment)

🏛 Architecture
----------------

A *canonical model* can be an interesting design pattern in software development for exchanging data between multiple systems, that have overlap in functionality.

The concept of a canonical model is also describred in JJ's Reference Architecture under [Service Oriented Architecture](https://jjvanzon.github.io/JJs-Reference-Architecture/service-oriented-architecture.html). 

This canonical model is a bit more minimal than others:
It only contains successful flags and validation messages and combinations of ID's and names.

But at least it gets to combine data from `JJ.Framework.Validation` and `JJ.Framework.Business` to a single set of models to send it through multiple layers of the architecture.


🏗️ Dev Env
-----------

Visual Studio Community 2019 or 2022 may be needed to develop this project, which can be downloaded for free elsewhere.


🚀 Deployment
--------------

- `JJ.Canonical` packages can be found right next to the `JJ.Framework` packages in `JJs-Pre-Release-Package-Feed`.
- They are deployed there with `Azure Pipelines`. There is limited access to the deployment buttons.
