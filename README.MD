# Build and push

run 

```sh 
dotnet build Sample.csproj -c Release -r linux-x64
dotnet publish Sample.csproj -c Release -r linux-x64 -o out
cf push sample -p out/ -b vws_proxy_buildpack -b dotnet_core_buildpack_cached
```