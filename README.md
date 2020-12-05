# BlazorShopping
Simple demo on how to use Blazor.

## Content covered
- HTML template
- Shared base templates
- Static files in wwwroot
- Pages
- Code behind
- CSS isolation
- Page life cycle
- Components
- Parameters
- Model binding
- Event binding


## Use cases
This will create a simple app that will help out in the weekly shopping.
- In the planning section you can pick items that you need
- In the shopping section you tick every item you pick in the shop

## Deploy
1. Create a `appsettings.Development.json` file in the application root.
1. In it you override the `ApplicationDbContext` setting with your own conenctionstring to a SQL Server Database.
1. Ensure `ApplyDatabaseMigrations` is executed in the `Startup` `Configure` method.
1. When you launch the application the database schema will automatically be generated and some demo data will be added.
