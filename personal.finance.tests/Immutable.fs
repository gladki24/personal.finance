namespace personal.finance.tests

open NUnit.Framework
open personal.finance.domain.Immutable

[<TestFixture>]
type ImmutableTest() =

    [<Test>]    
    member this.Should_Pass() =
        Assert.Pass();

    [<Test>]
    [<TestCase(1)>]
    [<TestCase(12)>]
    [<TestCase(-12)>]
    member this.Should_Return_Valid_Result(value: int) =
        // act
        let validResult = value * 2

        // assert
        let result = BasicFunction value

        // assert
        Assert.AreEqual(validResult, result)
        