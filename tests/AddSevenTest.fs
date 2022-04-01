module AddSevenFSTest

open System.Collections.Generic
open AddSeven
open Xunit
open AddSevenFS


[<Fact>]

// Sending 1 as input and expecting 8 as result
let `` AddSeven.addSeven: 1 => 8 `` () =
    let result =  addSeven(1)
    let expected = 8
    Assert.Equal(expected, result)
    

[<Fact>]
let `` AddSeven.addSeven on list of integers`` () =
     
     // A list with integers for testing
     let actual = addSevenToList [ 9 ; 25 ; -2 ; 5 ; 11 ]
     
     // Expected results for our test cases
     let expected = [ 16 ; 32 ; 5 ; 12 ; 18 ]
     
     // Comparing actual results with expected results
     Assert.Equal<IEnumerable<int>>(actual , expected)      
        
                         
        