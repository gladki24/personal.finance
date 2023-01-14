namespace personal.finance.domain

// functions are organized into modules
module BasicFunctions =

    // the most basic element of F# language -> function
    // let - define new function
    let LineFunction (x: int) = x * x + 3;

    // results you can find in personal.finance.tests project

    // parentheses are optional only if has one argument without data type anotations
    let OtherLineFunction x = 2 * x * x + x + 12;

    // See how to call this function in unit tests
    let Add a = a + a;

    // Conditionals
    let HasSquareFunctionResult (delta: int) =
        if delta < 0 then
            false
        else
            true

