# Cinema
## Overview
Mostly finished backend for cinema application, written in C#. I have separated storage and service parts of the code, app is focused around movies, seances and tickets.
## Service
This is where all CRUD operations, creation of DTOs and queries happen. All command classes have its validators and handlers. There are DTO classes for movie details, movies, seance details, seances and ticket details.
## Storage
This is where I've created all entity classes for movies, movie categories, seances and tickets, which are based on BaseEntity.cs class.
## Connection to database
I've used Entity Framework together with sql server express to connect data to application, with migration to SQL express server. CinemaTicketDbContext.cs inherits from DbContext and handles all data coming through entities.
