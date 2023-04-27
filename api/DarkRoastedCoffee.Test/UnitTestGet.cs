using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace DarkRoastedCoffee.Test
{
    public class UnitTestGet
    {
        // Test if endpoint returns any data
        [Fact]
        public async void TestGetAllDrinks()
        {
            await using var application = new
            WebApplicationFactory<Program>();
            using var client = application.CreateClient();
            var response = await client.GetAsync("/coffeedrinks");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }


        // Test for correct response for existing ids
        [Theory]
        [InlineData(408)]
        [InlineData(409)]
        [InlineData(410)]
        public async void TestGetOneDrinkResponseOk(int id)
        {
            await using var application = new
            WebApplicationFactory<Program>();
            using var client = application.CreateClient();
            var response = await client.GetAsync($"/coffeedrinks{id}");
            var data = await response.Content.ReadAsStringAsync();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        // Test for correct response for non-existent ids
        [Theory]
        [InlineData(-78)]
        [InlineData(-56)]
        [InlineData(-10)]
        public async void TestGetOneDrinkResponseNotFound(int id)
        {
            await using var application = new
            WebApplicationFactory<Program>();
            using var client = application.CreateClient();
            var response = await client.GetAsync($"/coffeedrinks{id}");
            var data = await response.Content.ReadAsStringAsync();
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}