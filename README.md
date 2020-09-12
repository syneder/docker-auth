# Docker Registry v2 Authentication server

Docker Registry v2 provides a token-based authentication and authorization protocol.
This repository contains a .NET Core server providing authentication and authorization to the registry server using the tokens, according to a [specification](https://docs.docker.com/registry/spec/auth/).
The task of this server is very specific: to respond to successful authentication and authorization requests with a specially crafted JWT token.

## Docker Repositories

You can find Docker Registry Authentication server container image in [Docker Hub](https://hub.docker.com/r/syneder/docker-auth).

## Run server

You can quickly run a container with a pre-built [Docker image](https://hub.docker.com/r/syneder/docker-auth), based on the ASP.NET Core.
Type the following command to run authentication server:

```
docker run -it --rm -p 5000:80 --name docker-auth hub.docker.com/r/syneder/docker-auth:latest
```

This command will run a console app in a container that you can access in your web browser at `http://localhost:5000`.

**Important:** Don't use the above command for a production environment. Always use only secure HTTPS connection in production.

## License

[Apache License 2.0](/LICENSE)
