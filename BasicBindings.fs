module BasicBindings

    let integersAndNumbers =

        let sampleInteger = 176
        printfn "Sample integer: %i\n" sampleInteger

        let sampleFloat = 4.1
        printfn "Sample float: %f\n" sampleFloat

        let sampleInteger2 = (sampleInteger/4 + 5 - 7) * 4 + int sampleFloat
        printfn "Sample integer 2: %i\n" sampleInteger2

        let sampleFloat2 = (sampleFloat/4.0 + 5.0 - 7.0) * 4.0 + float sampleInteger
        printfn "Sample float 2: %f\n" sampleFloat2

        let sampleNumbers = [ 0 .. 99 ]
        printfn "Sample numbers: %A\n" sampleNumbers
 
        let sampleTableOfSquares = [ for i in 0 .. 99 -> (i, i*i) ]
        printfn "Sample table of squares: %A\n" sampleTableOfSquares

        let mutable number = 1
        printfn "Mutable binding before: %i\n" number
        number <- number + 1
        printfn "Mutable binding after: %i\n" number