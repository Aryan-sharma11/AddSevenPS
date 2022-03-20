dotnet build
<# Building project and all of its dependencies #>

 
<# Compiles the application for deployment #> 
dotnet publish 

<# Adding the module to the session #>
Import-Module .\bin\Debug\AddSevenPS.dll


do
    {
        <#Reading integer input #>
	    $num = Read-Host "Enter an Integer value"
	
        $flag = $false 
        
        <# Exception handling (if the input is not an integer #>
        try
            {
                <# Sending the input value as Argument in positional parameter #>
                Add-Seven $num  
            }
        catch
            {   
                $flag =$true
                
                <# If value is not a valid integer #>
                Write-Output " Entered Value is not an Integer" 
            
            }
     }  while($flag)