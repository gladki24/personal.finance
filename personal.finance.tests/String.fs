namespace personal.finance.test

open NUnit.Framework
open personal.finance.domain.String

[<TestFixture>]
type StringTest () =

    [<Test>]
    member this.ShouldPass() =
        Assert.Pass()

    [<Test>]
    member this.Should_Contains_Escape_Characters() =
        // act
        let containSlash = stringIncludeEscape.Contains @"\"
        let containQuote = stringIncludeEscape.Contains @"'"

        // assert
        Assert.True(containSlash);
        Assert.True(containQuote);

    [<Test>]
    member this.Should_Not_Contains_Escape_Characters() =
        // act
        let containSlash = stringNotIncludeEscape.Contains @"\"
        let containQuote = stringNotIncludeEscape.Contains @"'"

        // assert
        Assert.False(containSlash);
        Assert.True(containQuote);
        