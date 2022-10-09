# Info
This project demo of how to use Redis with using WebAPI

# Technologies 🛠️

**[`Docker`](https://www.docker.com/)**
**[`Redis`](https://redis.com/)**
**[`Net Core API`](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio)**

# Setup 🚀

## Setup Redis on Docker
Step 1 — Install and Run the container
```
docker run --name my-redis -p 6379:6379 -d redis
```
confirm Redis Docker is running by using docker ps

Step 2 — Connect to Redis 
Connect from inside the container or using Windows PowerSheel
```
docker exec -it my-redis sh
```

```
# redis-cli
127.0.0.1:6379> ping
PONG
127.0.0.1:6379> set name Bruce
OK
127.0.0.1:6379> get name
"Bruce"
```

## Setup WebApi
Step 1 - Create project
Choosing "ASP.NET Core Web API" from project list on visual studio

Step 2 - Adding Nuget packages
Installing "Microsoft.Extensions.Caching.StackExchangeRedis" package

Step 3 - Setup appsetting file
Adding Redis connection 
```
"ConnectionStrings": {
    "Redis": "localhost:6379"
  }
```
Step 4 - Setup controller
Creating controller which contains GET, PUT, Delete methods

## Finalize
The project contains for saving data as single string and class/object mode

A little confusing 🤪, after calling function to save string successfully and checking from Docker console the type, it saves as **hash** type.

https://surfingthecode.com/redis-based-distributed-cache-in-asp.net-core/
https://learn.microsoft.com/en-us/aspnet/core/performance/caching/distributed?view=aspnetcore-3.1#distributed-redis-cache-1






