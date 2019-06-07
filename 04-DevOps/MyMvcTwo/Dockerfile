FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build

# sets the "current directory" (inside the image) for subsequent commands.
# best practice is to use it frequently
# (if the folder does not exist, it will be created)

WORKDIR /app

# take advantage of build cache,
# by only copying the csproj before dotnet restore.
# we will not re-run dotnet restore on a new image build...
# unless the csproj file (with its packagereferences) will change.

COPY *.csproj ./
RUN dotnet restore

# copy the whole current dir (the build context)
# into the image at the current dir (/app inside the image)
COPY . ./

RUN dotnet build --no-restore -c Release

RUN dotnet publish --no-build -c Release -o out

# if this werent the sdk it would work
# run on port 80, not SDK default of port 5000.
# ENV ASPNETCORE_URLS="http://+"

# multi-stage build, to combine the advantages
# of repeatable build environment with the ability to
# not publish source code / build-time dependencies
# with the final image.

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS deploy

WORKDIR /app

COPY --from=build /app/out ./

CMD [ "dotnet", "MyMvcTwo.dll" ]
