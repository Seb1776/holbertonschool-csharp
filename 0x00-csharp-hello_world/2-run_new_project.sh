#!/usr/bin/env bash
dotnet new console -o 2-new_project --framework net6.0
dotnet build ./2-new_project
dotnet run --project ./2-new_project
