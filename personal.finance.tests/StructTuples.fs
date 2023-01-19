namespace personal.finances.tests

open NUnit.Framework
open personal.finance.domain.StructTuples

[<TestFixture>]
type StructTuples() =
    
    [<Test>]
    member this.Shoud_Pass() =
        Assert.Pass();

    [<Test>]
    [<TestCase(3, 2)>]
    [<TestCase(-1, -1)>]
    [<TestCase(1, -1)>]
    member this.Should_Convert_From_Struct_Tuple(a: int, b: int) =
        // arrange
        let structTuple = struct (a, b);
        let sut = convertFromStructTuple;

        // act
        let tupleA = sut(structTuple);
        let tupleB = sut(structTuple);

        let referenceEqualityResult = obj.ReferenceEquals(tupleA, tupleB);
        let referenceTupleAEqualityResult = obj.ReferenceEquals(tupleA, tupleA);
        let valueEqualityResult = tupleA = tupleB;

        // assert
        Assert.False(referenceEqualityResult);
        Assert.True(referenceTupleAEqualityResult);
        Assert.True(valueEqualityResult);

    [<Test>]
    [<TestCase(3, 2)>]
    [<TestCase(-1, -1)>]
    [<TestCase(1, -1)>]
    member this.Should_Convert_To_Struct_Tuple(a: int, b:int) =
        // arrange
        let tuple = (a, b);
        let sut = convertToStructTuple;

        // act
        let tupleA = sut(tuple);
        let tupleB = sut(tuple);

        // obj.ReferenceEquals always return false for value types
        let referenceTupleAEqualityResult = obj.ReferenceEquals(tupleA, tupleA);
        let valueEqualityResult = tupleA = tupleB;

        // assert
        Assert.False(referenceTupleAEqualityResult);
        Assert.True(valueEqualityResult);
        

