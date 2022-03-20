namespace AddSevenPS

open System.Management.Automation
open System.Management.Automation.Runspaces
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
        // This is acting as Cmdlet class instance to access its methods 
        this.WriteObject(7 + num)
        base.EndProcessing()
