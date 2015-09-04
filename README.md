# Nilgiri
[![Build Status](https://travis-ci.org/brycekbargar/Nilgiri.svg)](https://travis-ci.org/brycekbargar/Nilgiri)[![codecov.io](http://codecov.io/github/brycekbargar/Nilgiri/coverage.svg?branch=master)](http://codecov.io/github/brycekbargar/Nilgiri?branch=master)

Chai.js style assertions for .NET  
*nilgiri is some sort of black tea but it was the only one that started with 'n'...*

I really liked the [BDD Assertion Styles](http://chaijs.com/api/bdd/) in Chai.js when I dabbled in Node.  
Why not bring them to .NET?


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

### Currently Implemented ###
1. Equal
1. Not

### To "Build" ###
I'm still working out the `dnx` thing.

### To Test ###
```
dnu restore
dnx test/Nilgiri.Tests test
```
