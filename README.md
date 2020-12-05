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
This will create a simple app that will help out in the weekly food shopping. The idea is to have several persons in the same family use the same app to keep track of what needs to be bought in the weekly shopping.
- In the planning section you can pick items to buy on your next shopping
- In the shopping section you tick every item as you pick them in the shop
- Items picked before today will disappear from scope

## Deploy
1. Create a `appsettings.Development.json` file in the application root.
1. In it you override the `ApplicationDbContext` setting with a connection string to an existing empty SQL Server Database.
1. Ensure `ApplyDatabaseMigrations` is executed in the `Startup` `Configure` method.
1. When you launch the application the database schema will automatically be generated and some demo data will be added.
