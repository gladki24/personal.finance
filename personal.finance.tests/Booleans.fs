namespace personal.finance.tests

open NUnit.Framework
open personal.finance.domain.Booleans

[<TestFixture>]
type BooleansTest () =
    
    [<Test>]
    // member need have parenthess in opposition to let functions
    member this.Should_Pass () =
        Assert.Pass()

    member this.Should_Be_True () =
        Assert.True(result)