        
        AreEqual(1, idAndName.ID);
        AreEqual("My Name", idAndName.Name);


    <!-- TODO: Add more targets explicitly. (Top-level) projects cannot RUN as netstandard. See: -->
    <!-- https://www.ncrunch.net/documentation/considerations-and-constraints_netstandard-test-projects-->
    <!--<TargetFrameworks>net9.0;net8.0;netstandard2.1;netstandard2.0</TargetFrameworks>-->
    <!--<TargetFrameworks>net9.0;net8.0;net7.0;net6.0;net5.0;net48;net481;net461</TargetFrameworks>-->

JJ.Canonical contains shared data types used across JJ projects.

-----

Idea: ContentFiles for default .props

I used this in nuspec in another project:

```
    <contentFiles>
      <files include="Scripts/*.js" buildAction="Content" />
    </contentFiles>
```

But don't know the syntax in a csproj file.