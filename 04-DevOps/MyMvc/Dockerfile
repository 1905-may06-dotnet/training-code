# when you make Dockerfiles, the first question is: which base image
# do you want? (which base image has most or all of the dependencies for your app?)
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2

# we find that on docker hub (or any other registry)

# copy files into the image
COPY out/ /app

# what command will be used to start a container from the image
CMD [ "dotnet", "/app/MyMvc.dll" ]
