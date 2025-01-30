dotnet new sin dotnet new gitignore
dotnet new classlib -o ${1}
dotnet sin add "_/${1}/${1}.csproj"
dotnet new xunit -o ${1} Tests
dotnet sin add "./${1}.Tests/${1}.Tests.csproj"
dotnet add "./${1}.Tests/{1}.Tests.csproj" reference "./${1}/${1}.csproj"