param(
    [switch]$SkipTests
)

$projectKey = "church-key-sonar"
$sonarHost = "http://localhost:9000"
$sonarToken = "sqp_93d83c035fb1ba701e366b6cf1e9a0ca8e374901"

Write-Host "🔍 Iniciando análise SonarQube..." -ForegroundColor Cyan

# Limpar builds anteriores
Write-Host "🧹 Limpando builds anteriores..." -ForegroundColor Yellow
dotnet clean

# Iniciar análise
Write-Host "📊 Iniciando scanner SonarQube..." -ForegroundColor Cyan
dotnet sonarscanner begin /k:$projectKey /d:sonar.host.url=$sonarHost /d:sonar.login=$sonarToken

# Build
Write-Host "🔨 Buildando projeto..." -ForegroundColor Yellow
dotnet build

# Testes (opcional)
if (-not $SkipTests) {
    Write-Host "✅ Rodando testes..." -ForegroundColor Yellow
    dotnet test
}

# Finalizar análise
Write-Host "🔒 Finalizando análise..." -ForegroundColor Cyan
dotnet sonarscanner end /d:sonar.login=$sonarToken

Write-Host "✨ Análise concluída! Acesse: http://localhost:9000/" -ForegroundColor Green
