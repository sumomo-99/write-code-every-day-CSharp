Param(
  [parameter(mandatory=$true)]$ProjectName
)

$SlnPah = (Join-Path (Convert-Path .) $ProjectName)
$SrcPath = (Join-Path $SlnPah 'src' $ProjectName)
$TestName = $ProjectName + 'Test'
$TestPath = (Join-Path $SlnPah 'tests' $TestName)
$Extension = '.csproj'

# Solution
dotnet.exe new sln -o $SlnPah
Set-Location -Path $SlnPah

# Console
New-Item -Path $SrcPath -ItemType Directory
dotnet.exe new console -o $SrcPath
dotnet.exe sln add $(Join-Path $SrcPath ($ProjectName + $Extension))

#xUnit
New-Item -Path $TestPath -ItemType Directory
dotnet.exe new xunit -o $TestPath
dotnet.exe sln add $(Join-Path $TestPath ($TestName + $Extension))
dotnet.exe add $(Join-Path $TestPath ($TestName + $Extension)) `
  reference $(Join-Path $SrcPath ($ProjectName + $Extension))
