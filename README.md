# debugsourcegen

Helper to debug source generators.

This is useful when you cannot change the source code of existing generators.
You simply add the following line to yur `.csproj` file, making it the first
analyzer.

```xml
/analyzer:/Users/poupou/git/debugsourcegen/bin/Debug/netstandard2.0/debugsourcegen.dll \
```

This will print the port where the CoreCLR debugger (e.g. from VSfM) can attach
and will next break the execution to let you add additional breakpoints.
