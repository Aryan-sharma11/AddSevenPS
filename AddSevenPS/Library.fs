namespace AddSevenPS

open System.Management.Automation

open System.Management.Automation.Runspaces

module AddSeven =
    let addSeven num = num + 7
     
    // For testing purpose
    // Recieving a list of integers and then returning the list with solutions mapped to the list 
    let add7 numberseq =
        
        // Mapping the solutions to the list of test cases
        numberseq |> Seq.map addSeven


// Cmdlet attribute declaration
[<Cmdlet("Add", "Seven")>] 
type GetNum() =
     
    // Inheriting the PSCmdlet class
    inherit PSCmdlet()
   
    
    // Allows the cmdlet let to take default input
    // Positional parameter to allow Cmdlet to take input without specifying the variable
    [<Parameter(Position = 0)>] 
    member val Num : string = "" with get , set
    override this.EndProcessing() =
        
        // Typecasting String to Integer
        let num = this.Num |> int
        
        this.WriteObject( AddSeven.addSeven (num) )
        
        base.EndProcessing()
