# How to run this project using Docker-Compose for local development

Follow these steps to run the provided `docker-compose.yml`.

## 1. Install Docker Desktop

## 2. Verify Docker Compose Installation
Docker Compose is bundled with Docker Desktop. After installing Docker Desktop, verify Docker Compose by running:
```bash
docker-compose --version
```

## 3. Prepare the Project Files
Pull entire git repository into any local directory e.g. `/your-directory`.\
Ensure that your project structure looks like this:
```bash
/your-directory
  ├── HospitalManager.API/
  │   └── Dockerfile
  ├── HospitalManager.Client/
  │   └── Dockerfile
  ├── HospitalManager.IDP/
  │   └── Dockerfile
  └── docker-compose.yml
  ```
This ensures that the Dockerfile for the ASP.NET Core API is located inside the api folder as expected by the docker-compose.yml.

## 4. Run Docker Compose

Open a terminal (PowerShell or Command Prompt) and navigate to the folder where your docker-compose.yml is located\
For the first run:
```bash
docker-compose up --build
```
For subsequent runs:
```bash
docker-compose up
```

## 5. Access the Services

Live API server should be accessible at `http://localhost:8081`.\
Live Client server should be accessible at `http://localhost:5123`.\
Live IDP server should be accessible at `http://localhost:5001`.\
Live Database should be accessible at `localhost:1521` with credentials `username: admin` and `password: StrongPWD1`.

## 6. Add domain translation

In order to be able to run identity provider on docker container there is need to add to local hosts file\
mapping translation from hm_idp to 127.0.0.1

## 7. Add migrations and update database

This project is using EF Core.

Create migration:
```bash
docker exec -it "<container-name>" dotnet ef migrations add "<migration-name>" --project /app
```

Update the database:
```bash
docker exec -it "<container-name>" dotnet ef database update --project /app
```