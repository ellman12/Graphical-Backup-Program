# Used for compiling GBP into an .exe to be shared with others and run outside of VS2019.
Set-Location -Path "./Graphical Backup Program"
Invoke-Expression "dotnet publish -o GBP -r win-x64 /p:PublishSingleFile=true"
$compress = @{
    Path             = "GBP"
    CompressionLevel = "Fastest"
    DestinationPath  = "../Program.zip"
}
Compress-Archive @compress
Remove-Item .\GBP -Recurse