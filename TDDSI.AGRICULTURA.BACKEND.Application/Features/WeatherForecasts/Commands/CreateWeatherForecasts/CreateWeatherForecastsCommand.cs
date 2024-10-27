using TDDSI.AGRICULTURA.BACKEND.Application.Messaging;

namespace TDDSI.AGRICULTURA.BACKEND.Application.Features.WeatherForecasts.Commands.CreateWeatherForecasts;
public record CreateWeatherForecastsCommand(
    ) : ICommand<CreateWeatherForecastsResponse>;
