﻿using TDDSI.AGRICULTURA.BACKEND.Domain.Abstractions;
using TDDSI.AGRICULTURA.BACKEND.Domain.Primitives;

namespace TDDSI.AGRICULTURA.BACKEND.Domain.WeatherForecasts;
public class WeatherForecast : Entity<Guid> {
    private WeatherForecast(
        DateOnly date,
        int temperatureC,
        string? summary,
        Temperature temperature
    ) {
        Id = Guid.NewGuid();
        Date = date;
        TemperatureC = temperatureC;
        Summary = summary;
        Temperature = temperature;
    }

    public DateOnly Date { get; private set; }
    public int TemperatureC { get; private set; }
    public string? Summary { get; private set; }
    public Temperature Temperature { get; private set; }

    public static WeatherForecast Create(
        DateOnly date,
        int temperatureC,
        string? summary
    ) => new(
        date,
        temperatureC,
        summary,
        Temperature.Generated( temperatureC )
    );

    public static string[] Summaries() =>
        [
           "Freezing",
           "Bracing",
           "Chilly",
           "Cool",
           "Mild",
           "Warm",
           "Balmy",
           "Hot",
           "Sweltering",
           "Scorching"
        ];
}
