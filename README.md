# BlazorGameCatalog-BackendAPI

A comprehensive .NET application designed to manage and display a collection of video games. Essentially, it provides a backend that can retrieve games with the following properties: _Name_, _Genre_, _Price_, and _Release Date_. This backend also has the capability to perform Create, Read, Update, and Delete (**CRUD**) operations. The backend maintains a database to store these games and ensure data consistency.

The backend is used in conjunction with the frontend to display a table that lists all the games as provided by the backend, as illustrated below:
![Alt text](/Assets/image.png)

There are interactive buttons on the interface as shown. To begin with, the cross buttons (as indicated) are used to delete a game from the table. When clicked, a confirmation popup asks the user to confirm the game's deletion.
![Alt text](/Assets/image-1.png)

If the user confirms, the game is automatically erased from both the table and the backend database.

In addition, the "New Game" and the "Edit" buttons (indicated by the pencil icon) direct the user to another screen where they can add a new game or edit an existing one.
![Alt text](/Assets/image-2.png)

It is important to note that the input fields are mandatory, and correct values must be entered to add or edit a game's details.
![Alt text](/Assets/image-3.png)

Once a game is added, it is also saved to the database.

## Purpose of the Project

This project was developed as part of the learning process for **.NET** technology, implementing a backend in .NET and utilizing **Blazor** for the frontend. A significant advantage of this approach is that all the code is written in **C#**, such that a person with knowledge in C# (alongside some HTML, CSS, or Bootstrap skills) can understand the entire application.

## How to Run It

Please follow these steps to run the application:

> [!IMPORTANT]
> Before proceeding, ensure that you have .NET installed on your PC.

### Clone the Project

Clone this repository using the following command:
```cmd
git clone https://github.com/MateoManolio/BlazorGameCatalog-BackendAPI.git
```
(You may choose to clone using SSH or GitHub CLI based on your preference.)

### Run the Project

You'll need two terminals. Navigate to the cloned repository directory and proceed as follows:

1. In one terminal, execute the following commands to run the backend:
    ```cmd
    cd GameStore.API
    dotnet run
    ```

2. In a second terminal, start the frontend part with these commands:
    ```cmd
    cd GameStore.Frontend
    dotnet run
    ```

> [!NOTE]
> You will know if the project is running correctly based on messages like these appearing in the console for each section:
> 
> info: Microsoft.EntityFrameworkCore.Migrations[20405]
>     No migrations were applied. The database is already up to date.
> info: Microsoft.Hosting.Lifetime[14]
>     Now listening on: http://localhost:3000
> info: Microsoft.Hosting.Lifetime[0]
>     Application started. Press Ctrl+C to shut down.
> info: Microsoft.Hosting.Lifetime[0]
>     Hosting environment: Development
> info: Microsoft.Hosting.Lifetime[0]
>     Content root path: E:\Descargas\Blazor App\GameStore\GameStore.API
> 

### What's Next

With both the frontend and backend running, you can start exploring the application. Visit localhost:8080 in your web browser to interact with the frontend application. You should see a table populated with some games to begin with.

Alternatively, you can perform queries on the backend using localhost:3000/.... I recommend consulting the .http files found in the GameStore.API directory for more details on the available API endpoints.