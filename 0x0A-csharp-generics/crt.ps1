if ( $args.Count -gt 0 )
{
    for ( $i = 0; $i -lt $args.Count; $i++)
    {
        dotnet new console -o $args[$i]
    }
}

else
{
    Write-Host "No arguments passed."
}
