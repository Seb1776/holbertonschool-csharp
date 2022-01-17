if ( $args.Count -gt 0 )
{
    for ( $i = 0; $i -lt $args.Count; $i++)
    {
        $FilePath = '{0}/Program.cs' -f $args[$i]
        $FileName = '{0}.cs' -f $args[$i]
        dotnet new console -o $args[$i]
        Rename-Item -Path $FilePath -NewName $FileName
    }
}

else
{
    Write-Host "No arguments passed."
}
