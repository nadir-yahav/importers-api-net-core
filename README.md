WideWorldImportersAPI
WideWorldImportersAPI is an ASP.NET Core 8 API designed for managing customers and other related data. The project uses Entity Framework Core and SQL Server.

Prerequisites
Before starting, ensure that your system meets the following requirements:
.NET 8 SDK - Download
SQL Server (Version 2017 or later)
Git (if you want to clone the repository)
Postman or Swagger (for API testing)

Installation and Database Setup

1. Clone the repository:
git clone https://github.com/nadir-yahav/importers-api-net-core.git

3. Set up the SQL Server database:
Ensure that SQL Server is installed and running.
Restore the WideWorldImporters database using the provided backup file (WideWorldImporters.bak).

Update the appsettings.json file with your database connection string:

With SQL Server authentication (username and password):

"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=WideWorldImporters;User Id=YOUR_USER;Password=YOUR_PASSWORD;TrustServerCertificate=True;"
}

Using Windows Authentication (without username and password) for a local SQL Server:
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=WideWorldImporters;Trusted_Connection=True;TrustServerCertificate=True;"
}

Note: If you're using a local SQL Server, you do not need to change the connection string. The value localhost refers to the local machine running SQL Server.

Running the Project
Access the API documentation:
Open Swagger UI (default URL).

Use Swagger or Postman to interact with the API endpoints:

GET /api/customers - Retrieves all customers.
POST /api/customers - Adds a new customer.
PUT /api/customers/{id} - Updates an existing customer.
DELETE /api/customers/{id} - Deletes a customer.

Contributing
Feel free to fork the repository and submit pull requests.

License
This project is licensed under the MIT License.

