using dark_roasted_coffee_api.data.HandleData;
using dark_roasted_coffee_api.data.Models;
using System.Runtime.CompilerServices;

namespace dark_roasted_coffee_api
{
    public static class Api
    {
        // Endpoint mapping including swagger descriptions/annotations
        public static void ConfigureApi(this WebApplication app)
        {
            app.MapGet("/coffeedrinks", GetAll)
                .Produces<List<CoffeeDrink>>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithName("listCoffeeDrinks")
                .WithTags("Coffee Drinks")
                .WithOpenApi(operation => new(operation)
                {
                    Summary = "List Coffee Drinks",
                    Description = "Returns a list of `Coffe Drink` objects."
                });

            app.MapGet("/coffeedrinks{id}", GetOne)
                .Produces<List<CoffeeDrink>>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithName("retrieveCoffeeDrink")
                .WithTags("Coffee Drinks")
                .WithOpenApi(operation => new(operation)
                {
                    Summary = "Retrieve a Coffee Drink",
                    Description = "Retrieves a single `Coffee Drink` object. It has details about a particular coffee drink."
                });

            static async Task<IResult> GetAll (IGetData data)
            {
                return await data.GetAllAsync()
                is IEnumerable<CoffeeDrink> coffeeDrinks
                ? TypedResults.Ok(coffeeDrinks)
                : TypedResults.NotFound();
            }

            static async Task<IResult> GetOne(IGetData data, int id)
            {
                var result = await data.GetOneAsync(id);
                return result.Any() ? TypedResults.Ok(result) : TypedResults.NotFound();
            }
        }
    }
}