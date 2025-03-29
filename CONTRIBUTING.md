Contributing to JJ.Canonical
============================

Legacy
------

This project is developed under special "legacy" constraints that affect versioning, branching, and framework targeting. It's a bit unconventional and needs a more detailed explanation than usual.

### Legacy Branching

- The original `main` branch is now called `legacy`.
- The new `main` branch branches off from an older point in that `legacy` history.
- Why the throwback? We're "replaying" the past to unearth hidden gems that never saw the light of day. This lets us retroactively release not just libraries but entire applications otherwise lost.
- __The `legacy` branch shall not be deleted! The `legacy` shall remain!__

### Legacy Deployments


- Around `2018`, about `15` projects were released from `legacy` to `NuGet` for `.NET 4.6.1`, compatible with the now-retired Mono compiler.
- Now, new deployments use `.NET 9` at their core (with `.NET Standard` for compatibility), and we push updated legacy versions incrementally to `NuGet.org`.

### Legacy Versioning


- Code from the legacy branch compiled under .NET 9 begins with a `0`, e.g. `0.250.1053`.
- That leading `0` signals it's essentially a "prequel" to the versions already in the `1.5.x` range on `NuGet`.

The `.Core`-suffixed projects are released with versions in the range of `1.8.x`, signaling the continuation of the `legacy` ones versioned e.g. `1.5.x`.

### Namespaces

Here's our naming scheme to juggle both old and new:

```
JJ.Framework.Configuration
JJ.Framework.Configuration.Net48
JJ.Framework.Configuration.Core
```

- Suffix-free (e.g. `JJ.Framework.Configuration`): Directly pulled from the `legacy` branch, now upgraded for `.NET 9` and `.NET Standard`.
- `.Net48` (e.g. `JJ.Framework.Configuration.Net48`): The same code, compiled for `.NET Framework 4.8` - so older systems aren't left behind.
- `.Core` (e.g. `JJ.Framework.Configuration.Core`): Either brand-new development or code copied from the __latest__ `legacy` code. This way, we don't stifle innovation while we're working with legacy code.

### Legacy Immutability

Projects without a suffix - like `JJ.Framework.Configuration` - are to remain mostly untouched, aside from absolutely necessary fixes. If we tweak them too much, future merges from `legacy` could devolve into painful merge conflicts. So, the unwritten rule: __keep changes minimal__ to preserve easy integration of subsequent `legacy` pulls.

### New Extensions

`.Core`-suffixed projects can evolve freely. We don't want to halt new development just because our main code hails from the past. This is where all new features or functionality that never existed in `legacy` can be added.

### Copies from "New"

`.Core` may also contain code cherry-picked from the newest commits in the `legacy` branch. We started our new `main` from an older snapshot, yet there's valuable stuff in later commits. By incorporating that into `.Core`, we get all the sweet stuff out there as new.

### Conclusion

Although these rules may feel restrictive, they help us continue to pull updates from our `legacy` history, and still modernize each project. The `legacy` shall remain, but new developments can thrive right alongside it!

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
