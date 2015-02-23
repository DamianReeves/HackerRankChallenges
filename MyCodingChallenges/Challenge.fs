namespace Coding.Challenges

type IChallenge = 
    abstract member Name:string with get
    abstract member Run : string []->unit


type ChallengeRepository(challenges:IChallenge list) =    
    let challengeMap = 
        let rec mapBuilder (theChallenges:IChallenge list) map =
            match theChallenges with
            | [] -> map
            | challenge::rest -> 
                map 
                |> Map.add challenge.Name challenge
                |> mapBuilder rest 

        mapBuilder challenges Map.empty<string,IChallenge>
                
    member this.FindChallenge name =
        challengeMap |> Map.tryFind name

type ChallengeRunner(repository) =
    new(challenges) =
        let repo = new ChallengeRepository(challenges)
        ChallengeRunner(repo)

    member this.Run name = ()

[<AutoOpen>]
module Challenges =
    let create (challengeList:IChallenge list) =
        new ChallengeRunner(challengeList)

    let run name (challengeList:IChallenge list) =
        (create challengeList).Run name