# Nilgiri
[![Travis CI](https://img.shields.io/travis/brycekbargar/Nilgiri.svg?style=flat-square)](https://travis-ci.org/brycekbargar/Nilgiri) [![codecov.io](https://img.shields.io/codecov/c/github/codecov/Nilgiri.svg?style=flat-square)](http://codecov.io/github/brycekbargar/Nilgiri?branch=master)
[![Nuget](https://img.shields.io/nuget/vpre/Nilgiri.svg?style=flat-square)](https://www.nuget.org/packages/Nilgiri/)

Chai.js style assertions for .NET  
*nilgiri is some sort of black tea but it was the only one that started with 'n'...*

I really liked the [BDD Assertion Styles](http://chaijs.com/api/bdd/) in Chai.js when I dabbled in Node.  
Why not bring them to .NET?

### To Install ###
`dnu install Nilgiri`

### To Use ###
#### Expect ####
```
using static Nilgiri.ExpectStyle;

Expect(1).To.Equal(1);
Expect(() => Someclass.Someprop).To.Not.Equal(1);
```

#### Should ####
```
using static Nilgiri.ShouldStyle;

_(1).Should.Equal(1);
_(() => Someclass.Someprop).Should.Not.Equal(1);
```

There are complete examples of each style in various scenarios in the `Nilgiri.Tests/Examples` folder.

#### Legacy .NET Support ####
For c# < 6.0 there is no `using static` so things are a little different. This is already Deprecated(!) and just here until I can use c# 6 at work.
#### Expect ####
```
using Nilgiri.LegacyExpectStyle;

_.Expect(1).To.Equal(1);
_.Expect(() => Someclass.Someprop).To.Not.Equal(1);
```

#### Should ####
```
using Nilgiri.LegacyShouldStyle;

__._(1).Should.Equal(1);
__._(() => Someclass.Someprop).Should.Not.Equal(1);
```

### Currently Implemented ###
1. Equal
1. Not
1. Be
1. A/An
1. Ok
1. True
1. False
1. Null
1. Empty

### To Build/Test ###
```
dnu restore
dnu build Nilgiri
cd Nilgiri.Tests; dnx test
```
