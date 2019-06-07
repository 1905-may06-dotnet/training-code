# we ran...
#   dotnet new mvc -o MyMvc
#   cd MyMvc
#   # (create this file, and gitignore for /out)
#   dotnet publish -o out
#   docker build -t mymvc:0.1.0 .
#   docker run -p 9000:80 mymvc:0.1.0

# when you make Dockerfiles, the first question is: which base image
# do you want? (which base image has most or all of the dependencies for your app?)
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2

# we find that on docker hub (or any other registry)

# copy files into the image
COPY out/ /app

# here we use COPY and RUN to add anything else to the image
# that will be needed by the running app.

# what command will be used to start a container from the image
CMD [ "dotnet", "/app/MyMvc.dll" ]
