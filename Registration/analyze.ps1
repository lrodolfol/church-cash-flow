param(
    [switch]$SkipTests,
    [string]$SonarToken = $env:SONAR_TOKEN
)

$projectKey = "church-key-sonar"
$sonarHost = "http://localhost:9000"

if ([string]::IsNullOrEmpty($SonarToken)) {
    $SonarToken = "sqp_93d83c035fb1ba701e366b6cf1e9a0ca8e374901"
}

Write-Host "Iniciando analise SonarQube..." -ForegroundColor Cyan

Write-Host "Limpando builds anteriores..." -ForegroundColor Yellow
dotnet clean

Write-Host "Iniciando scanner SonarQube..." -ForegroundColor Cyan
dotnet sonarscanner begin /k:$projectKey /d:sonar.host.url=$sonarHost /d:sonar.login=$SonarToken

Write-Host "Buildando projeto..." -ForegroundColor Yellow
dotnet build

if (-not $SkipTests) {
    Write-Host "Rodando testes..." -ForegroundColor Yellow
    dotnet test
}

Write-Host "Finalizando analise..." -ForegroundColor Cyan
dotnet sonarscanner end /d:sonar.login=$SonarToken

Write-Host "Analise concluida! Acesse: http://localhost:9000/" -ForegroundColor Green
