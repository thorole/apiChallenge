using dark_roasted_coffee_api.Models;

namespace dark_roasted_coffee_api.data.HandleData
{
    public interface IGetData
    {
        Task<IEnumerable<CoffeeDrink>> GetAllAsync();
        Task<IEnumerable<CoffeeDrink>> GetOneAsync(int id);
    }
}