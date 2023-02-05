dotnet pack
cd PowerCollections/bin/Debug
dotnet nuget push "*.nupkg" -k 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 -s https://nuget.pkg.github.com/Novoselov-Igor/index.json --skip-duplicate
pause