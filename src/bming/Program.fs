open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Running
open BenchmarkDotNet

[<SimpleJob(warmupCount = 0, iterationCount = 5)>]
type BuildCollection() =
    [<Params(1000, 10000, 100000)>]
    member val N = 0 with get, set

    [<Benchmark>]
    member this.WithSeq() =
        let s = seq {
            for n in 0 .. this.N do
                n
        }

        for _ in s do
            ()

    [<Benchmark>]
    member this.WithArray() =
        let s = [|
            for n in 0 .. this.N do
                n
        |]

        for _ in s do
            ()

    [<Benchmark>]
    member this.WithList() =
        let s = [
            for n in 0 .. this.N do
                n
        ]

        for _ in s do
            ()

    [<Benchmark>]
    member this.WithResize() =
        let s = ResizeArray()

        for n in 0 .. this.N do
            s.Add n

        for _ in s do
            ()

    [<Benchmark>]
    member this.WithResizeToArray() =
        let s = ResizeArray()

        for n in 0 .. this.N do
            s.Add n

        let s = s.ToArray()

        for _ in s do
            ()

let summary = BenchmarkRunner.Run<BuildCollection>()