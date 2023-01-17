# Film Library
A Windows form application made using the .NET Framework that allows users to create, edit and store information about films. The application can store data in a microsoft SQL server or a text file as a fallback. The project uses Dapper in order to make communicating with the database easier. One of the main challenges I faced during this project was trying to implement a way to store data to both a text file and an SQL server as the ID's of the film's may differ between both connection types. I opted to prioritize using a SQL server as the data storage and a text file as a backup but this can be overriden when initializing the connection type in the 'Program.cs' class.

## How To Run Application
Once the project has been downloaded, navigate to the FilmLibrary\FilmLibraryUI\bin\Release\net6.0-windows folder and run the 'FilmLibraryUI.exe'. when starting the application it is configured to store data in a text file as the SQL server will only work on my local machine. Once a film has been added for the first time, a folder will be created on the C drive called 'Temp' that will store the text file for saving film data.

## Future Features
- Ability to store data about actors/actresses that appear in a given film
- Ability to store data about the director of a given film
- Ability to display images/trailers of a given film
- Ability to pull data from an IMDB API

## Screenshots

![Main Form](https://user-images.githubusercontent.com/15033950/212880577-bf7e6fb4-2296-41c9-ab1b-aff8ae868031.JPG)
![Add Film Form](https://user-images.githubusercontent.com/15033950/212880599-c17147b9-5f8d-4e2f-b22a-1298b20f4a7d.JPG)
![Edit Film Form](https://user-images.githubusercontent.com/15033950/212880610-1a0cb18e-8622-49b5-999c-d9f0bb94c89b.JPG)

https://user-images.githubusercontent.com/15033950/212879858-44be0de0-a99a-4d74-8da1-83f489bbeec3.mp4
