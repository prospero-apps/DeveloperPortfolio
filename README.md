# DeveloperPortfolio

This is my portfolio with my most important projects that I created as a Blazor application. I can use this app to show off my projects, also by category or the technology they use. 
![Home](https://github.com/prospero-apps/DeveloperPortfolio/assets/48125733/b57cfa29-b210-40da-a4b4-df0d6a98be0a)

The projects are stored in a database, as well as the categories and technologies. I can create, update and delete projects, categories and technologies. To do that I have to go to the “/Admin” address in my search bar.
![Admin Panel](https://github.com/prospero-apps/DeveloperPortfolio/assets/48125733/c99f3608-5b0b-4e62-859d-937c8693851d)

By clicking on a project you can go to its details page. There you can read about the technologies that were used in the project. There’s also some general info about the project and links to the respective Github repository or a live page, Amazon, Udemy, etc., depending on what links are relevant for any given project.
![Details](https://github.com/prospero-apps/DeveloperPortfolio/assets/48125733/f580beb9-c436-49b8-9428-97a41e8692e1)

You can use the sidebar to filter the projects by category or technology. There are also some links to my blogs and YouTube channels. 

## SOME TECHNICALITIES:

The solution contains three projects: 
- the Blazor WebAssembly project for the frontend,
- the ASP.NET Core Web API project for the backend,
- the Models project for the DTOs.

I added the Entities folder to the API project with the following classes:
- Project
- Category
- Tech
- Link
- ProjectTechRelation (used to associate projects with the technologies it uses).
![API](https://github.com/prospero-apps/DeveloperPortfolio/assets/48125733/818cc027-0faf-422e-9b4b-a3826d7b563c)

The Developer Portfolio project uses Entity Framework and the Microsoft SQL Server database (initially seeded with some data by overriding the OnModelCreating method in the DeveloperPortfolioDbContext class).
![Schemas](https://github.com/prospero-apps/DeveloperPortfolio/assets/48125733/77631a94-11e2-47e7-9ff0-bded4765b9c2)

The Models project contains the following Data Transfer Object (dto) classes:
- ProjectDto
- CategoryDto
- LinkDto
- TechDto

I used the Repository design pattern by creating the following repositories:
- ProjectRepository
- CategoryRepository
- TechRepository
They implement the corresponding interfaces. The repositories are registered for dependency injection in the Program class.

I created the following controller classes:
- ProjectController
- CategoryController
- TechController

I created some extension methods to convert data to DTOs.

In the Blazor WebAssembly project I created the Services folder for classes to handle interactions with the Web API component. In particular, there are the following services:
- ProjectService
- CategoryService
- TechService
They implement the corresponding interfaces.

There are methods that let you do the following with projects:
- retrieve all the projects,
- retrieve projects by category,
- retrieve projects by technology,
- retrieve one particular project by its id,
- create a project,
- update a project,
- delete a project
![Create Project](https://github.com/prospero-apps/DeveloperPortfolio/assets/48125733/d3da1aca-8d97-4ed5-8dec-a5647c87a4b0)

As far as categories are concerned, you can do the following:
- retrieve all the categories,
- retrieve one particular category by its id,
- create a category,
- update a category,
- delete a category

Similarly, you can do the following with technologies:
- retrieve all the technologies,
- retrieve one particular technology by its id,
- create a technology,
- update a technology,
- delete a technology

Most razor components inherit from corresponding base classes that themselves inherit from ComponentBase. Some minor components have both HTML and code in one file. The independent components, so the ones you can navigate to, are saved in the Pages folder, the others are in the Components folder. The appropriate services are injected in the appropriate classes. 

For styling I used Bootstrap as well as some custom styles. The latter are added in the app.css file if they are used by more than one component or component-wise for individual components. 

I also created a LoadingSpinner component that you can see while the data is being fetched from the API.

There is an Admin page that is supposed to be used only by me. If you want to look at it, just go to the “/Admin” address in the searchbar. There is no link to it. The Admin page enables me to manage the app. 
![Manage Projects](https://github.com/prospero-apps/DeveloperPortfolio/assets/48125733/cf92617d-7120-4369-b783-d16af6e39067)

The API project can be deployed to Azure App Service and the Blazor WebAssembly project is deployed to Azure Static Web Apps.
