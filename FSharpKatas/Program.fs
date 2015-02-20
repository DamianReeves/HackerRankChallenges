// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open System

[<EntryPoint>]
let main argv = 
    let count = Console.ReadLine() |> int
    let input = Console.ReadLine().Split(' ')
    let answer (items:string array) =         
        let _,result = 
            items
            |> Array.fold (fun (acc:Map<string,int> * Set<string>) (elm:string) ->
                let daMap, daSet = acc
                match daMap.TryFind(elm) with
                | Some value -> (daMap |> Map.add elm (value + 1)), (daSet |> Set.remove elm)
                | _ -> (daMap |> Map.add elm 1), daSet |> Set.add elm
            ) ((Map.empty<string,int>), Set.empty<string>)

        result|>Set.toSeq |> Seq.nth 0
    answer input
    |> printfn "%s" 

    0 // return an integer exit code
