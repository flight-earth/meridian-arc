# Meridian Arc

Geodesy problems and their solutions.

![dotnet-win](https://github.com/BlockScope/meridian-arc/workflows/dotnet-win/badge.svg)
![dotnet-ubuntu](https://github.com/BlockScope/meridian-arc/workflows/dotnet-ubuntu/badge.svg)
![dotnet-mac](https://github.com/BlockScope/meridian-arc/workflows/dotnet-mac/badge.svg)

## Building

```
> dotnet --version
3.1.202
> donet clean
> dotnet build
```

## Testing

```
> dotnet test units
Test run for .../meridian-arc/units/bin/Debug/netcoreapp3.0/flight-units.dll(.NETCoreApp,Version=v3.0)
Microsoft (R) Test Execution Command Line Tool Version 16.5.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

A total of 1 test files matched the specified pattern.

Test Run Successful.
Total tests: 64
     Passed: 64

> dotnet test earth
Test run for .../meridian-arc/earth/bin/Debug/netcoreapp3.0/flight-earth.dll(.NETCoreApp,Version=v3.0)
Microsoft (R) Test Execution Command Line Tool Version 16.5.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

A total of 1 test files matched the specified pattern.

Test Run Successful.
Total tests: 202
     Passed: 202
```

## Packaging

```
> dotnet tool restore
Tool 'paket' (version '5.226.0') was restored. Available commands: paket

Restore was successful.

> dotnet paket pack paket-pack
Paket version 5.226.0
Packaging: .../meridian-arc/paket.template
Wrote: .../meridian-arc/paket-pack/meridian-arc.0.1.3.nupkg
```

## License

```
Copyright © Phil de Joux 2017-2019
Copyright © Block Scope Limited 2017-2019
```

This software is subject to the terms of the Mozilla Public License, v2.0. If
a copy of the MPL was not distributed with this file, you can obtain one at
http://mozilla.org/MPL/2.0/.
