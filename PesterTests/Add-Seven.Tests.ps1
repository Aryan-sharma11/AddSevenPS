BeforeAll {
    Import-Module ../AddSevenPS/bin/Debug/net6.0/publish/AddSevenPS.dll

}

Describe 'Add-Seven' {
    It 'Works for negative integers' {
        Add-Seven -1 | Should -Be 6
    }

    It 'Works for positive integers' {
        Add-Seven 1 | Should -Be 8
    }

    It 'Fails for decimal number' {
        Add-Seven 1.8 | Should -Be "Please enter a valid integer."
    }

    It 'Fails for string input' {
        Add-Seven "abcd" | Should -Be "Please enter a valid integer."
    }
}