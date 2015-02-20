module FlippingBits
    open System
    let run argv = 
        let lines = Console.ReadLine() |> int
        for i in 1.. lines do
            let input = Console.ReadLine() |> uint32
            printfn "%d" ~~~input

        0 // return an integer exit code
