#!/bin/bash

dotnet restore src/NLog/
dotnet restore src/NLog.Extended/ 
dotnet restore src/NLogAutoLoadExtension/
dotnet build src/NLog/  --configuration release
dotnet build src/NLog.Extended/  --configuration release
dotnet build src/NLogAutoLoadExtension/  --configuration release
