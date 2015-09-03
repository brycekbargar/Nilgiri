# Nilgiri
Chai.js style assertions for .NET  
*nilgiri is some sort of black tea but it was the only one that started with 'n'...*

I really liked the [BDD Assertion Styles](http://chaijs.com/api/bdd/) in Chai.js when I dabbled in Node.  
Why not bring them to .NET?


### To Use ###
#### Expect ####
```
using Nilgiri.Expect;

Expect._(1).To.Equal(1);
Expect._(() => Someclass.Someprop).To.Not.Equal(1);
```

#### Should ####
```
using Nilgiri.Should;

__._(1).Should.Equal(1);
__._(() => Someclass.Someprop).Should.Not.Equal(1);
```

### Currently Implemented ###
1. Equal
1. Not

### To "Build" ###
I hate how .NET shoves all the packages in a global folder...  
`dnu restore --packages packages`

I'm still working out the `DNVM` thing.

### To Test ###
`dnx . test`
