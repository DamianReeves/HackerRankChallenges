// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open System

[<EntryPoint>]
let main argv = 
    let mutable continueLooping = true
    while continueLooping do
        printfn "Choose a problem:"
        printfn "1 - The Lonely Integer"
        printfn "2 - Solve Me Second"
        printfn "Q - Quit"

        let line = Console.ReadLine()
        match line with 
        | "1" -> TheLonelyInteger.run argv |> ignore
        | "2" -> SolveMeSecond.run argv |> ignore
        | "Q"|"q" -> continueLooping <- false
        | _ -> ()
    0
