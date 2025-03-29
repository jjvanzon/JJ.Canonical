JJ.Canonical - Contributing
===========================

Legacy
------

This project is developed under specific `legacy` constraints that influence __versioning__, __branching__, and framework __targeting__. This requires more explanation.

### Legacy Branching

The original `main` branch is now called `legacy`. The new `main` was branched from an earlier point in `legacy` history. History is being replayed, as it were.

There are hidden gems in that history-code that never saw the light of day. Replaying it allows us to retroactively release not just these libraries, but entire applications otherwise lost.

**The `legacy` branch shall not be deleted. The `legacy` shall remain.**

### Legacy Deployments

Around `2018`, about `15` projects were released from `legacy` to `NuGet`. These were `.NET 4.6.1` libraries, compatible with the now-retired `Mono` compiler.

New deployments use `.NET 9` as a backbone, and also target `.NET Standard` for compatibility. Fixed-up `legacy` versions are released to `NuGet.org`, step by step.

### Legacy Versioning

Code released for `.NET 9`, but pulled from the `legacy` history, would use version numbers, starting with `0`, e.g. `0.250.1053`, signaling that this code predates the `2018` releases, is the "prequal" so to say, of the versions around the range of `1.5.x`.

The `.Core`-suffixed projects are released with versions in the range of `1.8.x`, signaling the continuation of the `legacy` ones versioned e.g. `1.5.x`.

### Namespaces

There is a namespacing scheme as follows for this legacy situation:

```
JJ.Framework.Configuration
JJ.Framework.Configuration.Net48
JJ.Framework.Configuration.Core
```

The namespace without a suffix here is code directly pulled from the `legacy` branch. Those projects are upgraded to `.NET 9` also targeting `.NET Standard` for compatibility.

There are also specific `.Net48` projects. These contain the same code as the main project, but then compiled for `.NET Framework 4.8`. Those are there, to link to from systems that are not on the map for a `.NET` upgrade.

The `.Core`-suffixed projects contain either new code developed independently of the `legacy` or code copied from the __latest__ version of `legacy` branch.

More about this below.

### Legacy Immutability

Suffix-free projects, like `JJ.Framework.Configuration` are supposed to remain untouched, utmost required fixes excluded. The code pulled from `legacy` history can't be changed much, or subsequent merges from `legacy` would cause a lot of merge conflicts that would be a hassle to reconcile. It's the unwritten rule that you're not supposed to touch those (much), even though there's nothing stopping you from doing so. Only the utmost necessary fixes should be applied, as locally as possible, to keep future merges from `legacy` history possible with minimal friction.

### New Extensions

The `.Core`-suffixed projects can contain new code developed independently of the `legacy` branch. We don't stop new developments just because the main code is a code freeze from long ago. We add new things we'd like.

### Copies from New

The projects suffixed `.Core` also contain code copies from the latest version from the `legacy` branch. See, code was pulled from an old commit in the `legacy` branch, and sometimes there's good stuff in the newest commit in the `legacy` branch. And we don't want to stifle development just because we've created this `legacy` situation, therefor these code copies and extensions are put in the `.Core` projects too to get the most modern code versions in there.

### Conclusion

Though these are quite a bit of constraints they all make sure that we can do these legacy pulls, history replay, revamp projects.


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
