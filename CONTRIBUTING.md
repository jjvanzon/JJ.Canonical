JJ.Canonical - Contributing
===========================

*JJ van Zon, 2025*

Legacy
------

This project is now developed under specific `legacy` constraints that influence `versioning`, `branching` scenarios, and framework `targeting`. This all requires a little more explanation than it otherwise would.

### Legacy Branching

The original `main` branch is now called `legacy`. The new `main` branch is branched off of an old point in the `legacy` history. History is being replayed as it were. There are hidden gems in that history that never got to see the light of day. Replaying it, gets us to release retro-actively, not only for the libraries in this repo, but for whole applications. The `legacy` branch shall not be deleted! The `legacy` shall remain!

### Legacy Deployments

Originally there were about `15` projects released from `legacy` to `NuGet` around `2018`. Those were `.NET 4.6.1`, compatible with the `Mono` compiler, a platform now retired.

New deployments are done with `.NET 9` as the back-bone, but also targeting `.NET Standard` for compatibility. Fixed-up legacy versions, are released successively to `NuGet.org`.


### Legacy Versioning

Code released for `.NET 9`, but coming out of the legacy branch, would be released under version numbers, starting with a `0`, like: `0.250.1053`. This is to signal it is the "prequal" to the versions of it on `NuGet` that are already around the range of `1.5.1392`.

### Namespaces

There is a namespacing scheme as follows for this legacy situation:

```
JJ.Framework.Configuration
JJ.Framework.Configuration.Net48
JJ.Framework.Configuration.Core
```

The namespace without a suffix here is code that was pulled from the `legacy` branch. Those projects are upgraded to `.NET 9` also targeting `.NET Standard` for compatibility.

There are also specific `.Net48` projects. These contain the same code as the main project, but then compiled for `.NET Framework 4.8`. Those are there, to link to from systems that are not on the map for a `.NET` upgrade.

The `.Core` suffixed project contain either new code developed independently of the `legacy` OR code copied from the __newest__ version of `legacy` branch. 

### Legacy Immutability

Suffix-free projects, like `JJ.Framework.Configuration` are supposed to remain untouched, required fixes excluded. The code pulled from `legacy` history can't be changed much, or subsequent merges from `legacy` would cause a lot of merge conflicts that would be a hassle to reconcile. It's the unwritten rule that you're not supposed to touch those (much), even though there's nothing stopping you from doing so. Only the utmost necessary fixes are to be applied, as locally as possible, to make a future pull from legacy history possible with minimal friction.

### New Extensions

As mentioned, project suffixed with `.Core` can contain extensions that not yet existed in the suffix-free code. So we don't stop new developments just because the main code is a code freeze from long ago.

### Copies from New

The projects suffixed `.Core` also contain code copies from the latest version from the `legacy` branch. See, code was pulled from an old commit in the `legacy` branch, and sometimes there's good stuff in the newest commit in the `legacy` branch. And we don't want to stifle development just because we've created this `legacy` situation, therefor these code copies and extensions are.

### Conclusion

Though these are quite a bit of constraints they all make sure that we can do these legacy pull, history replay, revamp projects.


🏗️ Dev Env
-----------

Visual Studio Community 2019 or 2022 may be needed to develop this project, which can be downloaded for free from Microsoft.


🚀 Deployment
--------------

- Pipelines are present in `Azure Pipelines` with limited access to the deployment buttons.
- Eventually they go on `NuGet`, but there are stages before that.
- `JJ.Canonical` packages can be found on NuGet
- Pre-release on in `JJs-Pre-Release-Package-Feed`
- And `JJs-Dev-Package-Feed` for high paced development updates.
