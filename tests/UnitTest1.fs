module tests

open System.Management.Automation

open System

// Importing our base namespace
open AddSevenPS

// Importing NUnit testing framework
open NUnit.Framework

// [<TestFixture>] marks the class that contains tests
[<TestFixture>]

type TestClass () =
    
    // Beginning of a test
    [<Test>]
    member this.TestEvenSequence () =
        
        // Expected results for our test cases
        let expected = [ 9 ; 11 ; 13 ; 15 ; 17 ]
        
        // A list with integers for testing 
        let actual = AddSeven.``Add seven to list`` [ 2 ; 4 ; 6 ; 8 ; 10 ]
       
        // Determining that the result sequence is equal to our expected results
        Assert.That( actual , Is.EqualTo( expected ) )
    
        
                         
        