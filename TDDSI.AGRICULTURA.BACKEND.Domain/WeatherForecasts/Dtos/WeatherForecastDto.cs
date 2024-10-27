namespace TDDSI.AGRICULTURA.BACKEND.Domain.WeatherForecasts.Dtos;

public record WeatherForecastDto(
    Guid Id,
    DateTime Date,
    int TemperatureC,
    string? Summary,
    int TemperatureF,
    bool Enabled
);
