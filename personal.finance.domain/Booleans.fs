namespace personal.finance.domain

module Booleans =
    
    let trueValue = true
    let falseValue = false

    // as like C# in F# we have && <-> and, || <-> or
    let result = trueValue && falseValue || trueValue;
    