module SolveMeSecond
    open System
    let run argv = 
        let lines = Console.ReadLine() |> int
        //printfn "Expecting %d lines of input" lines
        for i in 1.. lines do
            let line = Console.ReadLine().Split(' ')
            let a = line.[0] |> int
            let b = line.[1] |> int
            printfn "%d" (a+b)
              
        0 // return an integer exit code