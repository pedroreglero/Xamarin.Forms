& dotnet pack $PSScriptRoot\..\src\Core\src\Core-net6.csproj
& dotnet pack $PSScriptRoot\..\src\Controls\src\Xaml\Controls.Xaml-net6.csproj
& dotnet pack $PSScriptRoot\..\src\Controls\src\Core\Controls.Core-net6.csproj
& dotnet pack $PSScriptRoot\..\src\Controls\src\Build.Tasks\Controls.Build.Tasks-net6.csproj

& dotnet pack $PSScriptRoot\..\.nuspec\Microsoft.Maui.Package.csproj