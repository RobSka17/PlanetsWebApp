echo "Creating planetswebappnetwork...";
docker network create planetswebappnetwork

while [ ! $( docker ps -a | grep db_container | wc -l ) -gt 0 ];
do
echo "Waiting for mssql server container before starting web app container...";
docker build ./mssql/ -t mssql
docker run -d --name planetsdb_container --network=planetswebappnetwork --env-file ./mssql/.env mssql
done
echo "mssql server container running. Now building web app container...";

docker build . -t planetswebapp
docker run -d -p 5000:80 --name planetswebapp_container --network=planetswebappnetwork planetswebapp