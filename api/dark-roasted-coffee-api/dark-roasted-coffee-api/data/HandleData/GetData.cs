using dark_roasted_coffee_api.data.Models;

namespace dark_roasted_coffee_api.data.HandleData
{
    public class GetData : IGetData
    {
        public async Task<IEnumerable<CoffeeDrink>> GetAllAsync()
        {
            IEnumerable<CoffeeDrink> coffeeDrinks = await GetConvertedRawDataAsync();
            return coffeeDrinks;
        }

        public async Task<IEnumerable<CoffeeDrink>> GetOneAsync(int id)
        {
            IEnumerable<CoffeeDrink> coffeeDrinks = await GetConvertedRawDataAsync();
            return coffeeDrinks.Where(drink => drink.Id == id);
        }

        //Utility method
        public static async Task<IEnumerable<CoffeeDrink>> GetConvertedRawDataAsync()
        {
            var json = await File.ReadAllTextAsync(@"Data\CoffeeData.json");
            IEnumerable<CoffeeDrink>? drinks = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<CoffeeDrink>>(json);
            return drinks != null ? drinks : Enumerable.Empty<CoffeeDrink>();
        }
    }
}