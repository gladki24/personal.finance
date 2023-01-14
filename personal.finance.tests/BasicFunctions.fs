namespace personal.finance.tests

open NUnit.Framework
open personal.finance.domain.BasicFunctions

// Testing class
[<TestFixture>]
type BasicFunctionsTest () =

    // Simple test
    [<Test>]
    member this.Should_Pass () =
        Assert.True(true)

    // Parametrized unit test
    [<Test>]
    [<TestCase(-10)>]
    [<TestCase(0)>]
    [<TestCase(10)>]
    member this.Should_Pass_LineFunction (value: int) =
        // arrange
        let ValidCalculation (y: int) = y * y + 3;
        let validValue = ValidCalculation value;

        // act
        let result = LineFunction value;

        // assert
        Assert.AreEqual(validValue, result);

    [<Test>]
    [<TestCase(-10)>]
    [<TestCase(0)>]
    [<TestCase(10)>]
    member this.Should_Pass_OtherLineFunction (value: int) =
        // arrange
        let ValidCalculation (y: int) = 2 * y * y + y + 12;
        let validValue = ValidCalculation value;

        // act
        let result = OtherLineFunction value;

        // assert
        Assert.AreEqual(validValue, result);

    [<Test>]
    [<TestCase(-10)>]
    [<TestCase(0)>]
    [<TestCase(10)>]
    member this.Should_Pass_Add (value: int) =
        // arrange
        let validResult = (value + value) * 2;

        // act
        // addition before call function
        let result = Add (value + value);

        // assert
        Assert.AreEqual(validResult, result);

    [<Test>]
    [<TestCase(10)>]
    [<TestCase(15)>]
    [<TestCase(125)>]
    [<TestCase(1)>]
    member this.Should_Return_True_For_Positive_Numbers_HasSquareFunctionResult (value: int) =
        // act
        let result = HasSquareFunctionResult (value);

        // assert
        Assert.True(result);

    [<Test>]
    member this.Should_Return_True_For_Zero_HasSquareFunctionResult () =
        // act
        let result = HasSquareFunctionResult 0;

        // assert
        Assert.True(result)

    [<Test>]
    [<TestCase(-1)>]
    [<TestCase(-10)>]
    [<TestCase(-125)>]
    [<TestCase(-256)>]
    member this.Should_Return_False_For_Negative_Numbers_HasSquareFunctionResult (value: int) =
        // act
        let result = HasSquareFunctionResult value;

        // assert
        Assert.False(result)
        
