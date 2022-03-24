module AddSevenPS.LibraryTest

open Xunit
open AddSevenPS

[<Fact>]
let `` AddSeven.addSeven -> " 1 => 8" `` () =
    let result =  AddSeven.addSeven(1)
    let expected = 8
    Assert.Equal(expected, result)
