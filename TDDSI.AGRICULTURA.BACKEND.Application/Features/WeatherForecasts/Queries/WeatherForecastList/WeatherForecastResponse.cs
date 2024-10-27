using TDDSI.AGRICULTURA.BACKEND.Domain.WeatherForecasts.Dtos;

namespace TDDSI.AGRICULTURA.BACKEND.Application.Features.WeatherForecasts.Queries.WeatherForecastList;
public record WeatherForecastResponse(
    IEnumerable<WeatherForecastDto> WeatherForecasts
);
