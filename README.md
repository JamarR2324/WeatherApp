# 🌦️ C# Weather Console App

A simple C# console application that fetches and displays the current weather for a user-specified city using the OpenWeatherMap API.

## 💻 Technologies

- C#
- .NET Core
- HttpClient
- JSON parsing with System.Text.Json

## 🚀 How to Run

1. Replace `"your_api_key"` in `Program.cs` with your [OpenWeatherMap API key](https://openweathermap.org/api).
2. Build and run the project:

```bash
dotnet new console -n csharp_weather_app
# Replace auto-generated Program.cs with this one
dotnet run --project csharp_weather_app
```

## 🧠 Features

- Prompts user for a city
- Calls OpenWeatherMap API
- Displays weather description and temperature

## 🛠️ To-Do

- Add error handling for invalid city names
- Display more detailed weather data
- Allow toggling between Celsius and Fahrenheit

---

Created with ☁️ and code by Jamar.
