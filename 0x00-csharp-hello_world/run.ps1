if ( $args.Count -gt 0 )
{
    for ( $i = 0; $i -lt $args.Count; $i++)
    {
        dotnet run --project $args[$i]
    }
}

else
{
    Write-Host "No arguments passed."
}