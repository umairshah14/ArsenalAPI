# Arsenal Players and Managers API

This is a simple C# Web API project that allows you to manage information about Arsenal Football Club players and managers. The API supports basic CRUD operations via HTTP GET and POST requests, enabling you to add and retrieve information about players and managers.

## Project Overview

The API provides endpoints to manage the following information for Arsenal players:
- **Shirtnumber**: The player's shirt number.
- **First Name**: The player's first name.
- **Last Name**: The player's last name.
- **Age**: The player's age.
- **Nationality**: The player's nationality.
- **Position**: The position the player plays on the field (e.g., Forward, Midfielder, Defender, Goalkeeper).
- **Photo**: A URL link to the player's photo.

Additionally, you can manage information about Arsenal managers, although this README primarily covers player operations.

## Prerequisites

To run this project, you'll need the following installed on your system:
- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 5.0 or later)
- A tool for making HTTP requests, such as [Insomnia](https://insomnia.rest/) or [Postman](https://www.postman.com/).

## Getting Started

### 1. Clone the Repository

Clone the repository to your local machine:

```bash
git clone https://github.com/your-username/arsenal-api.git
cd arsenal-api
```

### 2. Build and Run the Project
Navigate to the project directory and build the project using the following commands:

```
dotnet build
dotnet run
```
The application will start the server, and you should see output indicating that the server is running on a specific port (e.g., http://localhost:5000).

### 3. Testing the API
You can use either Insomnia or Postman to interact with the API. Below are some basic instructions for performing GET and POST requests.

GET Request: Retrieve All Players
To retrieve a list of all players, make a GET request to the following URL: 
```
GET http://localhost:5000/players/
```
This will return a JSON array containing information about all the players currently stored in the system.

POST Request: Add a New Player
To add a new player, make a POST request to the following URL: 
```
POST http://localhost:5000/players/
```
In the request body, include a JSON object with the player's details:
```
{
  "shirtnumber": 7,
  "firstName": "Bukayo",
  "lastName": "Saka",
  "age": 22,
  "nationality": "England",
  "position": "Forward",
  "photo": "https://link-to-photo.com/saka.jpg"
}
```
### 4. Removing Information (To Be Implemented)
Currently, the API supports adding and retrieving player information. In future iterations, functionality for removing and updating player information will be added.

### 5. Accessing Manager Information
Similar to players, manager information can be added and retrieved using the respective endpoints (e.g., /managers/). Follow the same process as for players, replacing /players/ with /managers/.

## Future Enhancements
- **Implement DELETE and PUT requests for players and managers.**
- **Add validation and error handling for requests.**:
- **Expand the API to support team statistics and match results.**

## License
This project is open-source and available under the MIT License.
