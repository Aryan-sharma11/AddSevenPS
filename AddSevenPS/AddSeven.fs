module AddSevenFS 

let addSeven num = num + 7
 
// For testing purpose
//  Testing list of integers and then returning the list with solutions  
let addSevenToList numList =
    
    // Mapping the solutions to the list of test cases
    numList |> Seq.map addSeven



