🧱 JJ.Canonical 
===============

<h2>📔 Contents</h2>

- [🏛 Architecture](#-architecture)
- [⚙ Dev Env](#-dev-env)
    - [👨‍💻 Visual Studio](#-visual-studio)
    - [📦 JJ.Framework](#-jjframework)
- [🚀 Deployment](#-deployment)
- [🕘 Checking Out Old Commits](#-checking-out-old-commits)

🏛 Architecture
----------------

A *canonical model* can be an interesting design pattern in software development for exchanging data between multiple systems, that have overlap in functionality.

The concept of a canonical model is also describred in JJ's Reference Architecture under [Service Oriented Architecture](https://github.com/jjvanzon/JJs-Reference-Architecture/blob/master/service-oriented-architecture.md). 

This canonical model is a bit more minimal than others:
It only contains successful flags and validation messages and combinations of ID's and names.

But at least it gets to combine data from `JJ.Framework.Validation` and `JJ.Framework.Business`  to a single set of models to send it through multiple layers of the architecture.

`JJ.Canonical.Data` holds the model classes.

`JJ.Canonical.Business` holds the code for converting between the disparate systems' models and types.

⚙ Dev Env
-----------

Here you may find some pointers how to set up a developent environment to build `JJ.Canonical` projects.

### 👨‍💻 Visual Studio

- Visual Studio Community 2019 or 2022 may be needed, which can be downloaded for free elsewhere.

### 📦 JJ.Framework

- Pre-release versions of *JJ.Framework* components could be used.
- They may require configuring *NuGet* to connect to an additional package source.
- The following info might be useful for that:
- Name: JJs-Pre-Release-Package-Feed
- Source: https://pkgs.dev.azure.com/jjvanzon/1de16010-421a-41a5-90f1-86e9513f2c5b/_packaging/JJs-Pre-Release-Package-Feed/nuget/v3/index.json

🚀 Deployment
--------------

- `JJ.Data.Canonical` and `JJ.Business.Canonical` can be found right next to the `JJ.Framework` packages in `JJs-Pre-Release-Package-Feed`.
- They are deployed there with Azure Pipelines. There is limited access to the deployment buttons.

🕘 Checking Out Old Commits
----------------------------

`JJ.Canonical` was once part of a larger code base. It was extracted to become a new git repository with history in tact. Changes to `JJ.Canonical` usually served some other purpose in some other project for some other app. This may give checking out older history items some quirks. The following may only be relevant when getting older commits (from before December 2022).

- Commit messages:
    - Descriptions may mention projects not part of this repo.
- No solution file in the first commits.
    - `JJ.Canonical` projects may first only have been referenced by the solution of the app it was made for. Those solution file are not part of the history here, so the first commits have no solution file.
- References to other non-existent projects:
    - To fix this, try referencing the NuGet version of these dependencies.
- Broken references to `JJ.Framework`:
    - `JJ.Framework` projects are no longer in the same code base.
    - You could try referencing the NuGet version of these dependencies.
    - But another solution may be to clone the [JJ.Framework](https://github.com/jjvanzon/JJ.Framework) repository and put the `JJ.Framework` folder right next to the `JJ.Canonical` folder. This may fix the broken links.
    - But sometimes the paths are still incorrect and may need to be modified (with Notepad)?
    - But then you could use a specific commit from `JJ.Framework`'s history.
