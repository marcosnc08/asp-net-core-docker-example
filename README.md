# ASP.NET Core application with Docker

This is a basic example app I made for a Medium post on how to configure Docker for a .NET Core app.

## Prerequisites

- .NET Core SDK
- Docker

## Run

    cd SampleApp
    dotnet restore
    dotnet run

## Run with Docker

On project root folder

    # build the Docker image
    docker build -t booktracker .
    
    # Run the image on a container on port 5000
    docker run -it --rm -p 5000:80 --name booktracker_container booktracker