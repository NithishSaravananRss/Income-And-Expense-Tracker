# Build and Package Script for Income and Expenses Tracker
# This script builds the application in Release mode and prepares it for deployment

param(
    [string]$OutputPath = ".\Publish"
)

Write-Host "======================================" -ForegroundColor Cyan
Write-Host "Income and Expenses Tracker - Build Script" -ForegroundColor Cyan
Write-Host "======================================" -ForegroundColor Cyan
Write-Host ""

# Get the solution directory
$scriptPath = Split-Path -Parent $MyInvocation.MyCommand.Path
$solutionDir = $scriptPath

Write-Host "Solution Directory: $solutionDir" -ForegroundColor Yellow

# Find the .sln file
$slnFile = Get-ChildItem -Path $solutionDir -Filter "*.sln" | Select-Object -First 1

if (-not $slnFile) {
    Write-Host "ERROR: Solution file (.sln) not found!" -ForegroundColor Red
    exit 1
}

Write-Host "Solution File: $($slnFile.Name)" -ForegroundColor Yellow
Write-Host ""

# Build the solution in Release mode
Write-Host "Building solution in Release mode..." -ForegroundColor Green

$msbuildPath = & "${env:ProgramFiles(x86)}\Microsoft Visual Studio\Installer\vswhere.exe" -latest -requires Microsoft.Component.MSBuild -find MSBuild\**\Bin\MSBuild.exe

if (-not $msbuildPath) {
    Write-Host "ERROR: MSBuild not found! Please install Visual Studio." -ForegroundColor Red
    exit 1
}

$buildOutput = & $msbuildPath $slnFile.FullName /p:Configuration=Release /p:Platform="Any CPU" /v:minimal

if ($LASTEXITCODE -ne 0) {
    Write-Host "ERROR: Build failed!" -ForegroundColor Red
    exit 1
}

Write-Host "Build successful!" -ForegroundColor Green
Write-Host ""

# Create output directory
$publishPath = Join-Path $solutionDir $OutputPath
if (Test-Path $publishPath) {
    Write-Host "Cleaning existing publish directory..." -ForegroundColor Yellow
    Remove-Item -Path $publishPath -Recurse -Force
}

New-Item -Path $publishPath -ItemType Directory -Force | Out-Null
Write-Host "Publish Directory: $publishPath" -ForegroundColor Yellow
Write-Host ""

# Copy build output
$releasePath = Join-Path $solutionDir "IncomeandExpensesTracker\bin\Release"

if (-not (Test-Path $releasePath)) {
    Write-Host "ERROR: Release build output not found!" -ForegroundColor Red
    exit 1
}

Write-Host "Copying application files..." -ForegroundColor Green
Copy-Item -Path "$releasePath\*" -Destination $publishPath -Recurse -Force

# Create a version file
$version = "1.0.0"
$versionInfo = @"
Income and Expenses Tracker
Version: $version
Build Date: $(Get-Date -Format "yyyy-MM-dd HH:mm:ss")
"@

$versionInfo | Out-File -FilePath (Join-Path $publishPath "VERSION.txt") -Encoding UTF8

Write-Host ""
Write-Host "======================================" -ForegroundColor Cyan
Write-Host "Build Complete!" -ForegroundColor Green
Write-Host "======================================" -ForegroundColor Cyan
Write-Host ""
Write-Host "Published to: $publishPath" -ForegroundColor Yellow
Write-Host ""
Write-Host "Next Steps:" -ForegroundColor Cyan
Write-Host "1. Test the application by running: $publishPath\IncomeandExpensesTracker.exe" -ForegroundColor White
Write-Host "2. Zip the Publish folder for distribution" -ForegroundColor White
Write-Host "3. Or create an installer using InstallShield, WiX, or Inno Setup" -ForegroundColor White
Write-Host ""
Write-Host "Default Login:" -ForegroundColor Yellow
Write-Host "  Username: admin" -ForegroundColor White
Write-Host "  Password: admin" -ForegroundColor White
Write-Host ""

# Offer to create a ZIP file
$createZip = Read-Host "Would you like to create a ZIP file for distribution? (Y/N)"

if ($createZip -eq "Y" -or $createZip -eq "y") {
    $zipPath = Join-Path $solutionDir "IncomeAndExpensesTracker_v$version.zip"
    
    Write-Host "Creating ZIP file..." -ForegroundColor Green
    
    if (Test-Path $zipPath) {
        Remove-Item $zipPath -Force
    }
    
    Compress-Archive -Path "$publishPath\*" -DestinationPath $zipPath -Force
    
    Write-Host "ZIP file created: $zipPath" -ForegroundColor Green
}

Write-Host ""
Write-Host "Done!" -ForegroundColor Green
