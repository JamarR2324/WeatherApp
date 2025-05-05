using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

class Program
{
    static async Task Main(string[] args)
    {
        Console.Write("Enter a city: ");
        string city = Console.ReadLine();
        string apiKey = "your_api_key"; // Replace with your OpenWeatherMap API key
        string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

        using HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            var weatherData = JsonDocument.Parse(json).RootElement;
            string weather = weatherData.GetProperty("weather")[0].GetProperty("description").GetString();
            double temp = weatherData.GetProperty("main").GetProperty("temp").GetDouble();

            Console.WriteLine($"Current weather in {city}: {weather}, {temp}°C");
        }
        else
        {
            Console.WriteLine("Error fetching weather data.");
        }
    }
}
