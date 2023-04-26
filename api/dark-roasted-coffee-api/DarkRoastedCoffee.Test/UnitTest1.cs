using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace DarkRoastedCoffee.Test
{
    public class UnitTest1
    {
        [Fact]
        public async void TestGetAllDrinks()
        {
            await using var application = new
            WebApplicationFactory<Program>();
            using var client = application.CreateClient();
            var response = await client.GetAsync("/coffeedrinks");
            var data = await response.Content.ReadAsStringAsync();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async void TestGetOneDrink()
        {
            await using var application = new
            WebApplicationFactory<Program>();
            using var client = application.CreateClient();
            var response = await client.GetAsync("/coffeedrinks?408");
            var data = await response.Content.ReadAsStringAsync();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}