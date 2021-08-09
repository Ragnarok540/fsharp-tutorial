module BasicFunctions

let sampleFunction x = x*x + 3

let annotatedFunction (x:int) = 2*x*x - x/5 + 3

let functionWithConditionals x =
    if x < 100.0 then
        2.0*x*x - x/5.0
    elif x >= 100.0 && x <= 200.0 then
        x + 0.5
    else
        0.0

let executeFunctions =
    let result1 = sampleFunction 4573
    printfn "The result of sampleFunction is: %i\n" result1

    let result2 = annotatedFunction (7 + 4)
    printfn "The result of annotatedFunction is: %i\n" result2

    let result3 = functionWithConditionals 100.0
    printfn "The result of functionWithConditionals is: %f\n" result3
