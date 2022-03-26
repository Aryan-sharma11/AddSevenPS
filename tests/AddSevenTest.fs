module AddSevenFSTest

open Xunit
open AddSevenFS


[<Fact>]
let `` AddSeven.addSeven: 1 => 8 `` () =
    let result =  addSeven(1)
    let expected = 8
    Assert.Equal(expected, result) 