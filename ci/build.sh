#!/bin/sh

set -e

dotnet build source-code/Sample.csproj -c Release -r linux-x64
dotnet publish source-code/Sample.csproj -c Release -r linux-x64 -o out