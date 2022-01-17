if ( $args.Count -gt 0)
{   
    if ( $args[0] -ne "help" )
    {
        New-Item -Path . -Name $args[0] -ItemType "directory"

        if ( Test-Path -Path $args[0] )
        {   
            Write-Host "Parent Folder Created."

            Set-Location $args[0]
            dotnet new sln
            Set-Location ./..

            if ( [string]$args[1] -ne  "")
            {
                New-Item -Path $args[0] -Name $args[1] -ItemType "directory"
                $ProgramDirectory = '{0}/{1}' -f $args[0], $args[1]

                Set-Location $ProgramDirectory
                dotnet new classlib
                Set-Location ./../..

                $ProgramFile = '{0}/{1}/Class1.cs' -f $args[0], $args[1]
                $NeoProgramFile = '{0}.cs' -f $args[1]

                Rename-Item -Path $ProgramFile -NewName $NeoProgramFile

                $XMLFile = '{0}/{1}/{1}.csproj' -f $args[0], $args[1]
                $DocLine = '<TargetFramework>netstandard2.0</TargetFramework>'
                $NeoDocLine = '<TargetFramework>netstandard2.0</TargetFramework>{0}    <DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile> to MyMath.csproj' -f "`r`n"
                $XMLContent = Get-Content $XMLFile
                $XMLContent | ForEach-Object {$_ -replace $DocLine,$NeoDocLine} | Set-Content $XMLFile
                
                $CSProjDir = '{0}/{0}.csproj' -f $args[1]
                Set-Location $args[0]
                dotnet sln add $CSProjDir
                Set-Location ./..
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
