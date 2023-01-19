
namespace personal.finance.tests

open NUnit.Framework
open personal.finance.domain.Tuples

// add paranthes add constructor to type
[<TestFixture>]
type TuplesTest() =

    [<Test>]
    member this.Should_Pass() =
        Assert.Pass();


    [<Test>]
    member this.Should_Be_Tuple() = 
        let sut = tuple;
        Assert.AreEqual((1, 2, 3), sut);

    [<Test>]
    [<TestCase(3, 4)>]
    [<TestCase(-1, -1)>]
    [<TestCase(10, 12)>]
    [<TestCase(-1, 1)>]
    member this.Should_Return_Swaped_Tuple(a: int, b: int) =
        // arrange
        let tuple = (a, b);
        let sut = swapTuple;

        // act
        let result = sut(a, b)

        // assert
        Assert.AreEqual(result, (b, a));

    [<Test>]
    member this.Should_Contains_Mixed_Types() =
        // arrange
        let sut = mixedTuple;

        // act
        // destructing tuple
        let integerValue, doubleValue, stringValue = sut;

        // assert
        Assert.AreEqual(1, integerValue);
        Assert.AreEqual(3.2, doubleValue);
        Assert.AreEqual("text", stringValue);


