namespace Coding.Challenges.Tests
open Coding.Challenges
open Xunit
open FsUnit.Xunit

type ``Given a list of challenges`` () =
    let createMockChallenge name = 
        {new IChallenge with
            member this.Name = name
            member this.Run argv = ()}
    let challenges = [
        createMockChallenge "Foo"
        createMockChallenge "Bar"
    ]

    let repo = new ChallengeRepository(challenges)

    [<Fact>] member test.
     ``when I try to find an exsiting challenge I get back an option of that challenge`` ()=
        repo.FindChallenge "Foo" |> should equal (Some challenges.[0])

    [<Fact>] member test.
     ``when I try to find a challenge that does not exist I should get back None`` ()=
        repo.FindChallenge "Baz" |> should equal None