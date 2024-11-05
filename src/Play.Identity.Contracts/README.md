# Play.Identity.Contracts

play around with microservices

## Create and publish package

```
version="1.0.2"
owner="samsonprojects"
gh_pat="[PAT HERE]"

dotnet pack src/Play.Identity.Contracts/ --configuration Release -p:PackageVersion=$version -p:RepositoryUrl=https://github.com/$owner/Play.Identity -o ../packages


dotnet nuget push ../packages/Play.Identity.Contracts.$version.nupkg --api-key $gh_pat --source "github"

```
