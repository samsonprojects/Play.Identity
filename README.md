# Play.Identity

Playground for netcore identity service

## Create and publish package

```linux
version="1.0.2"
owner="samsonprojects"
gh_pat="[PAT HERE]"

dotnet pack src/Play.Identity.Contracts/ --configuration Release -p:PackageVersion=$version -p:RepositoryUrl=https://github.com/$owner/Play.Identity -o ../packages


dotnet nuget push ../packages/Play.Identity.Contracts.$version.nupkg --api-key $gh_pat --source "github"

```

## Build the docker image

```powershell
$env:GH_OWNER="samsonprojects"
$env:GH_PAT='[PAT HERE]'
docker build --secret id=GH_OWNER --secret id=GH_PAT -t play.identity:$version .

```

```linux
export GH_OWNER="samsonprojects"
export GH_PAT="[PAT HERE]"
docker build --secret id=GH_OWNER --secret id=GH_PAT -t play.identity:$version .
```

## Run the docker image and connect it with the same network as the mongodb and rabbitmq

```linux
adminPass="[PASSWORD HERE]"
docker run -it --rm -p 5002:5002 --name identity -e MongoDbSettings__Host=mongo -e RabbitMQSettings__Host=rabbitmq -e IdentitySettings__AdminUserPassword=$adminPass --network src_default play.identity:$version
```
