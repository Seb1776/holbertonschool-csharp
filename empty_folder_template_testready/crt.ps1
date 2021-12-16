if ( $args.Count -gt 0)
{   
    if ( $args[0] -ne "help" )
    {
        New-Item -Path . -Name $args[0] -ItemType "directory"

        if ( Test-Path -Path $args[0] )
        {   
            Write-Host "Parent Folder Created."

            if ( [string]$args[1] -ne  "")
            {
                New-Item -Path $args[0] -Name $args[1] -ItemType "directory"
                $newPath = '{0}/{1}' -f $args[0], $args[1]

                if ( Test-Path -Path $args[0] )
            }

            else
            {
                Write-Host "A Class Name Is Needed."
            }
        }

        else
        {
            Write-Host "Folder Not Created."
        }
    }

    else
    {
        Write-Host "First argument is the parent folder name, the second argument is the namespace name."
    }
}

else
{
    Write-Host "No arguments passed."
}

<#if ( $args.Count -gt 0 )
{
    for ( $i = 0; $i -lt $args.Count; $i++)
    {
        #dotnet new console -o $args[$i]
        dotnet new sln --name $args[$i]
        $pathPr = '{0}/Program.cs' -f $args[$i]
        $newnamePr = '{0}.cs' -f $args[$i]
        Rename-Item -Path $pathPr -NewName $newnamePr


    }
}

else
{
    Write-Host "No arguments passed."
}#>
