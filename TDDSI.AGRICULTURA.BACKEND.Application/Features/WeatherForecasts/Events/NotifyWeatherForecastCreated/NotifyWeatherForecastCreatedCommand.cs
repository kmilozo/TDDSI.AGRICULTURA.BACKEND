using TDDSI.AGRICULTURA.BACKEND.Application.Messaging;

namespace TDDSI.AGRICULTURA.BACKEND.Application.Features.WeatherForecasts.Events.NotifyWeatherForecastCreated;
public record NotifyWeatherForecastCreatedCommand(
    string Proccess
) : INotify;
