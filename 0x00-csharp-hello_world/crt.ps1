if ( $args.Count -gt 0 )
{
    for ( $i = 0; $i -lt $args.Count; $i++)
    {
        dotnet new console -o $args[$i]
        Rename-Item -Path "$args[$i]/Program.cs" -NewName "$args[$i]"
    }
}

else
{
    Write-Host "No arguments passed."
}
