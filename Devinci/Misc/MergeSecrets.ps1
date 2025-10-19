param(
    [string]$targetAppSettings,
    [string]$projectName
)

$secretsId = (Select-Xml -Path "$PSScriptRoot\..\$projectName.csproj" -XPath "//*[local-name()='UserSecretsId']").Node.InnerText
$secretsPath = "$env:APPDATA\Microsoft\UserSecrets\$secretsId\secrets.json"

if (-not (Test-Path $secretsPath)) {
    Write-Host "No secrets.json found"
    Write-Host "$PSScriptRoot\*.csproj"
    Write-Host "$projectName"
    exit 0
}

Write-Host "Merging secrets into: $targetAppSettings"

$appSettings = Get-Content $targetAppSettings -Raw | ConvertFrom-Json
$secrets = Get-Content $secretsPath -Raw | ConvertFrom-Json

# Loop through all flat keys and apply them
$secrets.PSObject.Properties | ForEach-Object {
    $key = $_.Name
    $value = $_.Value
    
    # Parse "AppConfig:ClientApps:0:ClientSecret" format
    if ($key -match '^AppConfig:ClientApps:(\d+):ClientSecret$') {
        $index = [int]$matches[1]
        $appSettings.AppConfig.ClientApps[$index].ClientSecret = $value
        Write-Host "  Set ClientApps[$index].ClientSecret"
    }
}

$appSettings | ConvertTo-Json -Depth 10 | Set-Content $targetAppSettings

Write-Host "Secrets merged successfully!"

# Get source directory (output folder containing appsettings.json)
$sourceDir = Split-Path $targetAppSettings -Parent

# Destination folder
$destDir = "C:\Program Files\Buzzripper\Devinici"

# Delete all files/folders in destination
if (Test-Path $destDir) {
    Write-Host "Cleaning destination: $destDir"
    Remove-Item "$destDir\*" -Recurse -Force
}

# Create destination if it doesn't exist
if (-not (Test-Path $destDir)) {
    New-Item -Path $destDir -ItemType Directory -Force | Out-Null
}

# Copy all files/folders
Write-Host "Copying from: $sourceDir"
Write-Host "Copying to: $destDir"
Copy-Item "$sourceDir\*" -Destination $destDir -Recurse -Force

Write-Host "Deployment complete!"