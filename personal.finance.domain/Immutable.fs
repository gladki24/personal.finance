namespace personal.finance.domain

module Immutable =

    let BasicFunction (x: int) =
        // default bindings are immutable
        let immutableNumber: int = x

        // if bindings should be muttable add proper keyword
        // functional language doesn't like that
        let mutable mutableNumber: int = x

        // this instruction doesn't return any value, without
        // next instruction this function would return nil/null
        mutableNumber <- immutableNumber + mutableNumber
        
        // notice that, to return value it should be at the end of function
        mutableNumber


