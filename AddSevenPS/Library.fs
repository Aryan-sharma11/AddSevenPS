namespace AddSeven

open System.Management.Automation

// PowerShell cmdlets required for AddSeven function
module AddSevenPS=
    
    [<Cmdlet("Add", "Seven")>]
    
    // Cmdlet attribute declaration
    type GetNum() =
        // Inheriting the PSCmdlet class
        inherit PSCmdlet()
        
        // Allows the cmdlet let to take default input
        // Positional parameter to allow Cmdlet to take input without specifying the variable
        [<Parameter(Position = 0)>]
        member val Num : string = "" with get , set
        override this.EndProcessing() =
                 
            let mutable result = 0
            
            if System.Int32.TryParse(this.Num, &result) then
                this.WriteObject(AddSevenFS.addSeven (result))
            else
               this.WriteObject("Please enter a valid integer.")
                    
            base.EndProcessing()