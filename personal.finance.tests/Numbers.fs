namespace personal.finance.tests

open NUnit.Framework
open personal.finance.domain.Numbers

[<TestFixture>]
type NumberTest() =

    [<Test>]
    member this.Shoud_Pass () =
        Assert.Pass()

    [<Test>]
    [<TestCase(0)>]
    [<TestCase(128)>]
    [<TestCase(55)>]
    member this.Should_Return_True_If_Contains_Value (a: int) =
        // act
        let result = List.contains a integers

        // assert
        Assert.True(result);

    [<Test>]
    [<TestCase(-1)>]
    [<TestCase(129)>]
    member this.Should_Return_False_If_NotContains_Value(a: int) =
        // act
        let result = List.contains a integers
        
        // assert
        Assert.False(result);

    [<Test>]
    [<TestCase(2, 4)>]
    [<TestCase(12, 144)>]
    [<TestCase(13, 169)>]
    [<TestCase(0, 0)>]
    member this.Should_Return_True_If_Contains_Tuple (a: int, b: int) =
        // arrange
        let tuples = intAndSquare

        // act
        // check if list contains tuple
        let result = List.contains (a, b) tuples

        // assert
        Assert.True(result)

    [<Test>]
    [<TestCase(-1, 1)>]
    [<TestCase(-2, 4)>]
    [<TestCase(2, 8)>]
    [<TestCase(0, 1)>]
    [<TestCase(-1, 8)>]
    [<TestCase(100, 10000)>]
    member this.Should_Return_False_If_NotContains_Tuple(a: int, b: int) =
        // arrange
        let tuples = intAndSquare

        // act
        let result = List.contains (a, b) tuples
        
        // assert
        Assert.False(result)



