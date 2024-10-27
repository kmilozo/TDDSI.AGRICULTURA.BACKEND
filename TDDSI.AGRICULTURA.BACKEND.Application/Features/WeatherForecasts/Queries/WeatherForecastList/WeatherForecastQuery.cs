using TDDSI.AGRICULTURA.BACKEND.Application.Messaging;

namespace TDDSI.AGRICULTURA.BACKEND.Application.Features.WeatherForecasts.Queries.WeatherForecastList;
public record WeatherForecastQuery(
) : IQuery<WeatherForecastResponse>;
