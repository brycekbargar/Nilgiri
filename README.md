## Not in active Dev ##
Call it another abandonware project from me...  
I really wanted to learn dnx and travis ci + .net and publishing to nuget. But I really don't want to write/maintain an "enterprise" software package. [I just kind of want to make music...](http://brycekbargar.com/blog/fourier-transforms-are-hard)

So I'm no longer devving on this, though if you want to see how .net works on a mac in atom it's a reasonable example.


# Nilgiri
[![Travis CI](https://img.shields.io/travis/brycekbargar/Nilgiri.svg?style=flat-square)](https://travis-ci.org/brycekbargar/Nilgiri) [![codecov.io](https://img.shields.io/codecov/c/github/codecov/Nilgiri.svg?style=flat-square)](http://codecov.io/github/brycekbargar/Nilgiri?branch=master)
[![Nuget](https://img.shields.io/nuget/vpre/Nilgiri.svg?style=flat-square)](https://www.nuget.org/packages/Nilgiri/)

Chai.js style Expect assertions for .NET  
*nilgiri is some sort of black tea but it was the only one that started with 'n'...*

I really liked the [Expect BDD Syntax](http://chaijs.com/guide/styles/#expect) in Chai.js when I dabbled in Node.  
Why not bring it to .NET?

### To Install ###
`dnu install Nilgiri`

### To Use ###
```
using static Nilgiri.Assertions;

Expect(1).To.Equal(1);
Expect(true).To.Not.Be.False();
```

There are complete examples in the `Nilgiri.Tests/Examples` folder.

#### Legacy .NET Support ####
For c# < 6.0 there is no `using static` so things are a little different. This is already Deprecated(!) and just here until I can use c# 6 at work.
```
using Nilgiri.LegacyAssertions;

E.xpect(1).To.Equal(1);
E.xpect(true).To.Not.Be.False();
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
