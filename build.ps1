$IMAGE_NAME_AND_TAG="samples-weatherforecast:latest"

Write-Output "App [build]"
docker build -t $IMAGE_NAME_AND_TAG .