PlanetsWebApp is an ASP.NET Core MVC web app which calls a SQL Server database to present the user with information on the planets in the Solar System.

**Options for running the app locally**

**Docker:**
The app can be run as two Docker containers communicating on a Docker network. First time setup can be performed by running the setup.sh file located in the PlanetsWebApp folder.
Alternatively, the following commands can be run via terminal in the PlanetsWebApp folder to manually set up the app in Docker:
```
docker network create planetswebappnetwork
docker build ./mssql/ -t mssql
docker run -d --name planetsdb_container --network=planetswebappnetwork --env-file ./mssql/.env mssql
docker build . -t planetswebapp
docker run -d -p 5000:80 --name planetswebapp_container --network=planetswebappnetwork planetswebapp
```

This will create the Docker network called planetswebappnetwork, then build a SQL Server image and deploy in a container called planetsdb_container, then build the app image and deploy in a
container called planetswebapp_container, connected on planetswebappnetwork. It is important that planetsdb_container should be running and have completed setup before the web app container
runs as otherwise the code-first generation of the database will fail.

Assuming either of the above methods have been used, open your browser and navigate to port 5000 to use the app.

**Visual Studio & IIS:**
The app can also be run by opening the solution in Visual Studio and running via IIS.
This assumes you have SQL Server installed on your machine.
Before running, open the appsettings.json file and in the ConnectionStrings section you will find two connection strings. Comment out this connection string:
```
PlanetsWebAppContext": "Data Source=planetsdb_container;User ID=sa;Password=P@ssword"
```
Then, uncomment this connection string:
```
//"PlanetsWebAppContext": "Server=(localdb)\\mssqllocaldb;Database=PlanetsWebAppDb;Trusted_Connection=True;MultipleActiveResultSets=true"
```
