module AddSevenPSTest

open System

// Importing XUnit testing framework
open Xunit

// Importing our base namespace
open AddSevenPS

 // Beginning of a test
[<Fact>]
let `` AddSeven.addSeven on list of integers`` () =
     
     // A list with integers for testing
     let actual = AddSeven.``Add seven to list`` [ 9 ; 25 ; -2 ; 5 ; 11 ]
     
     // Expected results for our test cases
     let expected = [ 16 ; 32 ; 5 ; 12 ; 18 ]
     
     // Comparing actual results with expected results
     Assert.Equal< Collections.Generic.IEnumerable<int> >(actual , expected)      
        
                         
        