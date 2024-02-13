# World of Anime

This is an application intended for anime and manga lovers that would like to keep track of what anime they watched, and what they want to watch, leave reviews, rate characters and so on. It consists of a web app, designes for the general audience, with the possibility of creating and account in order to get access to customized features, such as receiving personalised recommendations based on their preferred genres, and a desktop application used by admins and maintainers. The latter is designed to keep the content on the web page up-to-date with the latest releases and overall has an administrative function.
<br/><br/>Project duration: 18 weeks, Individual assignment - Year 1, semester 2

## Account Types
The desktop application supports two different account types with custom interfaces: 
1. **Admin**: tasked with administrating the website and finding maintainers
2. **Maintainer**: only has an administrative role
<br/>

The web application supports one account type as well as anonymous activity for the general audience:
1. **With account**: profile page, personalized recommendations, reviews custom lists
2. **No account**: browsing and filtering possibilities for all types of content

## Desktop Application Features
* Full CRUD operations for anime, manga and characters data
* Full CRUD operations for maintainer accounts (from admin side)
* Password reset
* Review moderation

## Web Application Features
#### For anonymous users
* Searching and filtering anime, manga and characters

#### For account holders 
* Searching and filtering anime, manga and characters
* Profile customization (name, profile picture, preferred genres, personalized lists)
* Real-time statistics (total time spent watching anime)
* Full CRUD operations for reviews
* Character upvote and downvote
* Anime and manga recommendations based on preferred genres

## Programming Languages

* C# .NET Framework for backend
* Windows Forms Library for the desktop application
* ASP.NET Razor Pages for the web application
* MS SQL for data persistance

## Application Development
- The project was developed using the Waterfall Methodology (see Binaries/Project Plan)
- It followed a clean 3-layer architecture consisting of presentation layer, logic layer and data layer
- The code strictly abides the SOLID design principles, making the application future proof and maintainable, offering the possibility of easily adding new features or account types

For other details, please check the Binaries folder as it contains important documents and diagrams related to the project's development.
