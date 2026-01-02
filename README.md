# C-Shopping-Cart
Project Overview

This is a simple ASP.NET Core Razor Pages Shopping Cart application. It allows users to view products, add them to a cart, and see the total price.

# Steps Taken to Build the Project
Created the Project
dotnet new razor -n CShoppingCart
cd CShoppingCart
dotnet run

Used the -n flag to specify the project name (CShoppingCart).
This created the project folder and initialized a Razor Pages app.
Set up Razor Pages
Created Index.cshtml for the main store page.
Added HTML markup to display products and the shopping cart.
Used Razor syntax (@model, @foreach) to dynamically display cart items.
Created Code-Behind
Added Index.cshtml.cs (code-behind) with IndexModel class.
Implemented:
Cart property to store shopping cart items.
OnPostAdd handler to add products to the cart.
Created a CartItem class with Name, Price, and Quantity.
Configured Project Structure
Ensured .csproj and .sln files are correctly located in the project folder (CShoppingCart/).
Cleaned old bin and obj folders to avoid duplicate assembly errors.

# Version Control
Used Git to track changes:
Added all project files (.csproj, .sln, Pages/, Models/, wwwroot/).
Committed updates for project structure, HTML changes, and code-behind logic.
Pushed changes to GitHub.
Resolved Build Issues
Fixed "Root element is missing" by ensuring .csproj was valid XML and inside the correct folder.
Resolved namespace errors (Microsoft.AspNetCore) by ensuring the correct target framework and restoring packages.
Removed duplicate AssemblyInfo conflicts by cleaning obj/ folders.

# Run the Project
Navigated into the project folder and ran:
dotnet run