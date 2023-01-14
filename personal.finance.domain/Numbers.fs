namespace personal.finance.domain

module Numbers =
    
    // int
    let integer = 128

    // double
    let double = 25.6

    // cast to int
    let SimpleFunction = (integer / 4 + 5 - 7) + int double

    // list of ints
    // create of list by define range of values
    let integers = [0 .. 128]

    // list of tuples
    // create list of tuples: integer and it square
    let intAndSquare = [ for i in 0 .. 99 -> (i, i * i) ]

