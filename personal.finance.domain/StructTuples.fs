namespace personal.finance.domain

module StructTuples =
    
    // struct tuple behave like struct from C#
    let structTuple = struct (1, 3);

    let convertFromStructTuple struct(a, b) = (a, b);

    let convertToStructTuple (a, b) = struct(a, b);