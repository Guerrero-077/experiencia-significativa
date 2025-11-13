# Script para limpiar completamente Docker y reconstruir desde cero

Write-Host "🧹 Limpiando contenedores, imágenes y volúmenes de Docker..." -ForegroundColor Yellow

# Detener todos los contenedores
Write-Host "`n1️⃣ Deteniendo todos los contenedores..." -ForegroundColor Cyan
docker stop $(docker ps -aq) 2>$null

# Eliminar todos los contenedores
Write-Host "`n2️⃣ Eliminando todos los contenedores..." -ForegroundColor Cyan
docker rm $(docker ps -aq) 2>$null

# Eliminar imágenes relacionadas con experiencias
Write-Host "`n3️⃣ Eliminando imágenes de experiencias-api..." -ForegroundColor Cyan
docker images | Select-String "experiencias-api" | ForEach-Object {
    $imageId = ($_ -split '\s+')[2]
    docker rmi -f $imageId
}

# Limpiar imágenes sin usar
Write-Host "`n4️⃣ Limpiando imágenes sin usar..." -ForegroundColor Cyan
docker image prune -af

# Limpiar caché de build
Write-Host "`n5️⃣ Limpiando caché de build..." -ForegroundColor Cyan
docker builder prune -af

# Limpiar volúmenes (CUIDADO: esto elimina datos de BD)
Write-Host "`n6️⃣ ¿Deseas eliminar VOLÚMENES (esto borrará datos de BD)? (S/N)" -ForegroundColor Red
$respuesta = Read-Host
if ($respuesta -eq 'S' -or $respuesta -eq 's') {
    docker volume prune -f
    Write-Host "✅ Volúmenes eliminados" -ForegroundColor Green
}

Write-Host "`n✅ Limpieza completada!" -ForegroundColor Green
Write-Host "`nAhora ejecuta tu pipeline de Jenkins o construye manualmente con:" -ForegroundColor Yellow
Write-Host "docker build -t experiencias-api-develop:latest -f API/Dockerfile ." -ForegroundColor White
