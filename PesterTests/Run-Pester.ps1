# This will run all the Pester tests in the directory
Invoke-Pester -Output Detailed *Tests* 

# Saving the Tests results in xml file
Invoke-Pester -OutputFile result.xml 
