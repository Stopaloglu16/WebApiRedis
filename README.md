#Info
This project demo of how to use Redis with using WebAPI

#Setup

##Setup Docker
Step 1 — Install and Run the container
docker run --name my-redis -p 6379:6379 -d redis

confirm Redis Docker is running by using docker ps

Step 2 — Connect to Redis 
Connect from inside the container or using Windows PowerSheel
docker exec -it my-redis sh

# redis-cli
127.0.0.1:6379> ping
PONG
127.0.0.1:6379> set name Bruce
OK
127.0.0.1:6379> get name
"Bruce"

##Setup WebApi
